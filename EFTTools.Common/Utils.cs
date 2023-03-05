using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace EFTTools.Common {

    public static class Utils {
        public static string BaseDir { get; set; } = "D:\\EFT";
        public static async ValueTask<T> DeserializeFromFileAsync<T>(string filePath) {
            if (!File.Exists(filePath)) throw new FileNotFoundException($"{filePath} 不存在,请检查安装位置");

            using var stream = File.OpenRead(filePath);
            return await JsonSerializer.DeserializeAsync<T>(stream) ?? throw new Exception($"Deserialize {typeof(T)} Error");
        }

        public static async ValueTask<JsonElement> ParseToJsonElementFromFileAsync(string filePath) {
            if (!File.Exists(filePath)) throw new FileNotFoundException($"{filePath} 不存在,请检查安装位置");

            using var stream = File.OpenRead(filePath);
            return (await JsonDocument.ParseAsync(stream))?.RootElement ?? throw new Exception($"Deserialize Error");
        }

        public static string GetFilePath(string filePath) {
            return Path.Combine(BaseDir, filePath);
        }

        public static JsonElement ParseToJsonElementFromFile(string filePath) {
            return JsonDocument.Parse(File.ReadAllText(filePath)).RootElement;
        }

        public static Dictionary<string, string> ToDictionary(this JsonElement element) {
            var dict = new Dictionary<string, string>();
            foreach (var item in element.EnumerateObject()) {
                dict.Add(item.Name, item.Value.ToString()!);
            }
            return dict;
        }
        public static JsonElement GetItemProps(this JsonElement element) {
            return element.GetProperty("_props");
        }

        public static bool TryGetItemSlots(this JsonElement element, [MaybeNullWhen(false)] out JsonElement slots) {
            if (!element.TryGetProperty("Slots", out slots)) {
                return false;
            }
            return true;
        }

        public static bool TryGetItemGrids(this JsonElement element, [MaybeNullWhen(false)] out JsonElement slots) {
            if (!element.TryGetProperty("Grids", out slots)) {
                return false;
            }
            return true;
        }

        public static bool GetItemFilters(this JsonElement element, [MaybeNullWhen(false)] out JsonElement filters) {
            if (!element.TryGetItemFilter(out filters)) {
                return false;
            }
            if (!filters.TryGetProperty("Filter", out filters)) {
                return false;
            }
            return true;
        }
        public static bool TryGetItemExcludedFilter(this JsonElement element, [MaybeNullWhen(false)] out JsonElement filters) {
            if (!element.TryGetItemFilter(out filters)) {
                return false;
            }
            if (!filters.TryGetProperty("ExcludedFilter", out filters)) {
                return false;
            }
            return true;
        }
        public static bool TryGetItemFilter(this JsonElement element, [MaybeNullWhen(false)] out JsonElement filters) {
            filters = default;
            if (!element.TryGetProperty("_props", out var props)) {
                return false;
            }
            if (!props.TryGetProperty("filters", out var f)) {
                return false;
            }
            var enumerator = f.EnumerateArray();
            if (!enumerator.MoveNext()) {
                return false;
            }
            filters = enumerator.Current;
            return true;
        }

        public static string Get(this JsonElement element, string propName) {
            if (element.TryGetProperty(propName, out var prop)) {
                return prop.ValueKind switch {
                    JsonValueKind.True => "是",
                    JsonValueKind.False => "否",
                    _ => prop.ToString()!,
                };
            }
            else {
                return "";
            }
        }

        public static string GetBundle(this JsonElement element) {
            if (!element.TryGetProperty("Prefab", out var prefab)) {
                return string.Empty;
            }
            if (!prefab.TryGetProperty("path", out var path)) {
                return string.Empty;
            }
            return path.GetString() ?? string.Empty;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace EFTTools.Common {
    public sealed class EFTData {
        private readonly Dictionary<string, ItemModel> idDict = new();
        private readonly Dictionary<string, string> ch;
        private readonly Dictionary<string, string> en;
        const string ITEM_54009119af1c881c07000029_NAME = "所有物品";
        const string ITEM_54009119af1c881c07000029_DESC = "所有物品的根类型";
        private static readonly (string? name, string? sname, string? des) ITEM_TEXT_54009119af1c881c07000029 =
            (ITEM_54009119af1c881c07000029_NAME, ITEM_54009119af1c881c07000029_NAME, ITEM_54009119af1c881c07000029_DESC);

        public EFTData() {
            ch = Utils.ParseToJsonElementFromFile(Utils.GetFilePath($@"Aki_Data\Server\database\locales\global\ch.json")).ToDictionary();

            en = Utils.ParseToJsonElementFromFile(Utils.GetFilePath($@"Aki_Data\Server\database\locales\global\en.json")).ToDictionary();

            var text = File.ReadAllText(Utils.GetFilePath($@"Aki_Data\Server\database\templates\items.json"));
            var jsondoc = JsonDocument.Parse(text).RootElement;
            foreach (var item in jsondoc.EnumerateObject()) {
                var (name, sname, des) = GetItemText(item.Name);
                idDict.Add(item.Name, new ItemModel(item.Name, item.Value.Get("_parent"), name, sname, des, item.Value));
            }
        }

        public bool GetItemInfo(string id, out ItemModel jsonElement) {
            return idDict!.TryGetValue(id, out jsonElement);
        }

        public IEnumerable<ItemModel> SearchItemByName(string name) {
            var names = name.Split(' ').Where(p => !string.IsNullOrWhiteSpace(p)).ToList();

            return idDict!.Values.Where(p => {
                var contains = true;
                foreach (var item in names) {
                    if (!p.ShortName.Contains(item, StringComparison.CurrentCultureIgnoreCase)) {
                        contains = false;
                        break;
                    }
                }
                if (contains) {
                    return true;
                }

                contains = true;
                foreach (var item in names) {
                    if (!p.Name.Contains(item, StringComparison.CurrentCultureIgnoreCase)) {
                        contains = false;
                        break;
                    }
                }
                return contains;
            });
        }


        public bool TryGetText(string key, [MaybeNullWhen(false)] out string text) {
            if (ch!.TryGetValue(key, out text)) {
                return true;
            }
            if (en!.TryGetValue(key, out text)) {
                return true;
            }
            return false;
        }

        public (string? name, string? sname, string? des) GetItemText(string id) {
            if (id == "54009119af1c881c07000029") {
                return ITEM_TEXT_54009119af1c881c07000029;
            }
            TryGetText($"{id} Name", out var name);
            TryGetText($"{id} ShortName", out var sname);
            TryGetText($"{id} Description", out var des);

            return (name?.Trim(), sname?.Trim(), des?.Trim());
        }

        public string GetItemName(string id) {
            if (id == "54009119af1c881c07000029") {
                return ITEM_TEXT_54009119af1c881c07000029.name ?? id;
            }
            TryGetText($"{id} Name", out var name);

            return name?.Trim() ?? id;
        }
    }
}
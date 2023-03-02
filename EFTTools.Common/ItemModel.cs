using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EFTTools.Common {
    public readonly struct ItemModel {
        public string Id { get; }
        public string Name { get; }
        public string ShortName { get; }
        public string Description { get; }
        public string ParentId { get; }
        public JsonElement JsonElement { get; }
        public ItemModel(string id, string? parentId, string? name, string? sname, string? desc, JsonElement json) {
            this.Id = id;
            this.ParentId = parentId ?? string.Empty;
            this.Name = name ?? id;
            this.ShortName = sname ?? string.Empty;
            this.Description = desc ?? string.Empty;
            this.JsonElement = json;
        }
    }
}
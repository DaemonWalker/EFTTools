using EFTTools.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTTools.MyItems {
    public sealed class ConfigModel : Dictionary<string, MapConfigModel> {
        public ConfigModel() {
            foreach (var item in Constants.Maps) {
                this.Add(item.Key, new MapConfigModel());
            }
        }
    }

    public sealed class MapConfigModel : Dictionary<string, MapItemConfigModel> { }

    public sealed class MapItemConfigModel {
        public string Tpl { get; set; } = null!;
        public int Probably { get; set; }
    }

    public static class MapConfigModelExtensions {
        public static MapConfigModel ToMapConfigModel(this Dictionary<string, MapItemConfigModel> dict) {
            var mapConfigModel = new MapConfigModel();
            foreach (var item in dict) {
                mapConfigModel.Add(item.Key, item.Value);
            }
            return mapConfigModel;
        }
    }
}

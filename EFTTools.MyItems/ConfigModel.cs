using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTTools.MyItems {
    public sealed class ConfigModel : Dictionary<string, MapConfigModel> {
    }

    public sealed class MapConfigModel : Dictionary<string, MapItemConfigModel> { }

    public sealed class MapItemConfigModel {
        public string Tpl { get; set; } = null!;
        public int Probably { get; set; }
    }
}

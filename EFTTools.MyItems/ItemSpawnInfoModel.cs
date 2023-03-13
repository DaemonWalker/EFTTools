using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTTools.MyItems {
    public class ItemSpawnInfoModel {
        public string OldTpl { get; set; } = null!;
        public string OldName { get; set; } = null!;
        public string NewTpl { get; set; } = string.Empty;
        public string NewName { get; set; } = string.Empty;
        public int RelativeProbability { get; set; }
        public int SpawnCount { get; set; }

        public ItemSpawnInfoModel(string oldTpl, string oldName, int relativeProbability, int spawnCount) {
            OldTpl = oldTpl;
            OldName = oldName;
            RelativeProbability = relativeProbability;
            SpawnCount = spawnCount;
        }
    }
}

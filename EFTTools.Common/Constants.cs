using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTTools.Common {
    public static class Constants {
        public static readonly IReadOnlyDictionary<string, string> Maps = new Dictionary<string, string> { 
            { "bigmap", "海关" }, 
            { "woods", "森林" }, 
            { "factory4_day", "工厂白天" }, 
            { "factory4_night", "工厂夜晚" }, 
            { "interchange", "立交桥" }, 
            { "laboratory", "实验室" }, 
            { "lighthouse", "灯塔" }, 
            { "rezervbase", "储备站" }, 
            { "shoreline", "海岸线" }, 
            { "tarkovstreets", "海关街区" } 
        };
    }
}

using EFTTools.Common;
using EFTTools.SharedControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTTools.MyItems {
    public partial class FrmItemSet : Form {
        private readonly EFTData eftData = FrmMain.EFTData;
        private readonly string mapName;
        private List<ItemSpawnInfoModel> dataSource = null!;
        private static readonly JsonSerializerOptions jsonSerializerOptions = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, WriteIndented = true };
        private const string configFilePath = "src/config.json";

        public FrmItemSet(string mapName) {
            InitializeComponent();
            this.mapName = mapName;
        }

        private void FrmItemSet_Load(object sender, EventArgs e) {
            lblMap.Text = $"地图:{Constants.Maps[mapName]}";
            var json = JsonDocument.Parse(File.ReadAllText(Utils.GetFilePath($"Aki_Data\\Server\\database\\locations\\{mapName}\\looseLoot.json"))).RootElement;
            var spawnpoints = json.GetProperty("spawnpoints");
            dataSource = spawnpoints.EnumerateArray().SelectMany(p =>
                p.GetProperty("itemDistribution").EnumerateArray().Select(
                    q => (tpl: q.Get("tpl"), prob: q.GetProperty("relativeProbability").GetInt32(), id: p.GetProperty("template").Get("Id"))))
                .GroupBy(p => p.tpl)
                .Select(p => new ItemSpawnInfoModel(p.Key, eftData.GetItemName(p.Key), p.Sum(q => q.prob) / p.Count(), p.Count()))
                .OrderBy(p => p.OldName.Trim())
                .ToList();

            if (LoadConfig().TryGetValue(mapName, out var conf) == true) {
                foreach (var item in dataSource) {
                    if (conf.TryGetValue(item.OldTpl, out var mapItem)) {
                        item.NewTpl = mapItem.Tpl;
                        item.RelativeProbability = mapItem.Probably;
                        item.NewName = eftData.GetItemName(item.NewTpl);
                    }
                }
            }

            dgvItemSet.DataSource = dataSource;
        }

        private void dgvItemSet_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) {
                return;
            }
            //MessageBox.Show(dgvItemSet.Columns[e.ColumnIndex].Name);
            var itemInfo = (dgvItemSet.Rows[e.RowIndex].DataBoundItem as ItemSpawnInfoModel)!;
            if (dgvItemSet.Columns[e.ColumnIndex].Name == nameof(colProb)) {
                itemInfo.NewTpl = itemInfo.OldTpl;
                itemInfo.NewName = itemInfo.OldName;
            }
            else if (dgvItemSet.Columns[e.ColumnIndex].Name == nameof(colNewItem)) {
                using var frmItemSearch = new FrmItemSearch(eftData, item => {
                    itemInfo.NewTpl = item.Id;
                    itemInfo.NewName = item.Name;
                });
                frmItemSearch.ShowDialog();
            }
            dgvItemSet.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            var conf = LoadConfig();
            conf[mapName] = dataSource.Where(p => !string.IsNullOrEmpty(p.NewTpl))
                .Select(p => new KeyValuePair<string, MapItemConfigModel>(p.OldTpl, new() { Tpl = p.NewTpl, Probably = p.RelativeProbability }))
                .ToDictionary(p => p.Key, p => p.Value)
                .ToMapConfigModel();
            if (!Directory.Exists("src")) {
                Directory.CreateDirectory("src");
            }
            File.WriteAllText(configFilePath, JsonSerializer.Serialize(conf, jsonSerializerOptions));
            FrmUtils.ShowSuccessMessage(message: "保存成功");
        }
        private static ConfigModel LoadConfig() {
            if (!File.Exists("src/config.json")) {
                return new ConfigModel();
            }
            var conf = JsonSerializer.Deserialize<ConfigModel>(File.ReadAllText("src/config.json"), jsonSerializerOptions)!;
            return conf;
        }

        private void dgvItemSet_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            if (dgvItemSet.Columns[e.ColumnIndex].Name != nameof(colNewTpl)) {
                return;
            }
            var tpl = dgvItemSet.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            var spawn = (dgvItemSet.Rows[e.RowIndex].DataBoundItem as ItemSpawnInfoModel)!;
            if (string.IsNullOrWhiteSpace(tpl)) {
                spawn.NewName = string.Empty;
                spawn.NewTpl = string.Empty;
            }
            else if (eftData.GetItemInfo(tpl, out var itemModel)) {
                spawn.NewTpl = itemModel.Id;
                spawn.NewName = itemModel.Name;
            }
            else {
                FrmUtils.ShowWarnMessage(message: $"未找到物品Id:{tpl}对应的物品");
                spawn.NewName = string.Empty;
                spawn.NewTpl = string.Empty;
            }
            dgvItemSet.Refresh();
        }

        private void btnBatchReplace_Click(object sender, EventArgs e) {
            using var batch = new FrmBatchReplace(this.eftData);
            if (batch.ShowDialog() != DialogResult.OK || dgvItemSet.SelectedRows.Count == 0) {
                return;
            }

            var newItemName = eftData.GetItemName(batch.NewTpl);
            foreach (DataGridViewRow row in dgvItemSet.SelectedRows) {
                var spawn = (row.DataBoundItem as ItemSpawnInfoModel)!;
                spawn.NewTpl = batch.NewTpl;
                spawn.RelativeProbability = batch.NewProb;
                spawn.NewName = newItemName;
            }

            dgvItemSet.Refresh();
        }
    }
}

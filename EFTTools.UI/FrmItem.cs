using EFTTools.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTTools.UI {
    public partial class FrmItem : Form {
        private readonly string itemId;
        private readonly EFTData eftData = FrmMain.EFTData;
        public FrmItem(string itemId) {
            InitializeComponent();
            this.itemId = itemId;
        }

        private void FrmItem_Load(object sender, EventArgs e) {
            if (!eftData.GetItemInfo(itemId, out var item)) {
                FrmUtils.ShowErrorMessage("物品不存在", $"物品Id[{itemId}]不存在");
            }
            this.Text = item.Name;
            var props = item.JsonElement.GetItemProps();
            panel.Controls.Add(new CtlTextItem("Id", item.Id));
            panel.Controls.Add(new CtlTextItem("名字", item.Name));
            panel.Controls.Add(new CtlTextItem("简称", item.ShortName));
            panel.Controls.Add(new CtlTextItem("描述", item.Description));
            panel.Controls.Add(new CtlTextItem("仓库高度", props.Get("Height")));
            panel.Controls.Add(new CtlTextItem("仓库宽度", props.Get("Width")));
            panel.Controls.Add(new CtlTextItem("堆叠数量", props.Get("StackMaxSize")));
            panel.Controls.Add(new CtlTextItem("重量", props.Get("Weight")));
            panel.Controls.Add(new CtlTextItem("bundle", props.GetBundle()));
            panel.Controls.Add(new CtlButtonItem("上级物品", new ButtonModel(GetItemName(item.ParentId), item.ParentId)));

            if (props.TryGetItemSlots(out var slots)) {
                foreach (var slot in slots.EnumerateArray()) {
                    var slotName = slot.Get("_name");
                    if (slot.GetItemFilters(out var filters)) {
                        var filterButtons = filters.EnumerateArray().Select(p => new ButtonModel(GetItemName(p.ToString()!), p.ToString()!)).ToList();
                        panel.Controls.Add(new CtlButtonItem($"插槽可用\n{slotName}", filterButtons.ToArray()));
                    }
                    if (slot.TryGetItemExcludedFilter(out var excludedFilterButtons)) {
                        var filterButtons = excludedFilterButtons.EnumerateArray().Select(p => new ButtonModel(GetItemName(p.ToString()!), p.ToString()!)).ToList();
                        panel.Controls.Add(new CtlButtonItem($"插槽禁用用\n{slotName}", filterButtons.ToArray()));
                    }
                }
            }

            if (props.TryGetItemGrids(out var grids)) {
                var gridFilters = new List<ButtonModel>();
                var gridExFilters = new List<ButtonModel>();
                foreach (var grid in grids.EnumerateArray()) {
                    var gridName = grid.Get("_name");
                    if (grid.GetItemFilters(out var filters)) {
                        gridFilters.AddRange(filters.EnumerateArray().Select(p => new ButtonModel(GetItemName(p.ToString()!), p.ToString()!)));
                    }
                    if (grid.TryGetItemExcludedFilter(out var excludedFilterButtons)) {
                        gridExFilters.AddRange(excludedFilterButtons.EnumerateArray().Select(p => new ButtonModel(GetItemName(p.ToString()!), p.ToString()!)));
                    }
                }
                if (gridFilters.Any()) {
                    panel.Controls.Add(new CtlButtonItem($"允许存放\n", gridFilters.ToArray()));
                }
                if (gridExFilters.Any()) {
                    panel.Controls.Add(new CtlButtonItem($"禁止存放\n", gridExFilters.ToArray()));
                }
            }

        }
        private static string GetItemName(string itemId) {
            var (name, _, _) = FrmMain.EFTData.GetItemText(itemId);
            return name ?? itemId;
        }
    }
}
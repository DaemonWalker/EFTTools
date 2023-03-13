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

namespace EFTTools.SharedControls {
    public partial class CtlSearchItem : UserControl {
        public Action<ItemModel>? OnSelectedCallback { get; set; }
        public EFTData EFTData { get; set; } = null!;
        public CtlSearchItem() {
            InitializeComponent();
            drpSearchType.SelectedIndex = 1;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtSearch.Text)) {
                FrmUtils.ShowWarnMessage(message: "请输入任意内容再进行搜索");
                return;
            }

            if (drpSearchType.SelectedIndex == 0) {
                if (EFTData.GetItemInfo(txtSearch.Text, out var item)) {
                    dgvItems.DataSource = new List<ItemModel>() { item };
                }
                return;
            }

            if (drpSearchType.SelectedIndex == 1) {
                var items = EFTData.SearchItemByName(txtSearch.Text).ToList();
                dgvItems.DataSource = items;
            }
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) {
                return;
            }
            var model = (ItemModel)dgvItems.Rows[e.RowIndex].DataBoundItem;
            OnSelectedCallback?.Invoke(model);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btnSearch_Click(null!, null!);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}

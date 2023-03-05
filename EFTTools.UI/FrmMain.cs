using EFTTools.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EFTTools.UI {
    public partial class FrmMain : Form {
        public static EFTData EFTData = null!;
        public FrmMain() {
            InitializeComponent();
        }


        private void FrmMain_Load(object sender, EventArgs e) {
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
            var id = dgvItems.Rows[e.RowIndex].Cells[0].Value.ToString()!;
            var frm = new FrmItem(id);
            frm.ShowDialog();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btnSearch_Click(null!, null!);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void FrmMain_Shown(object sender, EventArgs e) {
            if (File.Exists("EFT.pos")) {
                Utils.BaseDir = File.ReadAllText("EFT.pos");
            }
            else {
                if (fb.ShowDialog() != DialogResult.OK) {
                    this.Close();
                }
                File.WriteAllText("EFT.pos", fb.SelectedPath);
                Utils.BaseDir = fb.SelectedPath;
            }
            EFTData = new EFTData();
            dgvItems.AutoGenerateColumns = false;
            drpSearchType.SelectedIndex = 0;
        }
    }
}
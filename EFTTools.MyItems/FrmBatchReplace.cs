using EFTTools.Common;
using EFTTools.SharedControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTTools.MyItems {
    public partial class FrmBatchReplace : Form {
        private readonly EFTData eftData;
        public string NewTpl => this.txtNewTpl.Text;
        public int NewProb => Convert.ToInt32(this.txtProb.Value);
        public FrmBatchReplace(EFTData eftData) {
            InitializeComponent();
            this.eftData = eftData;
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmBatchReplace_Load(object sender, EventArgs e) {

        }

        private void btnReplace_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtNewTpl.Text) || !eftData.GetItemInfo(txtNewTpl.Text, out var item)) {
                FrmUtils.ShowWarnMessage(message: "请输入一个有效的物品Id");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}

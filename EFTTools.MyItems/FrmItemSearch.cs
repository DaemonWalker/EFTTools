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

namespace EFTTools.MyItems {
    public partial class FrmItemSearch : Form {
        private readonly Action<ItemModel> callback;
        public FrmItemSearch(EFTData eftData, Action<ItemModel> callback) {
            this.callback = callback;
            InitializeComponent();
            this.ctlSearchItem1.EFTData = eftData;
            this.ctlSearchItem1.OnSelectedCallback = this.Callback;
        }

        private void FrmItemSearch_Load(object sender, EventArgs e) {

        }

        private void Callback(ItemModel item) {
            callback(item);
            this.Close();
        }
    }
}

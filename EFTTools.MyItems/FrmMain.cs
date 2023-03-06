using EFTTools.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTTools.MyItems {
    public partial class FrmMain : Form {
        public FrmMain() {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            var mapDirs = new DirectoryInfo("D:\\ETF\\Aki_Data\\Server\\database\\locations").GetDirectories();
            foreach (var key in Constants.Maps.Keys) {
                if (mapDirs.Any(p => p.Name == key)) {
                    var btn = new Button() { Text = Constants.Maps[key] };
                    panel.Controls.Add(btn);
                }
            }
        }
    }
}

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
        public static EFTData EFTData { get; private set; } = null!;
        public FrmMain() {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            Utils.BaseDir = "D:\\ETF";

            var mapDirs = new DirectoryInfo(Utils.GetFilePath("Aki_Data\\Server\\database\\locations")).GetDirectories();
            foreach (var key in Constants.Maps.Keys) {
                if (mapDirs.Any(p => p.Name == key)) {
                    var btn = new Button() { Text = Constants.Maps[key], Tag = key, Height = 100, Width = 150, Font = this.Font };
                    btn.Click += Btn_Click;
                    panel.Controls.Add(btn);
                }
            }

            EFTData = new EFTData();
        }

        private void Btn_Click(object? sender, EventArgs e) {
            if (sender is not Button btn) {
                return;
            }

            var key = btn.Tag.ToString()!;
            var frmItem = new FrmItemSet(key);
            frmItem.Show();
        }
    }
}

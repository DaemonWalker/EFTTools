using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTTools.SharedControls {
    public static class FrmUtils {
        public static void ShowErrorMessage(string title = "错误", string message = "") {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowWarnMessage(string title = "警告", string message = "") {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void ShowSuccessMessage(string title = "提示", string message = "") {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Add(this DataGridView dt, params string[] data) {
            var rowIdx = dt.Rows.Add();
            for (var i = 0; i < data.Length; i++) {
                dt.Rows[rowIdx].Cells[i].Value = data[i];
            }
        }
    }
}
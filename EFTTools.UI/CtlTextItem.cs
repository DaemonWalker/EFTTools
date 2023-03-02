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
    public partial class CtlTextItem : UserControl {
        public CtlTextItem(string label, string text) {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.label1.Text = label;
            this.textBox1.Text = text;
            //this.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }
    }
}

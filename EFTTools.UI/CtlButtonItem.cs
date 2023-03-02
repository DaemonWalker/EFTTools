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
    public partial class CtlButtonItem : UserControl {
        public CtlButtonItem(string label, params ButtonModel[] buttons) {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.label1.Text = label;
            foreach (var button in buttons) {
                var btn = new Button() { Text = button.Text, Tag = button.Tag, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
                btn.Click += ButtonClick;
                panel.Controls.Add(btn);
            }
        }
        private static void ButtonClick(object? sender, EventArgs e) {
            if (sender is Button button) {
                var id = button.Tag.ToString()!;
                var frm = new FrmItem(id);
                frm.Show();
            }
        }
    }
    public readonly struct ButtonModel {
        public ButtonModel(string text, string tag) {
            this.Text = text;
            this.Tag = tag;
        }
        public string Text { get; }
        public string Tag { get; }
    }
}
using EFTTools.SharedControls;

namespace EFTTools.MyItems {
    partial class FrmItemSearch {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            SuspendLayout();
            // 
            // ctlSearchItem1
            // 
            ctlSearchItem1 = new CtlSearchItem();
            ctlSearchItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            ctlSearchItem1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ctlSearchItem1.Location = new System.Drawing.Point(0, 0);
            ctlSearchItem1.Margin = new System.Windows.Forms.Padding(4);
            ctlSearchItem1.Name = "ctlSearchItem1";
            ctlSearchItem1.Size = new System.Drawing.Size(800, 450);
            ctlSearchItem1.TabIndex = 0;
            // 
            // FrmItemSearch
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(ctlSearchItem1);
            Name = "FrmItemSearch";
            Text = "FrmItemSearch";
            Load += FrmItemSearch_Load;
            ResumeLayout(false);
        }

        #endregion

        private SharedControls.CtlSearchItem ctlSearchItem1;
    }
}
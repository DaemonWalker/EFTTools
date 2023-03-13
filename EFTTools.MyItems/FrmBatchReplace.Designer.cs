namespace EFTTools.MyItems {
    partial class FrmBatchReplace {
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
            label1 = new System.Windows.Forms.Label();
            txtNewTpl = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtProb = new System.Windows.Forms.NumericUpDown();
            btnReplace = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)txtProb).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(32, 30);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 21);
            label1.TabIndex = 0;
            label1.Text = "新物品Id";
            // 
            // txtNewTpl
            // 
            txtNewTpl.Location = new System.Drawing.Point(125, 27);
            txtNewTpl.Name = "txtNewTpl";
            txtNewTpl.Size = new System.Drawing.Size(412, 28);
            txtNewTpl.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 68);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 21);
            label2.TabIndex = 2;
            label2.Text = "新物品概率";
            // 
            // txtProb
            // 
            txtProb.Location = new System.Drawing.Point(125, 66);
            txtProb.Name = "txtProb";
            txtProb.Size = new System.Drawing.Size(412, 28);
            txtProb.TabIndex = 3;
            // 
            // btnReplace
            // 
            btnReplace.Location = new System.Drawing.Point(125, 110);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new System.Drawing.Size(75, 32);
            btnReplace.TabIndex = 4;
            btnReplace.Text = "确定";
            btnReplace.UseVisualStyleBackColor = true;
            btnReplace.Click += btnReplace_Click;
            // 
            // FrmBatchReplace
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(576, 157);
            Controls.Add(btnReplace);
            Controls.Add(txtProb);
            Controls.Add(label2);
            Controls.Add(txtNewTpl);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "FrmBatchReplace";
            Text = "批量替换";
            Load += FrmBatchReplace_Load;
            ((System.ComponentModel.ISupportInitialize)txtProb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewTpl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtProb;
        private System.Windows.Forms.Button btnReplace;
    }
}
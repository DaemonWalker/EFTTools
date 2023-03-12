namespace EFTTools.MyItems {
    partial class FrmItemSet {
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
            panel1 = new System.Windows.Forms.Panel();
            btnSave = new System.Windows.Forms.Button();
            lblMap = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            dgvItemSet = new System.Windows.Forms.DataGridView();
            colPreItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNewItem = new System.Windows.Forms.DataGridViewButtonColumn();
            colProb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colOldTpl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNewTpl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnBatchReplace = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemSet).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBatchReplace);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(lblMap);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1143, 68);
            panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSave.Location = new System.Drawing.Point(1040, 17);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 33);
            btnSave.TabIndex = 1;
            btnSave.Text = "保存";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblMap
            // 
            lblMap.AutoSize = true;
            lblMap.Location = new System.Drawing.Point(29, 23);
            lblMap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMap.Name = "lblMap";
            lblMap.Size = new System.Drawing.Size(55, 21);
            lblMap.TabIndex = 0;
            lblMap.Text = "label1";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvItemSet);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 68);
            panel2.Margin = new System.Windows.Forms.Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1143, 488);
            panel2.TabIndex = 1;
            // 
            // dgvItemSet
            // 
            dgvItemSet.AllowUserToAddRows = false;
            dgvItemSet.AllowUserToDeleteRows = false;
            dgvItemSet.AllowUserToOrderColumns = true;
            dgvItemSet.AllowUserToResizeColumns = false;
            dgvItemSet.AllowUserToResizeRows = false;
            dgvItemSet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvItemSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colPreItem, colNewItem, colProb, colCount, colOldTpl, colNewTpl });
            dgvItemSet.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvItemSet.Location = new System.Drawing.Point(0, 0);
            dgvItemSet.Margin = new System.Windows.Forms.Padding(4);
            dgvItemSet.Name = "dgvItemSet";
            dgvItemSet.RowTemplate.Height = 25;
            dgvItemSet.Size = new System.Drawing.Size(1143, 488);
            dgvItemSet.TabIndex = 0;
            dgvItemSet.CellClick += dgvItemSet_CellClick;
            dgvItemSet.CellEndEdit += dgvItemSet_CellEndEdit;
            // 
            // colPreItem
            // 
            colPreItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colPreItem.DataPropertyName = "OldName";
            colPreItem.FillWeight = 50F;
            colPreItem.HeaderText = "原物品";
            colPreItem.Name = "colPreItem";
            colPreItem.ReadOnly = true;
            // 
            // colNewItem
            // 
            colNewItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colNewItem.DataPropertyName = "NewName";
            colNewItem.FillWeight = 50F;
            colNewItem.HeaderText = "新物品";
            colNewItem.Name = "colNewItem";
            colNewItem.ReadOnly = true;
            // 
            // colProb
            // 
            colProb.DataPropertyName = "RelativeProbability";
            colProb.HeaderText = "概率";
            colProb.Name = "colProb";
            colProb.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            colProb.Width = 67;
            // 
            // colCount
            // 
            colCount.DataPropertyName = "SpawnCount";
            colCount.HeaderText = "刷新地点数";
            colCount.Name = "colCount";
            colCount.ReadOnly = true;
            colCount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            colCount.Width = 115;
            // 
            // colOldTpl
            // 
            colOldTpl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            colOldTpl.DataPropertyName = "OldTpl";
            colOldTpl.HeaderText = "原物品Id";
            colOldTpl.Name = "colOldTpl";
            colOldTpl.ReadOnly = true;
            colOldTpl.Width = 98;
            // 
            // colNewTpl
            // 
            colNewTpl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            colNewTpl.DataPropertyName = "NewTpl";
            colNewTpl.HeaderText = "新物品Id";
            colNewTpl.Name = "colNewTpl";
            colNewTpl.Width = 98;
            // 
            // btnBatchReplace
            // 
            btnBatchReplace.Location = new System.Drawing.Point(838, 17);
            btnBatchReplace.Name = "btnBatchReplace";
            btnBatchReplace.Size = new System.Drawing.Size(167, 33);
            btnBatchReplace.TabIndex = 2;
            btnBatchReplace.Text = "将选中列替换为";
            btnBatchReplace.UseVisualStyleBackColor = true;
            btnBatchReplace.Click += btnBatchReplace_Click;
            // 
            // FrmItemSet
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1143, 556);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "FrmItemSet";
            Text = "物品刷新设置";
            Load += FrmItemSet_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItemSet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.DataGridView dgvItemSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreItem;
        private System.Windows.Forms.DataGridViewButtonColumn colNewItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProb;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOldTpl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNewTpl;
        private System.Windows.Forms.Button btnBatchReplace;
    }
}
namespace EFTTools.SharedControls {
    partial class CtlSearchItem {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            panel1 = new System.Windows.Forms.Panel();
            btnSearch = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            drpSearchType = new System.Windows.Forms.ComboBox();
            panel2 = new System.Windows.Forms.Panel();
            dgvItems = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewLinkColumn();
            colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colSName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(drpSearchType);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(874, 75);
            panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSearch.Location = new System.Drawing.Point(779, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(75, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "搜索";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearch.Location = new System.Drawing.Point(232, 24);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(527, 28);
            txtSearch.TabIndex = 2;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // drpSearchType
            // 
            drpSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            drpSearchType.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            drpSearchType.FormattingEnabled = true;
            drpSearchType.Items.AddRange(new object[] { "物品Id", "物品名称" });
            drpSearchType.Location = new System.Drawing.Point(19, 24);
            drpSearchType.Name = "drpSearchType";
            drpSearchType.Size = new System.Drawing.Size(193, 29);
            drpSearchType.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvItems);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 75);
            panel2.Margin = new System.Windows.Forms.Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(874, 461);
            panel2.TabIndex = 1;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AllowUserToResizeRows = false;
            dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, colName, colSName });
            dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvItems.Location = new System.Drawing.Point(0, 0);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowTemplate.Height = 25;
            dgvItems.Size = new System.Drawing.Size(874, 461);
            dgvItems.TabIndex = 1;
            dgvItems.CellClick += dgvItems_CellClick;
            // 
            // Id
            // 
            Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            Id.Width = 31;
            // 
            // colName
            // 
            colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            colName.DataPropertyName = "Name";
            colName.HeaderText = "名称";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            colName.Width = 67;
            // 
            // colSName
            // 
            colSName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            colSName.DataPropertyName = "ShortName";
            colSName.HeaderText = "简称";
            colSName.Name = "colSName";
            colSName.ReadOnly = true;
            colSName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            colSName.Width = 67;
            // 
            // CtlSearchItem
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "CtlSearchItem";
            Size = new System.Drawing.Size(874, 536);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox drpSearchType;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewLinkColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSName;
    }
}

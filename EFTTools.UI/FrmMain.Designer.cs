using System.Drawing;
using System.Windows.Forms;

namespace EFTTools.UI {
    partial class FrmMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            dgvItems = new DataGridView();
            Id = new DataGridViewLinkColumn();
            colName = new DataGridViewTextBoxColumn();
            colSName = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            drpSearchType = new ComboBox();
            panel2 = new Panel();
            fb = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AllowUserToResizeRows = false;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { Id, colName, colSName });
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new Point(0, 0);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowTemplate.Height = 25;
            dgvItems.Size = new Size(800, 367);
            dgvItems.TabIndex = 0;
            dgvItems.CellClick += dgvItems_CellClick;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Resizable = DataGridViewTriState.False;
            Id.Width = 31;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colName.DataPropertyName = "Name";
            colName.HeaderText = "名称";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Resizable = DataGridViewTriState.False;
            colName.Width = 67;
            // 
            // colSName
            // 
            colSName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colSName.DataPropertyName = "ShortName";
            colSName.HeaderText = "简称";
            colSName.Name = "colSName";
            colSName.ReadOnly = true;
            colSName.Resizable = DataGridViewTriState.False;
            colSName.Width = 67;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(drpSearchType);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 83);
            panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(713, 30);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "搜索";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(223, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(472, 28);
            txtSearch.TabIndex = 1;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // drpSearchType
            // 
            drpSearchType.DropDownStyle = ComboBoxStyle.DropDownList;
            drpSearchType.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            drpSearchType.FormattingEnabled = true;
            drpSearchType.Items.AddRange(new object[] { "物品Id", "物品名称" });
            drpSearchType.Location = new Point(12, 30);
            drpSearchType.Name = "drpSearchType";
            drpSearchType.Size = new Size(193, 29);
            drpSearchType.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvItems);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(0, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 367);
            panel2.TabIndex = 1;
            // 
            // fb
            // 
            fb.SelectedPath = "D:\\EFT";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EFT物品信息查询";
            Load += FrmMain_Load;
            Shown += FrmMain_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtSearch;
        private ComboBox drpSearchType;
        private Panel panel2;
        private Button btnSearch;
        private DataGridView dgvItems;
        private DataGridViewLinkColumn Id;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colSName;
        private FolderBrowserDialog fb;
    }
}
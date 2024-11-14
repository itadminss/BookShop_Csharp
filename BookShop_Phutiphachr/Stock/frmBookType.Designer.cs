namespace BookShop_Phutiphachr.Stock
{
    partial class frmBookType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookType));
            this.labBookTypeID = new System.Windows.Forms.Label();
            this.txtBookTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBookType = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbShow = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookType)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labBookTypeID
            // 
            this.labBookTypeID.AutoSize = true;
            this.labBookTypeID.Location = new System.Drawing.Point(290, 95);
            this.labBookTypeID.Name = "labBookTypeID";
            this.labBookTypeID.Size = new System.Drawing.Size(0, 13);
            this.labBookTypeID.TabIndex = 10;
            // 
            // txtBookTypeName
            // 
            this.txtBookTypeName.Location = new System.Drawing.Point(135, 92);
            this.txtBookTypeName.Name = "txtBookTypeName";
            this.txtBookTypeName.Size = new System.Drawing.Size(155, 20);
            this.txtBookTypeName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ชื่อประเภทหนังสือ";
            // 
            // dgvBookType
            // 
            this.dgvBookType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookType.Location = new System.Drawing.Point(35, 128);
            this.dgvBookType.Name = "dgvBookType";
            this.dgvBookType.Size = new System.Drawing.Size(574, 150);
            this.dgvBookType.TabIndex = 7;
            this.dgvBookType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookType_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClear,
            this.tsbSave,
            this.tsbEdit,
            this.tsbDelete,
            this.tsbShow,
            this.toolStripLabel1,
            this.txtSearch,
            this.tsbSearch,
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 58);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbClear
            // 
            this.tsbClear.Image = global::BookShop_Phutiphachr.Properties.Resources.iconfinder_Gnome_Edit_Clear_32_54970;
            this.tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClear.Name = "tsbClear";
            this.tsbClear.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbClear.Size = new System.Drawing.Size(50, 55);
            this.tsbClear.Text = "เคลียร์";
            this.tsbClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbClear.Click += new System.EventHandler(this.tsbClear_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = global::BookShop_Phutiphachr.Properties.Resources.iconfinder_Save;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbSave.Size = new System.Drawing.Size(50, 55);
            this.tsbSave.Text = "บันทึก";
            this.tsbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSave.ToolTipText = "บันทึก";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::BookShop_Phutiphachr.Properties.Resources.Text_Edit_icon;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbEdit.Size = new System.Drawing.Size(50, 55);
            this.tsbEdit.Text = "แก้ไข";
            this.tsbEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::BookShop_Phutiphachr.Properties.Resources.delete_icon;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbDelete.Size = new System.Drawing.Size(50, 55);
            this.tsbDelete.Text = "ลบ";
            this.tsbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbShow
            // 
            this.tsbShow.Image = ((System.Drawing.Image)(resources.GetObject("tsbShow.Image")));
            this.tsbShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShow.Name = "tsbShow";
            this.tsbShow.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbShow.Size = new System.Drawing.Size(71, 55);
            this.tsbShow.Text = "แสดงข้อมูล";
            this.tsbShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(119, 55);
            this.toolStripLabel1.Text = "ป้อนรหัสหรือชื่อเพื่อค้นหา";
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(151, 58);
            // 
            // tsbSearch
            // 
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(40, 55);
            this.tsbSearch.Text = "ค้นหา";
            this.tsbSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = global::BookShop_Phutiphachr.Properties.Resources.Actions_window_close_icon1;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbClose.Size = new System.Drawing.Size(61, 55);
            this.tsbClose.Text = "ปิดฟอร์ม";
            this.tsbClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // frmBookType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labBookTypeID);
            this.Controls.Add(this.txtBookTypeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBookType);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmBookType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ประเภทหนังสือ";
            this.Load += new System.EventHandler(this.frmType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookType)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labBookTypeID;
        private System.Windows.Forms.TextBox txtBookTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBookType;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbShow;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbClose;
    }
}
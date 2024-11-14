namespace BookShop_Phutiphachr.Admin
{
    partial class frmPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPosition));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbShow = new System.Windows.Forms.ToolStripButton();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.dgvPosition = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPosName = new System.Windows.Forms.TextBox();
            this.labPosID = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(678, 58);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            this.tsbShow.Click += new System.EventHandler(this.tsbShow_Click);
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
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // dgvPosition
            // 
            this.dgvPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosition.Location = new System.Drawing.Point(35, 118);
            this.dgvPosition.Name = "dgvPosition";
            this.dgvPosition.Size = new System.Drawing.Size(574, 150);
            this.dgvPosition.TabIndex = 2;
            this.dgvPosition.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPosition_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ชื่อตำแหน่ง :";
            // 
            // txtPosName
            // 
            this.txtPosName.Location = new System.Drawing.Point(112, 82);
            this.txtPosName.Name = "txtPosName";
            this.txtPosName.Size = new System.Drawing.Size(155, 20);
            this.txtPosName.TabIndex = 4;
            // 
            // labPosID
            // 
            this.labPosID.AutoSize = true;
            this.labPosID.Location = new System.Drawing.Point(290, 85);
            this.labPosID.Name = "labPosID";
            this.labPosID.Size = new System.Drawing.Size(0, 13);
            this.labPosID.TabIndex = 5;
            // 
            // frmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 300);
            this.Controls.Add(this.labPosID);
            this.Controls.Add(this.txtPosName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPosition);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ข้อมูลตำแหน่ง";
            this.Load += new System.EventHandler(this.frmPosition_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dgvPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPosName;
        private System.Windows.Forms.Label labPosID;
    }
}
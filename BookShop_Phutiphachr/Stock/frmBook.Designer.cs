namespace BookShop_Phutiphachr.Stock
{
    partial class frmBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBook));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.labBookID = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.cboBookType = new System.Windows.Forms.ComboBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbEdit,
            this.tsbDelete,
            this.tsbClear,
            this.toolStripLabel1,
            this.txtSearch,
            this.tsbSearch,
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 58);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
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
            // btnSelectPicture
            // 
            this.btnSelectPicture.Location = new System.Drawing.Point(90, 457);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(110, 23);
            this.btnSelectPicture.TabIndex = 41;
            this.btnSelectPicture.Text = "เลือกรูุปภาพ";
            this.btnSelectPicture.UseVisualStyleBackColor = true;
            this.btnSelectPicture.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 326);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "รูปภาพ";
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(89, 326);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(110, 124);
            this.pic.TabIndex = 39;
            this.pic.TabStop = false;
            // 
            // labBookID
            // 
            this.labBookID.AutoSize = true;
            this.labBookID.Location = new System.Drawing.Point(18, 70);
            this.labBookID.Name = "labBookID";
            this.labBookID.Size = new System.Drawing.Size(0, 13);
            this.labBookID.TabIndex = 38;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(89, 241);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(110, 20);
            this.txtPrice.TabIndex = 36;
            // 
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(229, 90);
            this.dgvBook.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.Size = new System.Drawing.Size(432, 381);
            this.dgvBook.TabIndex = 34;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // cboBookType
            // 
            this.cboBookType.FormattingEnabled = true;
            this.cboBookType.Location = new System.Drawing.Point(89, 294);
            this.cboBookType.Margin = new System.Windows.Forms.Padding(2);
            this.cboBookType.Name = "cboBookType";
            this.cboBookType.Size = new System.Drawing.Size(110, 21);
            this.cboBookType.TabIndex = 33;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(89, 208);
            this.txtCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(110, 20);
            this.txtCost.TabIndex = 32;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(89, 173);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(2);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(110, 20);
            this.txtPublisher.TabIndex = 31;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(89, 138);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(110, 20);
            this.txtAuthor.TabIndex = 30;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(89, 103);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(110, 20);
            this.txtBookName.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 297);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "ประเภทหนังสืือ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 243);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "ราคาขาย";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "ต้นทุน";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "สำนักพิมพ์";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "ชื่อผู้แต่ง";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "ชื่อหนังสือ*";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(89, 267);
            this.txtStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(110, 20);
            this.txtStock.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 269);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "จำนวน";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_FileOk);
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSelectPicture);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.labBookID);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.cboBookType);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmBook";
            this.Text = "ข้อมูลหนังสือ";
            this.Load += new System.EventHandler(this.frmBook_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.Button btnSelectPicture;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label labBookID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.ComboBox cboBookType;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}
namespace BookShop_Phutiphachr
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.labUserID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.pic = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(701, 58);
            this.toolStrip1.TabIndex = 0;
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
            this.tsbClear.Click += new System.EventHandler(this.toolStripButton5_Click);
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
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ชื่อ-สกุล*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ที่อยู่";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "เบอร์โทร";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "เพศ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ชื่อผู้ใช้งาน*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "รหัสผ่าน*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 297);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "ตำแหน่ง";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 82);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(110, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(113, 117);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(110, 20);
            this.txtAddress.TabIndex = 9;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(113, 152);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(110, 20);
            this.txtTelephone.TabIndex = 10;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(113, 226);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(110, 20);
            this.txtUsername.TabIndex = 11;
            // 
            // cboPosition
            // 
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(113, 294);
            this.cboPosition.Margin = new System.Windows.Forms.Padding(2);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(110, 21);
            this.cboPosition.TabIndex = 13;
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(258, 69);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.Size = new System.Drawing.Size(432, 381);
            this.dgvUser.TabIndex = 14;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            this.dgvUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellDoubleClick);
            this.dgvUser.Click += new System.EventHandler(this.dgvUser_Click);
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(113, 188);
            this.radMale.Margin = new System.Windows.Forms.Padding(2);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(44, 17);
            this.radMale.TabIndex = 15;
            this.radMale.TabStop = true;
            this.radMale.Text = "ชาย";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(113, 259);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(110, 20);
            this.txtPassword.TabIndex = 16;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(168, 190);
            this.radFemale.Margin = new System.Windows.Forms.Padding(2);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(46, 17);
            this.radFemale.TabIndex = 17;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "หญิง";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // labUserID
            // 
            this.labUserID.AutoSize = true;
            this.labUserID.Location = new System.Drawing.Point(51, 69);
            this.labUserID.Name = "labUserID";
            this.labUserID.Size = new System.Drawing.Size(0, 13);
            this.labUserID.TabIndex = 18;
            this.labUserID.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 326);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "รูปภาพ";
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.Location = new System.Drawing.Point(113, 457);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(110, 23);
            this.btnSelectPicture.TabIndex = 21;
            this.btnSelectPicture.Text = "เลือกรูุปภาพ";
            this.btnSelectPicture.UseVisualStyleBackColor = true;
            this.btnSelectPicture.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(113, 326);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(110, 124);
            this.pic.TabIndex = 19;
            this.pic.TabStop = false;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 491);
            this.Controls.Add(this.btnSelectPicture);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.labUserID);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUser";
            this.Text = "จัดการข้อมูลพนักงาน";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.Label labUserID;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSelectPicture;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}
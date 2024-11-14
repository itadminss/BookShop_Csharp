namespace BookShop_Phutiphachr.Sale
{
    partial class frmSale
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmout = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labSaleDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labCost = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.labPrice = new System.Windows.Forms.Label();
            this.labBookName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labSaleTotal = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "วันที่ขาย";
            // 
            // txtAmout
            // 
            this.txtAmout.Location = new System.Drawing.Point(298, 39);
            this.txtAmout.Name = "txtAmout";
            this.txtAmout.Size = new System.Drawing.Size(63, 20);
            this.txtAmout.TabIndex = 2;
            this.txtAmout.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmout_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "รหัสหนังสือ";
            // 
            // labSaleDate
            // 
            this.labSaleDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labSaleDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labSaleDate.Location = new System.Drawing.Point(479, 24);
            this.labSaleDate.Name = "labSaleDate";
            this.labSaleDate.Size = new System.Drawing.Size(116, 19);
            this.labSaleDate.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(464, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 196);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::BookShop_Phutiphachr.Properties.Resources.iconfinder_close_delete_7097511;
            this.btnClose.Location = new System.Drawing.Point(11, 148);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 42);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "ปิดฟอร์ม";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::BookShop_Phutiphachr.Properties.Resources.iconfinder_Gnome_Edit_Clear_32_549701;
            this.btnClear.Location = new System.Drawing.Point(11, 102);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 40);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "เคลียร์รายการ";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::BookShop_Phutiphachr.Properties.Resources.iconfinder_print_56096;
            this.btnPrint.Location = new System.Drawing.Point(11, 58);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(110, 38);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "พิมพ์รายการ";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::BookShop_Phutiphachr.Properties.Resources.iconfinder_save_60316;
            this.btnSave.Location = new System.Drawing.Point(10, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 41);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "บันทึกรายการ";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSale);
            this.groupBox2.Location = new System.Drawing.Point(19, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 196);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // dgvSale
            // 
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookID,
            this.bookName,
            this.cost,
            this.price,
            this.amount,
            this.total});
            this.dgvSale.Location = new System.Drawing.Point(6, 11);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.Size = new System.Drawing.Size(427, 179);
            this.dgvSale.TabIndex = 0;
            // 
            // bookID
            // 
            this.bookID.HeaderText = "รหัสหนังสอ";
            this.bookID.Name = "bookID";
            // 
            // bookName
            // 
            this.bookName.HeaderText = "ชื่อหนังสือ";
            this.bookName.Name = "bookName";
            // 
            // cost
            // 
            this.cost.HeaderText = "ราคาทุน";
            this.cost.Name = "cost";
            this.cost.Visible = false;
            // 
            // price
            // 
            this.price.HeaderText = "ราคาขาย";
            this.price.Name = "price";
            // 
            // amount
            // 
            this.amount.HeaderText = "จำนวนที่ขาย";
            this.amount.Name = "amount";
            // 
            // total
            // 
            this.total.HeaderText = "รวมเงิน";
            this.total.Name = "total";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labCost);
            this.groupBox3.Controls.Add(this.labTotal);
            this.groupBox3.Controls.Add(this.txtBookID);
            this.groupBox3.Controls.Add(this.labPrice);
            this.groupBox3.Controls.Add(this.labBookName);
            this.groupBox3.Controls.Add(this.txtAmout);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(19, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 81);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // labCost
            // 
            this.labCost.AutoSize = true;
            this.labCost.Location = new System.Drawing.Point(243, 64);
            this.labCost.Name = "labCost";
            this.labCost.Size = new System.Drawing.Size(37, 13);
            this.labCost.TabIndex = 10;
            this.labCost.Text = "ต้นทุน";
            this.labCost.Visible = false;
            // 
            // labTotal
            // 
            this.labTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTotal.Location = new System.Drawing.Point(367, 39);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(66, 20);
            this.labTotal.TabIndex = 9;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(18, 38);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(73, 20);
            this.txtBookID.TabIndex = 7;
            this.txtBookID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBookID_KeyDown);
            // 
            // labPrice
            // 
            this.labPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labPrice.Location = new System.Drawing.Point(240, 38);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(44, 21);
            this.labPrice.TabIndex = 8;
            // 
            // labBookName
            // 
            this.labBookName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labBookName.Location = new System.Drawing.Point(107, 38);
            this.labBookName.Name = "labBookName";
            this.labBookName.Size = new System.Drawing.Size(122, 21);
            this.labBookName.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::BookShop_Phutiphachr.Properties.Resources.iconfinder_001_01_9588;
            this.btnAdd.Location = new System.Drawing.Point(455, 33);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 41);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "เพิ่มรายการ";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "รวมเงิน";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "จำนวนที่ขาย";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ราคาขาย";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ชื่อหนังสือ";
            // 
            // label11
            // 
            this.label11.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(354, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "รวมเงินค่าสินค้า";
            // 
            // labSaleTotal
            // 
            this.labSaleTotal.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.labSaleTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labSaleTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labSaleTotal.Location = new System.Drawing.Point(467, 332);
            this.labSaleTotal.Name = "labSaleTotal";
            this.labSaleTotal.Size = new System.Drawing.Size(136, 20);
            this.labSaleTotal.TabIndex = 11;
            this.labSaleTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(618, 368);
            this.Controls.Add(this.labSaleTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labSaleDate);
            this.Controls.Add(this.label1);
            this.Name = "frmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ขายหนังสือ";
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labSaleDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labBookName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labSaleTotal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labCost;
    }
}
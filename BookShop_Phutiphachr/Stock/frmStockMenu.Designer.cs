namespace BookShop_Phutiphachr.Stock
{
    partial class frmStockMenu
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbBook = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbType = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.รายงานขอมลหนงสอToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBook,
            this.toolStripSeparator1,
            this.tsbType,
            this.toolStripButton2,
            this.toolStripDropDownButton1,
            this.toolStripSeparator2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 54);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbBook
            // 
            this.tsbBook.Image = global::BookShop_Phutiphachr.Properties.Resources.iconfinder_book_285636;
            this.tsbBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBook.Name = "tsbBook";
            this.tsbBook.Size = new System.Drawing.Size(98, 51);
            this.tsbBook.Text = "จัดการข้อมูลหนังสือ";
            this.tsbBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBook.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // tsbType
            // 
            this.tsbType.Image = global::BookShop_Phutiphachr.Properties.Resources.booktype1;
            this.tsbType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbType.Name = "tsbType";
            this.tsbType.Size = new System.Drawing.Size(131, 51);
            this.tsbType.Text = "จัดการข้อมูลประเภทหนังสือ";
            this.tsbType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbType.Click += new System.EventHandler(this.tsbType_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::BookShop_Phutiphachr.Properties.Resources.product;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(80, 51);
            this.toolStripButton2.Text = "ทำรายการสั่งซื้อ";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.รายงานขอมลหนงสอToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::BookShop_Phutiphachr.Properties.Resources.iconfinder_25_33196192;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(53, 51);
            this.toolStripDropDownButton1.Text = "รายงาน";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // รายงานขอมลหนงสอToolStripMenuItem
            // 
            this.รายงานขอมลหนงสอToolStripMenuItem.Name = "รายงานขอมลหนงสอToolStripMenuItem";
            this.รายงานขอมลหนงสอToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.รายงานขอมลหนงสอToolStripMenuItem.Text = "รายงานข้อมูลหนังสือ";
            this.รายงานขอมลหนงสอToolStripMenuItem.Click += new System.EventHandler(this.รายงานขอมลหนงสอToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::BookShop_Phutiphachr.Properties.Resources.iconfinder_Forbidden;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(51, 51);
            this.toolStripButton3.Text = "ปิดฟอร์ม";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // frmStockMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmStockMenu";
            this.Text = "รายการทำงานพนักงานคลังสินค้า";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbBook;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbType;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem รายงานขอมลหนงสอToolStripMenuItem;
    }
}
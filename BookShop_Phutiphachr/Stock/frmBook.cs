using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShop_Phutiphachr.Model;
using System.IO;

namespace BookShop_Phutiphachr.Stock
{
    public partial class frmBook : Form
    {
        bool selectPic = false;
        string imagePath = Application.StartupPath.Substring(0, Application.StartupPath.Length - 9) + "images\\book\\";
        string oldFilname = "";
        public frmBook()
        {
            InitializeComponent();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {

            this.showDgvBook();
            this.showCboBookType();
        }
        private void showCboBookType()
        {
            BookType bookType = new BookType();
            DataTable dt = bookType.read();
            cboBookType.DataSource = dt;
            cboBookType.DisplayMember = "bookTypeName";
            cboBookType.ValueMember = "bookTypeID";
            
            
               
               
        }
        private void showDgvBook()
        {
            //อ่านข้อมูลจากตาราง tbBook มาแสดงที่ dgvBook
            //สร้าง object ของ class Book แล้วเรียก method read
            Book book = new Book();
            DataTable dt = book.read();
            dgvBook.DataSource = dt;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            //ตรวจสอบข้อมูลที่ต้องป้อน
            if(txtBookName.Text==""|| txtCost.Text == "" || txtStock.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน");
                return;
            }
            Book book = new Book();
            book.bookName = txtBookName.Text;
            book.author = txtAuthor.Text;
            book.publisher = txtPublisher.Text;
            book.cost = int.Parse(txtCost.Text);
            book.price = int.Parse(txtPrice.Text);
            book.stock = int.Parse(txtStock.Text);
            book.bookTypeID = int.Parse(cboBookType.SelectedValue.ToString());
            if (selectPic==true)
            {
                book.picture = ofd.SafeFileName;//ชื่อไฟล์
                File.Copy(ofd.FileName, imagePath + ofd.SafeFileName, true);
                selectPic = false;
                //File.Copy();
            }
            else
            {
                book.picture = "";
            }
            
            book.insert();
            this.clear();
            this.showDgvBook();
            MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "บันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        private void clear()
        {
            txtAuthor.Clear();txtBookName.Clear();txtCost.Clear();txtPrice.Clear();txtSearch.Clear();
            txtStock.Clear();
            pic.Image = null;
            cboBookType.Text = "";
            cboBookType.Text = "";
            labBookID.Text = "";
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            ofd.Filter = "เลือกรูปภาพ | *.jpeg;*.png";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                pic.Image = Image.FromFile(ofd.FileName);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                selectPic = true;
            }
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labBookID.Text = dgvBook.Rows[e.RowIndex].Cells["bookID"].Value.ToString();
            txtBookName.Text = dgvBook.Rows[e.RowIndex].Cells["bookName"].Value.ToString();
            txtAuthor.Text = dgvBook.Rows[e.RowIndex].Cells["author"].Value.ToString();
            txtPublisher.Text = dgvBook.Rows[e.RowIndex].Cells["publisher"].Value.ToString();
            txtCost.Text = dgvBook.Rows[e.RowIndex].Cells["cost"].Value.ToString();
            txtPrice.Text = dgvBook.Rows[e.RowIndex].Cells["price"].Value.ToString();
            txtStock.Text = dgvBook.Rows[e.RowIndex].Cells["stock"].Value.ToString();
            string fileName = dgvBook.Rows[e.RowIndex].Cells["picture"].Value.ToString();
            oldFilname = fileName;
            if (fileName != ""&& File.Exists(imagePath+fileName))
            {
                pic.Image = Image.FromFile(imagePath + fileName);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                
            }
            else
            {
                pic.Image = null;
            }
            cboBookType.Text = "";
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (labBookID.Text == "")
            {
                MessageBox.Show("กรุณาเลือกข้อมูลก่อน");
                return;
            }
            Book book = new Book();

            book.bookID = int.Parse(labBookID.Text);
            book.bookName = txtBookName.Text;
            book.author = txtAuthor.Text;
            book.publisher = txtPublisher.Text;
            book.cost = int.Parse(txtCost.Text);
            book.price = int.Parse(txtPrice.Text);
            book.stock = int.Parse(txtStock.Text);
            book.bookTypeID = int.Parse(cboBookType.SelectedValue.ToString());
            if (selectPic == true)
            {
                book.picture = ofd.SafeFileName;//ชื่อไฟล์
                File.Copy(ofd.FileName, imagePath + ofd.SafeFileName, true);
                selectPic = false;
                //File.Copy();
            }
            
            
            book.update();
            this.clear();
            this.showDgvBook();
            this.showCboBookType();
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย","แก้ไข",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (labBookID.Text == "")
            {
                MessageBox.Show("กรุณาเลือกข้อมูลที่ต้องการลบก่อน");
                return;
            }
            DialogResult result = MessageBox.Show("ต้องการลบข้อมูลหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result== DialogResult.Yes)
            {
                Book book = new Book();
                book.bookID = int.Parse(labBookID.Text);
                book.delete();
                this.showDgvBook();
                this.clear();
            }
            

        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            this.clear();
            this.showCboBookType();
            this.showDgvBook();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ofd_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

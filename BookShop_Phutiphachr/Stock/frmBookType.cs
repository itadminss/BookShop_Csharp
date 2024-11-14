using BookShop_Phutiphachr.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop_Phutiphachr.Stock
{
    public partial class frmBookType : Form
    {
        public frmBookType()
        {
            InitializeComponent();
        }

        private void frmType_Load(object sender, EventArgs e)
        {
            this.showDgvBookType();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            //ตรวจสอบว่ามีการป้อนข้อมูลหรือยัง
            if (txtBookTypeName.Text == "")
            {
                MessageBox.Show("ป้อนชื่อประเภทหนังสือ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //insert ข้อมูลดดยสร้า object ของคลาส BookType เรียกใช้ method insert
            BookType bookType = new BookType();
            bookType.bookTypeName = txtBookTypeName.Text;
            bookType.insert();
            MessageBox.Show("เพิ่มข้อมูลแล้ว", "ผลลัพธ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.clear();
            this.showDgvBookType();

        }
        private void clear()
        {
            txtBookTypeName.Clear(); labBookTypeID.Text = "";txtSearch.Clear();

        }
        private void showDgvBookType()
        {
            //เรียกใช้คลาส booktype ทำงาน
            BookType bookType = new BookType();//สร้าง object ของคลาส BookType
            DataTable dt = bookType.read();//เรียกใช้เมธอด read ใน class เพื่อส่งข้อมูลมาเก็บใน dt
            dgvBookType.DataSource = dt;//นำข้อมูลใน dt ไปแสดงที่ Datagrideview

        }

        private void dgvBookType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookTypeName.Text = dgvBookType.Rows[e.RowIndex].Cells["bookTypeName"].Value.ToString();
            labBookTypeID.Text = dgvBookType.Rows[e.RowIndex].Cells["bookTypeID"].Value.ToString();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (labBookTypeID.Text == "")
            {
                MessageBox.Show("เลือกข้อมูลในตารางที่จะแก้ไขก่อน");
                return;
            }
            BookType bookType = new BookType();
            bookType.bookTypeID = int.Parse(labBookTypeID.Text);
            bookType.bookTypeName = txtBookTypeName.Text;
            bookType.update();
            MessageBox.Show("แก้ไขข้อมูลแล้ว", "ผลลัพธ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.clear();
            this.showDgvBookType();


        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (labBookTypeID.Text == "")
            {
                MessageBox.Show("เลือกข้อมูลก่อน", "ผิดพาด", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }
            DialogResult result = MessageBox.Show("ต้องการลบข้อมูลหรือไม่", "เตือนการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                BookType bookType = new BookType();
                bookType.bookTypeID = int.Parse(labBookTypeID.Text);
                bookType.delete();
                MessageBox.Show("ลบข้อมูลแล้ว");
                this.clear();
                this.showDgvBookType();
            }
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(txtSearch.Text, out int bookTypeID);
            DataTable dt = new DataTable();
            BookType bookType = new BookType();

            if (isNumber)
            {
                bookType.bookTypeID = bookTypeID;
                dt = bookType.searchByID();
            }
            else
            {
                bookType.bookTypeName = txtSearch.Text;
                dt = bookType.searchByName();
            }
            if (dt.Rows.Count > 0)
            {
                dgvBookType.DataSource = dt;
            }
            else
            {
                dgvBookType.DataSource = null;
            }
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            this.clear();
            this.showDgvBookType();
        }
    }
}
    

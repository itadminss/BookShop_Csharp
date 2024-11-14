using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BookShop_Phutiphachr.Admin
{
    public partial class frmPosition : Form
    {
        SqlConnection con = new SqlConnection();
        public frmPosition()
        {
            InitializeComponent();
        }

        private void frmPosition_Load(object sender, EventArgs e)
        {
            //กำหนดรูปแบบการเชื่อมต่อ
            con.ConnectionString = "Server=localhost;Database=MyBookShop;User ID=sa;Password=Abc12345";
            con.Open();
            this.showDgvPosition();

           
        }
        private void showDgvPosition()
        {
            //อ่านข้อมูลจากตาราง tbposition
            string sql = "SELECT * FROM tbPosition";

            //ส่งคำสั่ง sql ให้ dataAdapter ประมวลผล
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            //ประกาศ datatable เก็บข้อมูล
            DataTable dtPosition = new DataTable();
            da.Fill(dtPosition);
            if (dtPosition.Rows.Count > 0)
            {
                //เอาข้อมูลใส่ใน dataGridview
                dgvPosition.DataSource = dtPosition;


            }
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {

            string sql = "";
            //ตรวจสอบการป้อนข้อมูล
            if (txtSearch.Text == "")
            {
                MessageBox.Show("ป้อนข้อมูล", "ค้นหา", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            //ตรวจสอบค่าที่ป้อนว่าเป็นตัวเลขหรือไม่ใช่ตัวเลข
            bool isNumber = int.TryParse(txtSearch.Text, out int posID);

            if (isNumber == true)//ตัวอักศร
            {
                sql = "SELECT * FROM tbPosition Where posID=@posID";
            }
            else//ตัวเลข
            {
                sql = "SELECT * FROM tbPosition WHERE posName LIKE @posName";
            }
            //นำข้อมูลที่ป้อนไปค้นหาในตาราง tbuser tbposition
            //string sql = "SELECT * FROM tbUser LEFT JOIN tbPosition ON tbUser.posID = tbPosition.posID WHERE tbUser.name=@name";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("@posID", txtSearch.Text);
            da.SelectCommand.Parameters.AddWithValue("@posName", "%" + txtSearch.Text + "%");
            DataTable dtPosition = new DataTable();
            da.Fill(dtPosition);
            if (dtPosition.Rows.Count > 0)
            {
                dgvPosition.DataSource = dtPosition;
            }
            else
            {
                MessageBox.Show("ไม่พข้อมูลที่ค้นหา", "ค้นหา", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbShow_Click(object sender, EventArgs e)
        {
            this.showDgvPosition();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (txtPosName.Text == "")
            {
                MessageBox.Show("ป้อนข้อมูลที่กำหนดก่อน", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String sql = "INSERT INTO tbPosition (posName) VALUES (@posName)";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@posName", txtPosName.Text);
            cm.ExecuteNonQuery();
            this.showDgvPosition();
            this.clear();
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "บันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            this.clear();

        }
        private void clear()
        {
            txtPosName.Clear();
            labPosID.Text = "";
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (labPosID.Text == "")
            {
                MessageBox.Show("เลือกข้อมูลในตารางเพื่อแก้ไขก่อน", "แก้ไข", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "UPDATE tbPosition SET posName=@posName WHERE posID=@posID" ;
            SqlCommand cm = new SqlCommand(sql,con);
            cm.Parameters.AddWithValue("@posName", txtPosName.Text);
            cm.Parameters.AddWithValue("@posID", labPosID.Text);
            cm.ExecuteNonQuery();
            this.showDgvPosition();
            this.clear();
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อยแล้ว", "แก้ไข", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPosName.Text = dgvPosition.Rows[e.RowIndex].Cells["posName"].Value.ToString();
            labPosID.Text = dgvPosition.Rows[e.RowIndex].Cells["posID"].Value.ToString();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (labPosID.Text == "")
            {
                MessageBox.Show("เลือกข้อมูลในตารางเพื่อลบก่อน", "ลบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("ต้องการลบข้อมูลนี้ใช่หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string sql = "DELETE FROM tbPosition WHERE posID=@posID";
                SqlCommand cm = new SqlCommand(sql,con);
                cm.Parameters.AddWithValue("@posID", labPosID.Text);
                cm.ExecuteNonQuery();
                this.showDgvPosition();
                this.clear();
                MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", "ลบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }
    }
}

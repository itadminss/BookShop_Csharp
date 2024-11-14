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
using System.IO;

namespace BookShop_Phutiphachr
{
    public partial class frmUser : Form
    {
        //ประกาศตัวแปรใช้งาน
        SqlConnection con= new SqlConnection();
        //ประกาศตัวแปรกับสถานะการเลือกรูป
        bool selectPic = false;
        //ลบpath file
        string imagePath = Application.StartupPath.Substring(0,Application.StartupPath.Length-9)+"images\\user\\";
        public frmUser()
        {
            InitializeComponent();
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

            private void frmUser_Load(object sender, EventArgs e)
        {
            //กำหนดรูปแบบการเชื่อมต่อ
            con.ConnectionString = "Server=localhost;Database=MyBookShop;User ID=sa;Password=Abc12345";
            con.Open();
            //อ่านข้อมูลจากตาราง tbuer
            string sql = "SELECT * FROM tbUser LEFT JOIN tbPosition ON tbUser.posID = tbPosition.posID";

            //ส่งคำสั่ง sql ให้ dataAdapter ประมวลผล
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            //ประกาศ datatable เก็บข้อมูล
            DataTable dtUser = new DataTable();
            da.Fill(dtUser);
            if (dtUser.Rows.Count > 0)
            {
                //เอาข้อมูลใส่ใน dataGridview
                dgvUser.DataSource = dtUser;
                dgvUser.Columns[5].Visible = false;//คอลลัม username
                dgvUser.Columns[6].Visible = false;//password
                dgvUser.Columns[7].Visible = false;//posid ของ tbuser
                dgvUser.Columns[8].Visible = false;//posid ของ tbposition
            }
            //ดึงข้อมูลจากตาราง tbposition มาแสดงที่ combobox
            sql = "SELECT * FROM tbPosition";
            da = new SqlDataAdapter(sql, con);
            DataTable dtPosition = new DataTable();
            da.Fill(dtPosition);

            //นำค่าใน dtPosition ไปใส่ combobox
            cboPosition.DataSource = dtPosition;
            cboPosition.DisplayMember = "posName";
            cboPosition.ValueMember = "posID";

        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            string sql = "";
            //ตรวจสอบการป้อนข้อมูล
            if (txtSearch.Text == "")
            {
                MessageBox.Show("ป้อนข้อมูล", "ค้นหา",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;

            }
            //ตรวจสอบค่าที่ป้อนว่าเป็นตัวเลขหรือไม่ใช่ตัวเลข
            bool isNumber = int.TryParse(txtSearch.Text, out int userID);

            if (isNumber == true)//ตัวอักศร
            {
                 sql = "SELECT * FROM tbUser LEFT JOIN tbPosition ON tbUser.posID = tbPosition.posID WHERE tbUser.userID=@userID";
            }
            else//ตัวเลข
            {
                sql = "SELECT * FROM tbUser LEFT JOIN tbPosition ON tbUser.posID = tbPosition.posID WHERE tbUser.name LIKE @name";
            }
            //นำข้อมูลที่ป้อนไปค้นหาในตาราง tbuser tbposition
            //string sql = "SELECT * FROM tbUser LEFT JOIN tbPosition ON tbUser.posID = tbPosition.posID WHERE tbUser.name=@name";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("@userID", txtSearch.Text);
            da.SelectCommand.Parameters.AddWithValue("@name", "%"+txtSearch.Text+"%");
            DataTable dtUser = new DataTable();
            da.Fill(dtUser);
            if (dtUser.Rows.Count > 0)
            {
                dgvUser.DataSource = dtUser;
            }
            else
            {
                MessageBox.Show("ไม่พข้อมูลที่ค้นหา", "ค้นหา", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbShow_Click(object sender, EventArgs e)
        {
            this.showDgvUser();
        }
        private void showDgvUser()
        {
            string sql = "SELECT * FROM tbUser LEFT JOIN tbPosition ON tbUser.posID = tbPosition.posID";

            //ส่งคำสั่ง sql ให้ dataAdapter ประมวลผล
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            //ประกาศ datatable เก็บข้อมูล
            DataTable dtUser = new DataTable();
            da.Fill(dtUser);
            if (dtUser.Rows.Count > 0)
            {
                //เอาข้อมูลใส่ใน dataGridview
                dgvUser.DataSource = dtUser;
                dgvUser.Columns[5].Visible = false;//คอลลัม username
                dgvUser.Columns[6].Visible = false;//password
                dgvUser.Columns[7].Visible = false;//posid ของ tbuser
                dgvUser.Columns[8].Visible = false;//picture
                dgvUser.Columns[9].Visible = false;//posid ของ tbposition


            }
        }
        private void showCboPosition()
        {

        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            
            //เขียนคำสั่งเพื่อเพิ่มข้อมูล

            //ตรวจสอข้อมูลที่ป้อน
            if (txtUsername.Text == ""|| txtPassword.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("ป้อนข้อมูลที่กำหนดก่อน", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //ต้องนำ txtUsername ไปตรวจในตาราง user
            //SELECT แบบมีเงื่อนไข  WHERE
            //ตรวจหาข้อมูลซ้ำ
            string sqlUser = "SELECT * FROM tbUser Where name=@name";
            SqlDataAdapter da = new SqlDataAdapter(sqlUser,con);
            da.SelectCommand.Parameters.AddWithValue("@name", txtName.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("ชื่อสกุลซ้ำ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //ประกาสตัวแปรเก็บเพศ
            string gender = "";
            string newFileName="";
            if (radMale.Checked==true)
            {
                gender = "ชาย";
            } else if(radFemale.Checked == true)
            {
                gender = "หญิง";
            }
            string picture = "";
            if (selectPic == true)
            // picture = ofd.SafeFileName;//อ่านชื่อรูปภาพเก้บไว้ในตัวแปร picture
            {
                picture = ofd.SafeFileName;
                //split หรือแยก ชื่อไฟล์หรือส่วนขยาย 
                string[] data = picture.Split('.');
                //MessageBox.Show("ชื่อไฟล์" + data[0] + "\r\n" + "ส่วนขยาย" + data[1);
                // return;
                //อ่านค่า userid คนถัดไป
                 string sqlcal  = "SELECT IDENT_CURRENT('tbUser') AS nextUserID";
                da = new SqlDataAdapter(sqlcal, con);
                dt = new DataTable();
                da.Fill(dt);
                string nextUserID =(int.Parse( dt.Rows[0]["nextUserID"].ToString())+1).ToString();
                 newFileName = nextUserID + "." + data[1];
                //MessageBox.Show(newFileName);

                //return;

        
            }
                
            


            //นำข้อมูลที่ป้อนไปจัดเก็บในตาราง
            string sql = "INSERT INTO tbUser (name,gender,address,telephone,username,password,posID,picture) " +
                "VALUES(@name,@gender,@address,@telephone,@username,@password,@posID,@picture)";
            //ประกาศ ออฟเจ็กต์ของ class sql command
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@name", txtName.Text);
            cm.Parameters.AddWithValue("@gender",gender);
            cm.Parameters.AddWithValue("@address", txtAddress.Text);
            cm.Parameters.AddWithValue("@telephone", txtTelephone.Text);
            cm.Parameters.AddWithValue("@username", txtUsername.Text);
            cm.Parameters.AddWithValue("@password", txtPassword.Text);
            cm.Parameters.AddWithValue("@posID", cboPosition.SelectedValue);
            cm.Parameters.AddWithValue("@picture", newFileName);
            cm.ExecuteNonQuery();
            MessageBox.Show("บันทึกข้อมูลแล้ว", "ผลลัพธ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //นำข้อมูลไปแสดงในที่ Datagrideview
            this.showDgvUser();
            //เคลียร์ฟอร์ม
            this.clear();

            
            if (selectPic)
            {
                //copy เอาชื่อไฟล์รุปไปเก้บไว้ใน project
                // File.Copy(ofd.FileName,imagePath+ofd.SafeFileName,true);
                File.Copy(ofd.FileName, imagePath + newFileName, true);
                selectPic = false;
            }

        }
        private void clear()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtTelephone.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            radFemale.Checked = false;
            radMale.Checked = false;
            cboPosition.Text = "";
            labUserID.Text = "";
            pic.Image = null;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            //ตรวจสอบว่ามีค่า userid ที่จะลบหรือไม่
            if (labUserID.Text == "")
            {
                MessageBox.Show("เลือกข้อมูลที่ต้องการลบก่อน", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //สร้าง messagebox ยืนยันการลบ
            DialogResult result = MessageBox.Show("ต้องการลบข้อมูลนี้ใช่หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                //เขียนคำสั่ง sql เพื่อลบข้อมูล ตาม userID
                string sql = "DELETE FROM tbUser WHERE userID=@userID";
                SqlCommand cm = new SqlCommand(sql,con);
                cm.Parameters.AddWithValue("@userID", labUserID.Text);
                cm.ExecuteNonQuery();
                // MessageBox.Show("ลบข้อมูลแล้ว", "ผลลัพธ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.showInformationMessageBox("ลบข้อมูลแล้ว", "ผลลัพธ์");
                this.showDgvUser();
                this.clear();
            }


        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //เมื่อคลิกแถวใน datagride จะนำข้อมูลไปแสดงที่ฟอร์ม
            txtName.Text = dgvUser.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txtAddress.Text = dgvUser.Rows[e.RowIndex].Cells["address"].Value.ToString();
            txtTelephone.Text = dgvUser.Rows[e.RowIndex].Cells["telephone"].Value.ToString();
            txtUsername.Text = dgvUser.Rows[e.RowIndex].Cells["username"].Value.ToString();

            txtPassword.Text = dgvUser.Rows[e.RowIndex].Cells["password"].Value.ToString();
            cboPosition.Text = dgvUser.Rows[e.RowIndex].Cells["posname"].Value.ToString();
            string gender = dgvUser.Rows[e.RowIndex].Cells["gender"].Value.ToString();
            if (gender == "ชาย")
                radMale.Checked = true;
            else if (gender == "หญิง")
                radFemale.Checked = true;

            labUserID.Text = dgvUser.Rows[e.RowIndex].Cells["userID"].Value.ToString();

            //แสดงชื่อรุปภาพจากตาราง
            string fileName= dgvUser.Rows[e.RowIndex].Cells["picture"].Value.ToString();

            if (fileName != "" && File.Exists(imagePath + fileName))
                {
                pic.Image = Image.FromFile(imagePath + fileName);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pic.Image = null;
            }



        }

        private void dgvUser_Click(object sender, EventArgs e)
        {

        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
           //ตรวจสอบได้ userid มาไหม
           if(labUserID.Text == "")
            {
                this.showErrorMessageBox("เลือกข้อมูลที่จะแก้ไขก่อน");
                return;
            }
            string gender = "";
            if (radMale.Checked == true)
                gender = "ชาย";         
                
            else if (radFemale.Checked == true)
                gender = "หญิง";
            string picture = "";
            string newFileName = "";
            if (selectPic == true)
            // picture = ofd.SafeFileName;//อ่านชื่อรูปภาพเก้บไว้ในตัวแปร picture
            {
                picture = ofd.SafeFileName;
                //split หรือแยก ชื่อไฟล์หรือส่วนขยาย 
                string[] data = picture.Split('.');
                //MessageBox.Show("ชื่อไฟล์" + data[0] + "\r\n" + "ส่วนขยาย" + data[1);
                // return;
                //อ่านค่า userid คนถัดไป
                 
                newFileName = labUserID.Text + "." + data[1];
                //MessageBox.Show(newFileName);

                //return;


            }
            //แก้ไขข้อมูล user
            string sqlUpdateUser = "UPDATE tbUser SET name=@name,gender=@gender,address=@address,telephone=@telephone,username=@username,password=@password,posID=@posID ";
            //ตรวจสอบว่ามีการแก้ไขรูปภาพหรือเปล่า
            if (selectPic)
                sqlUpdateUser += ",picture=@picture ";
            sqlUpdateUser += "WHERE userID=@userID";
            SqlCommand cm = new SqlCommand(sqlUpdateUser, con);
            cm.Parameters.AddWithValue("@name", txtName.Text);
            cm.Parameters.AddWithValue("@gender",gender);
            cm.Parameters.AddWithValue("@address", txtAddress.Text);
            cm.Parameters.AddWithValue("@telephone", txtTelephone.Text);
            cm.Parameters.AddWithValue("@username", txtUsername.Text);
            cm.Parameters.AddWithValue("@password", txtPassword.Text);
            cm.Parameters.AddWithValue("@posID", cboPosition.SelectedValue);
            cm.Parameters.AddWithValue("@userID", labUserID.Text);
            //cm.Parameters.AddWithValue("@picture", ofd.SafeFileName);
            cm.Parameters.AddWithValue("@picture", newFileName);
            cm.ExecuteNonQuery();
            if (selectPic)
                //File.Copy(ofd.FileName, imagePath + ofd.SafeFileName, true);
                File.Copy(ofd.FileName, imagePath + newFileName, true);
            this.showInformationMessageBox("แก้ไขเรียบร้อยแล้ว", "บันทึก");
            this.showDgvUser();
            this.clear();
            


        }
        private void showErrorMessageBox(string msg )
        {
            MessageBox.Show(msg, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void showInformationMessageBox(string msg,string title)
        {
            MessageBox.Show(msg,title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            //เปิดหน้าต่าง open file
            ofd.Filter = "เลือกไฟล์รูปภาพ|*.jpg;*.png;*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromFile(ofd.FileName);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                //ตัวแปรเก็บสถานะ ว่ามีการเลือกรูปภาพ
                selectPic = true;

            }
        }
    }
}

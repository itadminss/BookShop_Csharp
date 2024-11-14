using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShop_Phutiphachr.Manager;
using BookShop_Phutiphachr.Admin;
using BookShop_Phutiphachr.Sale;
using System.Data.SqlClient;
using BookShop_Phutiphachr.Stock;

namespace BookShop_Phutiphachr
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            this.actionLoginSqlAdapter();
            //this.actionLoginSqlCommand();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        

        private void actionLoginSqlAdapter()
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("ป้อนข้อมูลให้ครบก่อน", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            // if (txtUsername.Text == "somchai" || txtPassword.Text == "1234")

            // {
            //     frmAdminMenu frm = new frmAdminMenu();
            //     frm.Show();
            //    this.Hide();

            //}

            //นำ user pass ไปเช็คที่ฐานข้อมูล
            //ประกาศ sqlConnection
            SqlConnection con = new SqlConnection();
            //กำหนดรูปแบบการเชื่อมต่อกับฐานข้อมูล
            //string connectionString = "";
            con.ConnectionString = "Server=localhost;Database=MyBookShop;User ID=sa;Password=Abc12345";
            con.Open();
            //if (con.State == ConnectionState.Open){
            //   MessageBox.Show("OK");
            // }
            //เชียนคำสั่ง sql select แบบมีเงื่อนไข user password
            string sql = "SELECT * FROM tbUser WHERE username=@username AND password=@password";
            //select แบบ join
            // string sql = "SELECT * FROM tbUser"+
            //    "LEFT JOIN tbPosition"+
            //    "ON tbUser.posID = tbPosition.posID"+
            //    "WHERE username=@username"+
            //    "AND password=@password";
            //ประกาศ อ๊อบเจ๊กต์ sqlDataAdapter เพื่อส่งคำสั่ง sql ไปทำงาน
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            //กำหนดค่าให้พารามิตเตอร์
            da.SelectCommand.Parameters.AddWithValue("@username", txtUsername.Text);
            da.SelectCommand.Parameters.AddWithValue("@password", txtPassword.Text);
            //นำผลลัพธ์ที่ได้มาใช้ โดยประกาศอ๊อบเจ๊กค์ของคลาส Datatable ทำงาน
            DataTable dt = new DataTable();
            da.Fill(dt);
            //นำ DataTable ไปทำงาน
            if (dt.Rows.Count > 0)
            {
                string userID = dt.Rows[0]["userID"].ToString();
                string name = dt.Rows[0]["name"].ToString();
                string posID = dt.Rows[0]["posID"].ToString();
                // string posName = dt.Rows[0]["posName"].ToString();
                //MessageBox.Show("userID="+userID+"\r\n"+"name="+name);
                //เช็คตำแหน่ง user
                if (posID == "1")
                {
                    frmAdminMenu frm = new frmAdminMenu(name);
                    frm.Show();
                    this.Hide();
                }
                else if (posID == "2")
                {
                    frmSaleMenu frm = new frmSaleMenu(name,userID);
                    frm.Show();
                    this.Hide();
                }
                else if (posID == "3")
                {
                    frmStockMenu frm = new frmStockMenu();
                    frm.Show();
                    this.Hide();
                }
                else if (posID == "4")
                {
                    frmManagerMenu frm = new frmManagerMenu();
                    frm.Show();
                    this.Hide();
                }

            }
            else
            {
                // MessageBox.Show("ไม่พบ");
                MessageBox.Show("ผู้ใช้หรือรหัสไม่ถูกต้อง", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void actionLoginSqlCommand()
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("ป้อนข้อมูลให้ครบก่อน", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            // if (txtUsername.Text == "somchai" || txtPassword.Text == "1234")

            // {
            //     frmAdminMenu frm = new frmAdminMenu();
            //     frm.Show();
            //    this.Hide();

            //}

            //นำ user pass ไปเช็คที่ฐานข้อมูล
            //ประกาศ sqlConnection
            SqlConnection con = new SqlConnection();
            //กำหนดรูปแบบการเชื่อมต่อกับฐานข้อมูล
            //string connectionString = "";
            con.ConnectionString = "Server=localhost;Database=MyBookShop;User ID=sa;Password=Abc12345";
            con.Open();
            //if (con.State == ConnectionState.Open){
            //   MessageBox.Show("OK");
            // }
            //เชียนคำสั่ง sql select แบบมีเงื่อนไข user password
            string sql = "SELECT * FROM tbUser WHERE username=@username AND password=@password";
            //select แบบ join
            // string sql = "SELECT * FROM tbUser"+
            //    "LEFT JOIN tbPosition"+
            //    "ON tbUser.posID = tbPosition.posID"+
            //    "WHERE username=@username"+
            //    "AND password=@password";
            //ประกาศ อ๊อบเจ๊กต์ sqlDataAdapter เพื่อส่งคำสั่ง sql ไปทำงาน
            //SqlDataAdapter da = new SqlDataAdapter(sql, con);
            SqlCommand cm = new SqlCommand(sql,con);
            //กำหนดค่าให้พารามิตเตอร์
            cm.Parameters.AddWithValue("@username", txtUsername.Text);
            cm.Parameters.AddWithValue("@password", txtUsername.Text);
            //da.SelectCommand.Parameters.AddWithValue("@username", txtUsername.Text);
            // da.SelectCommand.Parameters.AddWithValue("@password", txtPassword.Text);
            //นำผลลัพธ์ที่ได้มาใช้ โดยประกาศอ๊อบเจ๊กค์ของคลาส Datatable ทำงาน

            SqlDataReader dr = cm.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            //da.Fill(dt);
            //นำ DataTable ไปทำงาน
            if (dt.Rows.Count > 0)
            {
                string userID = dt.Rows[0]["userID"].ToString();
                string name = dt.Rows[0]["name"].ToString();
                string posID = dt.Rows[0]["posID"].ToString();
                // string posName = dt.Rows[0]["posName"].ToString();
                //MessageBox.Show("userID="+userID+"\r\n"+"name="+name);
                //เช็คตำแหน่ง user
                if (posID == "1")
                {
                    frmAdminMenu frm = new frmAdminMenu(name);
                    frm.Show();
                    this.Hide();
                }
                else if (posID == "2")
                {
                    frmSaleMenu frm = new frmSaleMenu(name,userID);
                    frm.Show();
                    this.Hide();
                }
                else if (posID == "3")
                {
                    frmStockMenu frm = new frmStockMenu();
                    frm.Show();
                    this.Hide();
                }
                else if (posID == "4")
                {
                    frmManagerMenu frm = new frmManagerMenu();
                    frm.Show();
                    this.Hide();
                }

            }
            else
            {
                // MessageBox.Show("ไม่พบ");
                MessageBox.Show("ผู้ใช้หรือรหัสไม่ถูกต้อ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

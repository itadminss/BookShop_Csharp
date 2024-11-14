using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BookShop_Phutiphachr.Model
{
    class BookType
    {
        //กำหนด properties ของ คลาส( table)

        //การใช้ พิมพ์ prop กด tab----
        public int bookTypeID { get; set; }
        public string bookTypeName { get; set; }

        // SqlConnection con; ใช้ได้เหมือนกันกับด้านล่าง
        SqlConnection con = new SqlConnection();

        //1.กำหนดรูปแบบการเชื่อมต่อที่เมธอที่เรียกว่า Constructor คือเมธอดที่ใช้ชื่อเดียวกับคลาส กำหนดค่าการเชื่อมต่อกับฐานข้อมูล
        public BookType()
        {
            string conString = "Server=localhost;Database=MyBookShop;User ID=sa;Password=Abc12345";
            con = new SqlConnection(conString);

        }
        //2.สร้างเมธอดสำหรับ เพิ่ม ลบ แก้ไข แสดงและค้นหา CRUD Operation

        //เมธอดสำหรับอ่านข้อมูล SELECT
        public DataTable read()
        {
            DataTable dt = new DataTable();
            //เปิดการเชื่อมต่อ
            con.Open();
            string sql = "SELECT * FROM tbBookType";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            //ส่งค่าออกไป
            return dt;
        }
        public void insert()//เพิ่มข้อมูล
        {
            con.Open();
            string sql = "INSERT INTO tbbookType (bookTypeName) VALUES (@bookTypeName)";
            SqlCommand cm = new SqlCommand(sql,con);
            cm.Parameters.AddWithValue("@bookTypeName", this.bookTypeName);
            cm.ExecuteNonQuery();
            con.Close();
            

        }
        public void update()//แก้ไขข้อมูล
        {
            con.Open();
            string sql = "UPDATE tbbookType SET bookTypeName=@bookTypeName WHERE bookTypeID=@bookTypeID";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@bookTypeName", this.bookTypeName);
            cm.Parameters.AddWithValue("@bookTypeID", this.bookTypeID);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void delete()
        {
            con.Open();
            string sql = "DELETE FROM tbbookType WHERE bookTypeID=@bookTypeID";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@bookTypeID", this.bookTypeID);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public DataTable searchByID()
        {
            DataTable dt = new DataTable();
            con.Open();
            string sql = "SELECT * FROM tbbookType WHERE bookTypeID=@bookTypeID";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("@bookTypeID", this.bookTypeID);
            da.Fill(dt);
            con.Close();

            return dt;
        }
        public DataTable searchByName()
        {
            DataTable dt = new DataTable();
            con.Open();
            string sql = "SELECT * FROM tbbookType LIKE bookTypeName=@bookTypeName";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("@bookTypeName",this.bookTypeName+ "%");
            da.Fill(dt);
            con.Close();

            return dt;
        }
    }
}
        


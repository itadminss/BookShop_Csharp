using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BookShop_Phutiphachr.Model
{
    class Book
    {
        //กำหนด properties โดยพิมพ์ prop แล้วกด tab
        public int bookID { get; set; }
        public string bookName { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public int cost { get; set; }
        public int price { get; set; }
        public int stock { get; set; }
        public string picture { get; set; }
        public int bookTypeID{ get; set; }
        //สร้าง method constructor
        SqlConnection con = new SqlConnection();
        public Book()
        {
            string conString = "Server=localhost;Database=MyBookShop;User ID=sa;Password=Abc12345";
            con = new SqlConnection(conString);
        }
        public void insert()
        {
            con.Open();
            string sql = "INSERT INTO tbBook(bookName,author,publisher,cost,price,stock,picture,bookTypeID) " +
                "VALUES (@bookName,@author,@publisher,@cost,@price,@stock,@picture,@bookTypeID)";
            SqlCommand cm = new SqlCommand(sql,con);
            cm.Parameters.AddWithValue("@bookName", this.bookName);
            cm.Parameters.AddWithValue("@author", this.author);
            cm.Parameters.AddWithValue("@publisher", this.publisher);
            cm.Parameters.AddWithValue("@cost", this.cost);
            cm.Parameters.AddWithValue("@price", this.price);
            cm.Parameters.AddWithValue("@stock", this.stock);
            cm.Parameters.AddWithValue("@picture", this.picture);
            cm.Parameters.AddWithValue("@bookTypeID", this.bookTypeID);
            cm.ExecuteNonQuery();
            con.Close();

        }
        public void update()
        {
            con.Open();
            string sql = "UPDATE tbbook SET bookName=@bookName,author=@author,publisher=@publisher,cost=@cost,price=@price,stock=@stock,picture=@picture,bookTypeID=@bookTypeID WHERE bookID=@bookID";

            SqlCommand cm = new SqlCommand(sql,con);
            cm.Parameters.AddWithValue("@bookID", this.bookID);
            cm.Parameters.AddWithValue("@bookName", this.bookName);
            cm.Parameters.AddWithValue("@author", this.author);
            cm.Parameters.AddWithValue("@publisher", this.publisher);
            cm.Parameters.AddWithValue("@cost", this.cost);
            cm.Parameters.AddWithValue("@price", this.price);
            cm.Parameters.AddWithValue("@stock", this.stock);
            cm.Parameters.AddWithValue("@bookTypeID", this.bookTypeID);
            cm.Parameters.AddWithValue("@picture", this.picture);
            cm.ExecuteNonQuery();
            con.Close();

        }
        public void delete()
        {
            con.Open();
            string sql = "DELETE FROM tbBook WHERE bookID=@bookID";

            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@bookID", this.bookID);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public DataTable read()
        {
            
            con.Open();
            string sql = "SELECT * FROM tbBook LEFT JOIN tbbookType ON tbbook.bookTypeID=tbbookType.bookTypeID";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public DataTable searchByID()
        {
            DataTable dt = new DataTable();
            return dt;

        }
    }
}


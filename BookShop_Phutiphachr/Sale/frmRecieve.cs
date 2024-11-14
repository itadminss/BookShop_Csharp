using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BookShop_Phutiphachr.Report.Sale;

namespace BookShop_Phutiphachr.Sale
{
    
    public partial class frmRecieve : Form
    {
        string saleID;
        SqlConnection con = new SqlConnection();
        public frmRecieve(string saleID)
        {
            InitializeComponent();
            this.saleID = saleID;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "server=localhost;database=myBookShop;User ID=sa;password=Abc12345";
            con.Open();
            //select ข้อมูลตามเงื่อนไขที่กำหนดไว้ใน dtRecieve
            //saleID,saleDate,saleTotal จากตาราง tbSale
            //name จากตาราง tbUser
            //bookName จากตาราง tbBook
            string sql = "SELECT tbSale.saleID,tbSale.saleTotal,tbSale.saleDate,name,tbSaleDetail.bookID " +
                "price,amount,total,bookName FROM tbSALE " +
                "LEFT JOIN tbsaleDetail ON tbSale.saleID=tbSaleDetail.saleID " +
                "LEFT JOIN tbUser ON tbSale.userID=tbUser.userID " +
                "LEFT JOIN tbBook ON tbSaleDetail.bookID=tbBook.bookID " +
                " WHERE tbSale.saleID='1'";
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            da.SelectCommand.Parameters.AddWithValue("@saleID", this.saleID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //สร้าง ออฟเจค ของรายงาน
            rptRecieve rpt = new rptRecieve();
            //rpt.SetDataSource(dt);
            //เปิดรายงาน
            crystalReportViewer1.ReportSource = rpt;
            con.Close();

                
        }
    }
}

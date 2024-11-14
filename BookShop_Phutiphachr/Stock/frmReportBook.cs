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
using BookShop_Phutiphachr.Report.Stock;

namespace BookShop_Phutiphachr.Stock
{
    public partial class frmReportBook : Form
    {
        SqlConnection con = new SqlConnection();
        public frmReportBook()
        {
            InitializeComponent();
        }

        private void crvBook_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Server=localhost;Database=myBookShop;User ID=sa;Password=Abc12345";
            con.Open();
            string sql = "SELECT bookID,bookName,author,publisher,bookTypeName FROM tbBook LEFT JOIN tbBookType ON tbBook.bookTypeID=tbBookType.bookTypeID";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //สร้าง object ของ report
            rptBook rpt = new rptBook();
            rpt.SetDataSource(dt);
            crvBook.ReportSource = rpt;
        }
    }
}

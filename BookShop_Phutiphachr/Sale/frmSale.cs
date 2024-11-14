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

namespace BookShop_Phutiphachr.Sale
{
    public partial class frmSale : Form
    {
        int i = 0;//เก็บ index ของdgvsale
        int saleTotal = 0;//ยอดรวมการขาย
        SqlConnection con = new SqlConnection();
        string userID;
        string saleID;
        public frmSale(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            
        }

       

        private void frmSale_Load(object sender, EventArgs e)
        {
            labSaleDate.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
           
            con.ConnectionString = "Server=localhost;Database=MyBookShop;User ID=sa;Password=Abc12345";
            con.Open();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labSaleDate.Text = DateTime.Now.ToString("dd/MM/YYYY hh:mm:ss");
        }

        private void txtBookID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                string sql = "SELECT * FROM tbBook WHERE bookID=@bookID";
                SqlDataAdapter da = new SqlDataAdapter(sql,con);
                da.SelectCommand.Parameters.AddWithValue("@bookID", txtBookID.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    labBookName.Text = dt.Rows[0]["bookName"].ToString();
                    labPrice.Text = dt.Rows[0]["price"].ToString();
                    labCost.Text= dt.Rows[0]["cost"].ToString();
                    txtAmout.Focus();
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูลหนังสือ");
                    
                }
                 
                    con.Close();
                 


            }
        }

        private void txtAmout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAmout.Text == "")
                {
                    MessageBox.Show("ป้อนจำนวนที่ขายก่อน");
                    return;
                }
                bool isNumber = int.TryParse(txtAmout.Text, out int amount);

                if (isNumber)
                {
                    labTotal.Text = (int.Parse(labPrice.Text) * amount).ToString();
                    btnAdd.Focus();
                }
                else
                {
                    MessageBox.Show("ป้อนจำนวนไม่ถูกต้อง");
                    return;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvSale.Rows.Add();
            dgvSale.Rows[i].Cells["bookID"].Value = txtBookID.Text;
            dgvSale.Rows[i].Cells["bookName"].Value = labBookName.Text;
            dgvSale.Rows[i].Cells["cost"].Value = labCost.Text;
            dgvSale.Rows[i].Cells["price"].Value = labPrice.Text;
            dgvSale.Rows[i].Cells["amount"].Value = txtAmout.Text;
            dgvSale.Rows[i].Cells["total"].Value = labTotal.Text;
            i = i + 1;
            saleTotal = saleTotal + int.Parse(labTotal.Text);
            labSaleTotal.Text = saleTotal.ToString();
            this.clear();
           
        }
        private void clear()
        {
            txtBookID.Clear();
            labBookName.Text = "";
            txtAmout.Clear();
            labCost.Text = "";
            labPrice.Text = "";
            labTotal.Text = "";
            txtBookID.Focus();
      
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "INSERT INTO tbSale(saleDate,userID,saleTotal) VALUES(@saleDate,@userID,@saleTotal)";
            SqlCommand cm = new SqlCommand(sql,con);
            cm.Parameters.AddWithValue("@saleDate",DateTime.Now);
            cm.Parameters.AddWithValue("@userID",this.userID);
            cm.Parameters.AddWithValue("@saleTotal",labSaleTotal.Text);
            cm.ExecuteNonQuery();


            sql = "SELECT MAX(saleID) AS saleID FROM tbSale WHERE userID=@userID";
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            da.SelectCommand.Parameters.AddWithValue("@userID", this.userID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string saleID = dt.Rows[0]["saleID"].ToString();
            this.saleID = saleID;
            for(int i=0; i<dgvSale.Rows.Count-1; i++)
            {
                //วนรอบข้อมูลอ่านข้อมูลแต่ละแถวใน dgvsale ลงในตาราง tbsaledetail
                sql = "INSERT INTO tbSaleDetail (saleID,bookID,amount,cost,price,total) VALUES(@saleID,@bookID,@amount,@cost,@price,@total)";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@saleID",this.saleID);
                cm.Parameters.AddWithValue("@bookID", dgvSale.Rows[i].Cells["bookID"].Value.ToString());
                cm.Parameters.AddWithValue("@amount", dgvSale.Rows[i].Cells["amount"].Value.ToString());
                cm.Parameters.AddWithValue("@cost", dgvSale.Rows[i].Cells["cost"].Value.ToString());
                cm.Parameters.AddWithValue("@price", dgvSale.Rows[i].Cells["price"].Value.ToString());
                cm.Parameters.AddWithValue("@total", dgvSale.Rows[i].Cells["total"].Value.ToString());
                cm.ExecuteNonQuery();

                //ตัดสต๊อก จำนวนที่ขายที่ตาราง tbbook

                sql = "UPDATE tbbook SET stock=stock-@amount WHERE bookID=@bookID";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@amount", dgvSale.Rows[i].Cells["amount"].Value.ToString());
                cm.Parameters.AddWithValue("@bookID", dgvSale.Rows[i].Cells["bookID"].Value.ToString());
                cm.ExecuteNonQuery();
            }
            MessageBox.Show("บันทึกเรียบร้อย");
        
            con.Close();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clearDgvSale();
        }
        private void clearDgvSale()
        {
            labSaleTotal.Text = "";
            dgvSale.DataSource = null;
            dgvSale.Rows.Clear();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmRecieve frm = new frmRecieve(saleID);
            frm.Show();
        }
    }
}

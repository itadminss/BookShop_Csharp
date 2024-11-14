using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop_Phutiphachr.Sale
{
    public partial class frmSaleMenu : Form
    {
        string name, userID;
        public frmSaleMenu(string name,string userID)
        {
            InitializeComponent();
            this.name = name;
            this.userID = userID;
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void tsbSale_Click(object sender, EventArgs e)
        {
            frmSale frm = new frmSale(this.userID);
            frm.MdiParent = this;
            frm.Show();

        }
    }
}

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
    public partial class frmStockMenu : Form
    {
        public frmStockMenu()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmBook frm = new frmBook();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbType_Click(object sender, EventArgs e)
        {
            frmBookType frm = new frmBookType();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);

        }

        private void รายงานขอมลหนงสอToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportBook frm = new frmReportBook();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

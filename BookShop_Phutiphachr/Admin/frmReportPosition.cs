using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShop_Phutiphachr.Report.Admin;

namespace BookShop_Phutiphachr.Admin
{
    public partial class frmReportPosition : Form
    {
        public frmReportPosition()
        {
            InitializeComponent();
        }

        private void frmReportPosition_Load(object sender, EventArgs e)
        {
            rptPosition rpt = new rptPosition();
            crystalReportViewer1.ReportSource = rpt;

        }
    }
}

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
    public partial class frmReportUser : Form
    {
        public frmReportUser()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            rptUser rpt = new rptUser();
            crystalReportViewer1.ReportSource = rpt;

        }
    }
}

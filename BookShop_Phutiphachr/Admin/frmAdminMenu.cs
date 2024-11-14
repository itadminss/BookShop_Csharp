using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop_Phutiphachr.Admin
{
    public partial class frmAdminMenu : Form
    {
        
        string name;
        //รับค่า name ,มาจาก frmlogin
        public frmAdminMenu(string name)
        {
            InitializeComponent();
            //กดหนดค่าตัวแปรในฟอร์มและนอกฟอร์ม
            this.name = name;
             
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            //ปิดฟอร์มทั้งหมด
            Environment.Exit(0);
        }

        private void frmAdminMenu_Load(object sender, EventArgs e)
        {
            tsslUser.Text = "ชื่อผู้ใช้งาน :" + this.name + "ตำแหน่ง :ผู้ดูแลระบบ";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmPosition frm = new frmPosition();
            frm.MdiParent = this;
            frm.Show();
        }

        private void รายงานผใชงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportUser frm = new frmReportUser();
            frm.Show();
        }

        private void รายงานตำแหนงผใชงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportPosition frm = new frmReportPosition();
            frm.MdiParent = this;
            frm.Show();
        }
    }
    }


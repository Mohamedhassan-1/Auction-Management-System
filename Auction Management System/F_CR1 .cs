using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auction_Management_System
{
    public partial class F_CR1 : Form
    {
        CrystalReport_Admin CR1;
 
        public F_CR1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void F_CR1_Load(object sender, EventArgs e)
        {
            CR1 = new CrystalReport_Admin();
            crystalReportViewer1.ReportSource = CR1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

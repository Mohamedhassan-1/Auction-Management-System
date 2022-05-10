using CrystalDecisions.Shared;
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
    public partial class F_CR2 : Form
    {
        CrystalReport_Buyer_ CR2;
        public F_CR2()
        {
            InitializeComponent();
        }
        private void F_CR2_Load(object sender, EventArgs e)
        {
            CR2 = new CrystalReport_Buyer_();
            foreach (ParameterDiscreteValue  v in CR2.ParameterFields[0].DefaultValues )
            {
                comboBox1.Items.Add(v.Value);
            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR2;
            CR2.SetParameterValue(0,comboBox1.SelectedItem);
            CR2.SetParameterValue(1,textBox2.Text);

            crystalReportViewer1.ReportSource = CR2;


        }


        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

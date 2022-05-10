using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Auction_Management_System
{
    public partial class F_Home : Form
    {
        string ordb = "Data Source=orcl; User Id=hr;Password=hr;";
        OracleConnection conn;
        int customerId;
        public F_Home(int customerid)
        {            
            customerId = customerid;       
            InitializeComponent();
        }

        private void F_Home_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select messagecontent , messageid from message,customer where messageid=customerid";
            // Admins id must be from this list {1}
            try
            {
                OracleDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    if (Convert.ToInt16(dataReader[1]) == customerId)
                    {
                        messagecontent.Text += dataReader[0].ToString();
                        messagecontent.Text += Environment.NewLine;
                    }

                }
                dataReader.Close();
            }
            catch (Exception ex)
            {

            }

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_seller s1 = new F_seller ();
            this.Hide();
            s1.Show();
        }

        private void product_Click(object sender, EventArgs e)
        {
            F_buyer b1 = new F_buyer ();
            this.Hide();
            b1.Show();
        }

        private void help_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.auctionhelper.com/");
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

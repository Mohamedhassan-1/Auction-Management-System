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
    public partial class Home : Form
    {
        string ordb = "Data Source=orcl; User Id=hr;Password=hr;";
        OracleConnection conn;
        int customerId;
        public Home(int customerid)
        {
            customerId = customerid;
            InitializeComponent();
        }

        private void messagebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();
        }

        private void HomeLoad(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select messagecontent , messageid from message,customer where messageid=customerid";
                    
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
            catch(Exception ex)
            {
               
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

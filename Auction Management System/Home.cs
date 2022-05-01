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

        public Home()
        {
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
            cmd.CommandText = "select messagecontent  from message,customer where messageid=customerid";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                messagecontent.Text += dataReader[0].ToString();
                messagecontent.Text += Environment.NewLine;

            }
            dataReader.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

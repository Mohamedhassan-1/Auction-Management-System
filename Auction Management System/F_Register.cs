using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
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
    public partial class F_Register : Form
    {
        OracleConnection con;
        string ordb = "Data Source=orcl; User Id=hr;Password=hr;";
        public F_Register()
        {
            InitializeComponent();
        }

        private void F_Register_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int maxid, newid;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "GetCusID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);

            cmd.ExecuteNonQuery();

            try
            {
                maxid = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                newid = maxid + 1;
            }
            catch
            {
                newid = 1;
            }
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "setinfoDetails";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("CID", newid);
            c.Parameters.Add("CName", textBox9.Text);
            c.Parameters.Add("Cemail", textBox10.Text);
            c.Parameters.Add("CPass", textBox11.Text);
            c.Parameters.Add("Cgender", textBox12.Text);
           
                MessageBox.Show("Registered sucessfully");
                this.Hide();
               F_Home home = new F_Home(newid);
                home.Show();
            

        }


        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f12 = new Form1();
            f12.Show();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}

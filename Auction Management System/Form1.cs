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
    
    public partial class Form1 : Form
    {
        readonly string  ordb = "Data Source=orcl; User Id=hr;Password=hr;";
        OracleConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select customerid  from customer where customeremail=:email and customerpassword=:password";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("email", EmailText.Text);
            cmd.Parameters.Add("password", PasswordText.Text);
            OracleDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                this.Hide();
                F_Home home = new F_Home(Convert.ToInt16(dataReader[0]));
                home.Show();
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            F_Register reg = new F_Register();
            this.Hide();
            reg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(PasswordText.Text) == 0000 && EmailText.Text== "Admin@Auction.com")
            {
                this.Hide();
                // Admins id must be from this list {0000}
                F_Admin fa = new F_Admin();
                fa.Show();
            }

        }
    }
}

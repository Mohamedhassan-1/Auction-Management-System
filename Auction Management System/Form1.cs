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
        string ordb = "Data Source=orcl; User Id=hr;Password=hr;";
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
                Home home = new Home(Convert.ToInt16(dataReader[0]));
                home.Show();
               
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            this.Hide();
            reg.Show();
        }
    }
}

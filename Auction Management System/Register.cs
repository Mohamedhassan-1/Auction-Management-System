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
    public partial class Register : Form
    {
        OracleConnection con;
        string ordb = "data source = orcl; user id =scott; password=tiger;";
        public Register()
        {
            InitializeComponent();
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
            c.Parameters.Add("CName", txt_Name.Texts);
            c.Parameters.Add("Cemail", txt_Email.Texts);
            c.Parameters.Add("CPass", txt_Pass.Texts);
            c.Parameters.Add("Cgender", txt_Gender.Texts);
            c.ExecuteNonQuery();
            MessageBox.Show("rgistered sucessfully");


        }

        private void Register_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();

        }
    }
}

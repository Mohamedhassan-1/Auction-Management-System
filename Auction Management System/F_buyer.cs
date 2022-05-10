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
    public partial class F_buyer : Form
    {
        string ordb = "Data Source=orcl; User Id=hr;Password=hr;";
        OracleConnection conn;
        F_CR2 f2;

        public F_buyer()
        {
            InitializeComponent();
        }


        private void F_buyer_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select categoryname from pcategory";
            cmd.CommandType = CommandType.Text;


            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);
            }
            dr.Close();
            // list of customers's id
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "select customerid  from customer";
            cmd1.CommandType = CommandType.Text;
            OracleDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                 comboBox3.Items.Add(dr1[0]);
            }
            dr1.Close();

        }
        //search products by category
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand c8 = new OracleCommand();
            c8.Connection = conn;
            c8.CommandText = "getproducts";
            c8.CommandType = CommandType.StoredProcedure;
            c8.Parameters.Add("categoryname", comboBox2.SelectedItem.ToString());
            c8.Parameters.Add("pro", OracleDbType.RefCursor,ParameterDirection.Output);
            OracleDataReader dr7 = c8.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr7);
            dataGridView1.DataSource = dt ; 
            conn.Close();
        }
        //search for sellers by seller id
        private void button3_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select customername, customeremail from customer where customerid=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", comboBox3.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
                textBox3.Text = dr[1].ToString();
            }
            dr.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void categoriesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f2 = new F_CR2();
            f2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fy = new Form1();
            fy.Show();
        }
    }
}

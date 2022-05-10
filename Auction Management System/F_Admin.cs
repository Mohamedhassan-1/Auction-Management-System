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
    public partial class F_Admin : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder ;
        DataSet ds;
        string ordb = "Data Source=orcl; User Id=hr;Password=hr;";
        OracleConnection conn;
        F_CR1 f1;
        public F_Admin()
        {
            InitializeComponent();
        }

         String Conn  = "Data Source=orcl; User Id=hr;Password=hr;";
        private void F_Admin_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();

            label2.Text = "    Auction System    ";
            String cmd = "select * from product";
            adapter = new OracleDataAdapter(cmd,Conn);
            ds = new DataSet();
            adapter.Fill(ds);
           // BindingSource bs = new BindingSource();
           // bs.DataSource = ds.Tables[0];
            dataGridView1.DataSource = ds.Tables[0];

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

        private void button1_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Changes Saved !");
        }

 

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = " Manage Products Information ";
            String cmd = "select * from product";

            adapter = new OracleDataAdapter(cmd, Conn);
            ds = new DataSet();
            adapter.Fill(ds);
            // BindingSource bs = new BindingSource();
            // bs.DataSource = ds.Tables[0];
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = " Manage Accounts Information ";
            String cmd = "select * from customer";
            adapter = new OracleDataAdapter(cmd, Conn);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
               label2.Text = " Manage Requests Information ";
               String cmd = "select * from request";
                adapter = new OracleDataAdapter(cmd, Conn);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select customername, CustomerGender,customeremail from customer where customerid=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", comboBox3.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
            }
            dr.Close();
        }
 
 
        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = " Manage Products Information ";
            String cmd = "select * from product";

            adapter = new OracleDataAdapter(cmd, Conn);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

 
        private void rEquestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = " Manage Requests Information ";
            String cmd = "select * from request";
            adapter = new OracleDataAdapter(cmd, Conn);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = " Manage Accounts Information ";
            String cmd = "select * from customer";
            adapter = new OracleDataAdapter(cmd, Conn);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void categoriesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f1 = new F_CR1();
            f1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f2 = new Form1();
            f2.Show();
        }
    }
}

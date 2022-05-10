using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Types;



namespace Auction_Management_System
{
    public partial class F_seller : Form
    {
        string ordb = "Data Source=orcl; User Id=hr;Password=hr;";
        OracleConnection conn;
        public F_seller()
        {
            InitializeComponent();
        }

        private void F_seller_Load(object sender, EventArgs e)
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

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //button to add product 
        private void button1_Click(object sender, EventArgs e)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            // -> insert
            cmd.CommandText = "insert into product values (:id, :categoryname, :name, :minprice, :maxprice, :description)";

            // cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", textBox9.Text);
            cmd.Parameters.Add("categoryname", comboBox2.Text);
            cmd.Parameters.Add("name", textBox10.Text);
            cmd.Parameters.Add("minprice", textBox11.Text);
            cmd.Parameters.Add("maxprice", textBox12.Text);
            cmd.Parameters.Add("description", textBox6.Text);
            int tt = cmd.ExecuteNonQuery();
            if (tt != -1)
            {
              //  comboBox2.Items.Add(comboBox2.Text);
                MessageBox.Show("New Product is Added");
            }
            else
            {
                MessageBox.Show("Product is not Added");
            }
        }


        // button to request start for seller
        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand C = new OracleCommand();
            C.Connection = conn;
            C.CommandText = "insert into request values (:id,:requestname,' ')";
            C.CommandType = CommandType.Text;
            C.Parameters.Add("id", textBox14.Text);
            C.Parameters.Add("requestname", textBox13.Text);
            int r = C.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Request Sent");
            }
            else
            {
                MessageBox.Show("Try Later");
            }

            conn.Close();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

 
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand c3 = new OracleCommand();
            c3.Connection = conn;
            c3.CommandText = "getNewproductid";
            c3.CommandType = CommandType.StoredProcedure;
            c3.Parameters.Add("id",OracleDbType.Int32,ParameterDirection.Output);
            c3.ExecuteNonQuery();
            int newid = Convert.ToInt32(c3.Parameters["id"].Value.ToString()) + 1;
            
            textBox3.Text = newid.ToString();
            MessageBox.Show("New product ID  :" + newid + "\n \n" + "Don't forget it!");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fd = new Form1();
            fd.Show();
        }
    }

}

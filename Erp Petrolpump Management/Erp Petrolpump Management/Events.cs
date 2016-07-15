using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Erp_Petrolpump_Management
{
    public partial class Events : Form
    {
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database1.accdb");
        public int id;
        public String evname;
        public double expence;
        public Events()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                id = Int32.Parse(textBox1.Text);
                evname = textBox2.Text;
                expence = double.Parse(textBox3.Text);
                OleDbCommand cmd = new OleDbCommand("Insert into Events(ID, EventName, Expence) Values("+id+", '"+evname+"', "+expence+")",con);
                con.Open();
                cmd.ExecuteNonQuery();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                con.Close();
            
            }
            catch(Exception ex){
            
            
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wellcome_Page wl = new Wellcome_Page();
            this.Hide();
            wl.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbCommand read = new OleDbCommand("Select * from Events", con);

            OleDbDataAdapter a = new OleDbDataAdapter();
            a.SelectCommand = read;
            DataTable dt = new DataTable();
            a.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            a.Update(dt);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                String tx = textBox5.Text;
                int II = Int32.Parse(textBox6.Text);
                OleDbCommand upi = new OleDbCommand("UPDATE Events SET EventName ='" + tx + "' WHERE ID=" + II + "", con);
                con.Open();
                upi.ExecuteNonQuery();
                textBox5.Clear();
                textBox6.Clear();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid nic number");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                expence = double.Parse(textBox7.Text);
                int II = Int32.Parse(textBox8.Text);
                OleDbCommand upi = new OleDbCommand("UPDATE Events SET Expence =" + expence + " WHERE ID=" + II + "", con);
                con.Open();
                upi.ExecuteNonQuery();
                textBox7.Clear();
                textBox8.Clear();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid nic number");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int dl = Int32.Parse(textBox11.Text);
                OleDbCommand dlt = new OleDbCommand("DELETE FROM Events Where ID=" + dl + "", con);
                con.Open();
                dlt.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("can't delete ");
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            try
            {
                int rec = Int32.Parse(textBox4.Text);
                OleDbCommand read = new OleDbCommand("Select * from Events WHERE ID=" + rec + "", con);

                OleDbDataAdapter a = new OleDbDataAdapter();
                a.SelectCommand = read;
                DataTable dt = new DataTable();
                a.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dataGridView2.DataSource = bs;
                a.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Must Fill Id");
                textBox4.Clear();


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox11.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DeleteEvents dl = new DeleteEvents();
            this.Hide();
            dl.Show();
        }

        private void Events_Load(object sender, EventArgs e)
        {

        }
    }
}

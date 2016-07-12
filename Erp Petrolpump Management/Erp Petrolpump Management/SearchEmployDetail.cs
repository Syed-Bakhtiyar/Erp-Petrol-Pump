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
    public partial class SearchEmployDetail : Form
    {
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Syed Inkisar Ahmed\\Documents\\Database1.accdb");
        public int rec;
        public SearchEmployDetail()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Wellcome_Page wl = new Wellcome_Page();
            this.Hide();
            wl.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
             rec= Int32.Parse(textBox1.Text);
             try
             {
                 OleDbCommand read = new OleDbCommand("Select * from EmployRecord WHERE Nic=" + rec + "", con);

                 OleDbDataAdapter a = new OleDbDataAdapter();
                 a.SelectCommand = read;
                 DataTable dt = new DataTable();
                 a.Fill(dt);
                 BindingSource bs = new BindingSource();
                 bs.DataSource = dt;
                 dataGridView1.DataSource = bs;
                 a.Update(dt);
             }
            catch(Exception ex){
                MessageBox.Show("correct nic");
                textBox1.Clear();

            
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rec = Int32.Parse(textBox2.Text);
            OleDbCommand read = new OleDbCommand("Select * from SallingDetail WHERE Dates=" + rec + "", con);

            OleDbDataAdapter a = new OleDbDataAdapter();
            a.SelectCommand = read;
            DataTable dt = new DataTable();
            a.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView2.DataSource = bs;
            textBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number");
                e.KeyChar = (char)0;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number like this 2232016 or 21213");
                e.KeyChar = (char)0;
            }
        }

        private void SearchEmployDetail_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            rec = Int32.Parse(textBox3.Text);
            try
            {
                OleDbCommand read = new OleDbCommand("Select * from Deisel WHERE Dates=" + rec + "", con);

                OleDbDataAdapter a = new OleDbDataAdapter();
                a.SelectCommand = read;
                DataTable dt = new DataTable();
                a.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dataGridView3.DataSource = bs;
                a.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("correct nic");
                textBox1.Clear();


            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number like this 2232016 or 21213");
                e.KeyChar = (char)0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            rec = Int32.Parse(textBox4.Text);
            try
            {
                OleDbCommand read = new OleDbCommand("Select * from CNG WHERE Dates=" + rec + "", con);

                OleDbDataAdapter a = new OleDbDataAdapter();
                a.SelectCommand = read;
                DataTable dt = new DataTable();
                a.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dataGridView4.DataSource = bs;
                a.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("correct nic");
                textBox1.Clear();


            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number like this 2232016 or 21213");
                e.KeyChar = (char)0;
            }
        }
    }
}

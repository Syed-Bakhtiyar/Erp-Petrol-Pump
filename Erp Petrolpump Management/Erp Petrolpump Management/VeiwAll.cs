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
    public partial class VeiwAll : Form
    {
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database1.accdb");
        public VeiwAll()
        {
            InitializeComponent();
        }
        public string tbname;

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand read = new OleDbCommand("Select * from EmployRecord", con);

                OleDbDataAdapter a = new OleDbDataAdapter();
                a.SelectCommand = read;
                DataTable dt = new DataTable();
                a.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                a.Update(dt);
            }
            catch (Exception ex) {
                MessageBox.Show("Can't Read");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Wellcome_Page wl = new Wellcome_Page();
            this.Hide();
            wl.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tbname = textBox1.Text;
            if (tbname.Equals("SallingDetail", StringComparison.Ordinal) ||
                tbname.Equals("Deisel", StringComparison.Ordinal) ||
                tbname.Equals("CNG", StringComparison.Ordinal)||
                tbname.Equals("Oil", StringComparison.Ordinal))
            {
                groupBox1.Enabled = true;
                groupBox1.Text = tbname;
                try
                {
                    OleDbCommand read = new OleDbCommand("Select * from "+tbname+"", con);

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
                    MessageBox.Show("Can't Read");
                }
            }
            else
            {
                MessageBox.Show("Write correct Table Name with case sensitive");
                groupBox1.Enabled = false;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
        
        }
    }
}

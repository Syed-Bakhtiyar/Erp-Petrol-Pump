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
            
            
             rec= Int16.Parse(textBox1.Text);
             OleDbCommand read = new OleDbCommand("Select * from EmployRecord WHERE Nic="+rec+"", con);

             OleDbDataAdapter a = new OleDbDataAdapter();
             a.SelectCommand = read;
             DataTable dt = new DataTable();
             a.Fill(dt);
             BindingSource bs = new BindingSource();
             bs.DataSource = dt;
             dataGridView1.DataSource = bs;
             a.Update(dt);
                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rec = Int16.Parse(textBox2.Text);
            OleDbCommand read = new OleDbCommand("Select * from SallingDetail WHERE Dates=" + rec + "", con);

            OleDbDataAdapter a = new OleDbDataAdapter();
            a.SelectCommand = read;
            DataTable dt = new DataTable();
            a.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView2.DataSource = bs;
        }
    }
}

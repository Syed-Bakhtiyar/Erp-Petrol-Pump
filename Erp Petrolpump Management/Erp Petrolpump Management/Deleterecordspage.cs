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
    public partial class Deleterecordspage : Form
    {
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Syed Inkisar Ahmed\\Documents\\Database1.accdb");
        public Deleterecordspage()
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
            try
            {
                int dl = Int32.Parse(textBox1.Text);
                OleDbCommand dlt = new OleDbCommand("DELETE FROM EmployRecord Where Nic=" + dl + "", con);
                con.Open();
                dlt.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex) {
                MessageBox.Show("can't delete ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteForm d = new DeleteForm();
            this.Hide();
            d.Show();
        }

        private void Deleterecordspage_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number like this 2232016 or 21213");
                e.KeyChar = (char)0;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number");
                e.KeyChar = (char)0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int dl = Int32.Parse(textBox1.Text);
            try
            {
                OleDbCommand dlt = new OleDbCommand("DELETE FROM SallingDetail Where Dates=" + dl + "", con);
                con.Open();
                dlt.ExecuteNonQuery();
                con.Close();
            }catch(Exception ex){
                MessageBox.Show("No Connection");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DeleteSalling ds = new DeleteSalling();
            this.Hide();
            ds.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

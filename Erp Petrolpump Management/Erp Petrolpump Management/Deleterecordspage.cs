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
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database1.accdb");
        public Deleterecordspage()
        {
            InitializeComponent();
        }
        public string tbname;

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
            DeleteSalling ds = new DeleteSalling("");
            this.Hide();
            ds.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number");
                e.KeyChar = (char)0;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number");
                e.KeyChar = (char)0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteDeiselRec dl = new DeleteDeiselRec();
            this.Hide();
            dl.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            DeleteCngRecord dl = new DeleteCngRecord();
            this.Hide();
            dl.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            tbname = textBox4.Text;
            if (tbname.Equals("SallingDetail", StringComparison.Ordinal) ||
                tbname.Equals("Deisel", StringComparison.Ordinal) ||
                tbname.Equals("CNG", StringComparison.Ordinal) ||
                tbname.Equals("Oil", StringComparison.Ordinal))
            {
                groupBox2.Enabled = true;
                if (tbname.Equals("SallingDetail", StringComparison.Ordinal))
                {
                    groupBox2.Text = "Petrol";
                }
                else
                {
                    groupBox2.Text = tbname;
                }

            }
            else
            {

                MessageBox.Show("Write correct Table Name with case sensitive");
                groupBox2.Enabled = false;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

            try
           {
                int dl = Int32.Parse(textBox2.Text);
                OleDbCommand dlt = new OleDbCommand("DELETE FROM "+tbname+" Where Dates=" + dl + "", con);
                con.Open();
                dlt.ExecuteNonQuery();
                MessageBox.Show("Executed");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Connection");
           }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand dlt = new OleDbCommand("DELETE FROM " + tbname + "", con);
                con.Open();
                dlt.ExecuteNonQuery();
                con.Close();
                //Deleterecordspage dl = new Deleterecordspage();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("can't deleted");
                this.Hide();
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int dl = Int32.Parse(textBox1.Text);
                OleDbCommand dlt = new OleDbCommand("DELETE FROM EmployRecord Where Nic=" + dl + "", con);
                con.Open();
                dlt.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("can't delete ");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DeleteForm d = new DeleteForm();
            this.Hide();
            d.Show();
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number");
                e.KeyChar = (char)0;
            }
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number");
                e.KeyChar = (char)0;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Wellcome_Page wl = new Wellcome_Page();
            this.Hide();
            wl.Show();
        }
    }
}

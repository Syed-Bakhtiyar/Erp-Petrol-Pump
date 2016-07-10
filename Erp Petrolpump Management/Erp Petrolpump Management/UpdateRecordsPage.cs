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
    public partial class UpdateRecordsPage : Form
    {
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Syed Inkisar Ahmed\\Documents\\Database1.accdb");
        public UpdateRecordsPage()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Wellcome_Page wl = new Wellcome_Page();
            this.Hide();
            wl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateRecordsPage_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String tx = textBox12.Text;
                int II = Int32.Parse(textBox16.Text);
                OleDbCommand upi = new OleDbCommand("UPDATE EmployRecord SET Name ='" + tx + "' WHERE Nic=" + II + "", con);
                con.Open();
                upi.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Invalid nic number");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
            int tx = Int16.Parse( textBox11.Text);
            int II = Int32.Parse(textBox15.Text);
            OleDbCommand upi = new OleDbCommand("UPDATE EmployRecord SET Age =" + tx + " WHERE Nic=" + II + "", con);
            con.Open();
            upi.ExecuteNonQuery();
            con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Invalid nic number");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
            double tx = Double.Parse( textBox10.Text);
            int II = Int32.Parse(textBox14.Text);
            OleDbCommand upi = new OleDbCommand("UPDATE EmployRecord SET Salary ='" + tx + "' WHERE Nic=" + II + "", con);
            con.Open();
            upi.ExecuteNonQuery();
            con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Invalid nic number");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
            String tx = textBox8.Text;
            int II = Int32.Parse(textBox13.Text);
            OleDbCommand upi = new OleDbCommand("UPDATE EmployRecord SET Email ='" + tx + "' WHERE Nic=" + II + "", con);
            con.Open();
            upi.ExecuteNonQuery();
            con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Invalid nic number");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
            String tx = textBox7.Text;
            int II = Int32.Parse(textBox9.Text);
            OleDbCommand upi = new OleDbCommand("UPDATE EmployRecord SET Phone ='" + tx + "' WHERE Nic=" + II + "", con);
            con.Open();
            upi.ExecuteNonQuery();
            con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid nic number");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try{
            double tx = double.Parse(textBox25.Text);
            int II = Int32.Parse(textBox28.Text);
            OleDbCommand upi = new OleDbCommand("UPDATE SallingDetail SET Salling =" + tx + " WHERE Dates=" + II + "", con);
            con.Open();
            upi.ExecuteNonQuery();
            con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Invalid nic number");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try{
            double tx = double.Parse(textBox24.Text);
            int II = Int32.Parse(textBox27.Text);
            OleDbCommand upi = new OleDbCommand("UPDATE SallingDetail SET OtherExpence =" + tx + " WHERE Dates=" + II + "", con);
            con.Open();
            upi.ExecuteNonQuery();
            con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Invalid nic number");
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
        try{
            double tx = double.Parse(textBox23.Text);
            int II = Int32.Parse(textBox26.Text);
            OleDbCommand upi = new OleDbCommand("UPDATE SallingDetail SET Purchasing =" + tx + " WHERE Dates=" + II + "", con);
            con.Open();
            upi.ExecuteNonQuery();
            con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Invalid nic number");
            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number");
                e.KeyChar = (char)0;
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number");
                e.KeyChar = (char)0;
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number");
                e.KeyChar = (char)0;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number");
                e.KeyChar = (char)0;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number");
                e.KeyChar = (char)0;
            }
        }

        private void textBox28_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number like this 2232016 or 21213");
                e.KeyChar = (char)0;
            }
        }

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number like this 2232016 or 21213");
                e.KeyChar = (char)0;
            }
        }

        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number like this 2232016 or 21213");
                e.KeyChar = (char)0;
            }
        }
    }
}

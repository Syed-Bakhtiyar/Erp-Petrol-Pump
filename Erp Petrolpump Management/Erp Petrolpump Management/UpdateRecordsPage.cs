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
            String tx = textBox12.Text;
            int II =Int16.Parse(textBox16.Text);
            OleDbCommand upi = new OleDbCommand("UPDATE EmployRecord SET Name ='" + tx + "' WHERE Nic=" + II + "", con);
            con.Open();
            upi.ExecuteNonQuery();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tx = Int16.Parse( textBox11.Text);
            int II = Int16.Parse(textBox15.Text);
            OleDbCommand upi = new OleDbCommand("UPDATE EmployRecord SET Age =" + tx + " WHERE Nic=" + II + "", con);
            con.Open();
            upi.ExecuteNonQuery();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double tx = Double.Parse( textBox10.Text);
            int II = Int16.Parse(textBox14.Text);
            OleDbCommand upi = new OleDbCommand("UPDATE EmployRecord SET Salary ='" + tx + "' WHERE Nic=" + II + "", con);
            con.Open();
            upi.ExecuteNonQuery();
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String tx = textBox8.Text;
            int II = Int16.Parse(textBox13.Text);
            OleDbCommand upi = new OleDbCommand("UPDATE EmployRecord SET Email ='" + tx + "' WHERE Nic=" + II + "", con);
            con.Open();
            upi.ExecuteNonQuery();
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String tx = textBox7.Text;
            int II = Int16.Parse(textBox9.Text);
            OleDbCommand upi = new OleDbCommand("UPDATE EmployRecord SET Phone ='" + tx + "' WHERE Nic=" + II + "", con);
            con.Open();
            upi.ExecuteNonQuery();
            con.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double tx = double.Parse(textBox25.Text);
            int II = Int16.Parse(textBox28.Text);
            OleDbCommand upi = new OleDbCommand("UPDATE SallingDetail SET Salling =" + tx + " WHERE Dates=" + II + "", con);
            con.Open();
            upi.ExecuteNonQuery();
            con.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double tx = double.Parse(textBox24.Text);
            int II = Int16.Parse(textBox27.Text);
            OleDbCommand upi = new OleDbCommand("UPDATE SallingDetail SET OtherExpence =" + tx + " WHERE Dates=" + II + "", con);
            con.Open();
            upi.ExecuteNonQuery();
            con.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double tx = double.Parse(textBox23.Text);
            int II = Int16.Parse(textBox26.Text);
            OleDbCommand upi = new OleDbCommand("UPDATE SallingDetail SET Purchasing =" + tx + " WHERE Dates=" + II + "", con);
            con.Open();
            upi.ExecuteNonQuery();
            con.Close();
        }
    }
}

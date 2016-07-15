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
    public partial class PrintPageForm : Form
    {
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database1.accdb");
        public PrintPageForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataReader dt = null;
            OleDbCommand cmd = new OleDbCommand("Select * from EmployRecord", con);
            dt = cmd.ExecuteReader();
            
            while(dt.Read()){
                richTextBox1.Text += "\nNic    ";
                richTextBox1.Text += dt["Nic"].ToString();
                richTextBox1.Text += "\nName    ";
                richTextBox1.Text += dt["Name"].ToString();
                richTextBox1.Text += "\nFatherName    ";
                richTextBox1.Text += dt["FatherName"].ToString();
                richTextBox1.Text += "\nAge    ";
                richTextBox1.Text += dt["Age"].ToString();
                richTextBox1.Text += "\nSalary    ";
                richTextBox1.Text += dt["Salary"].ToString();
                richTextBox1.Text += "\nEmail    ";
                richTextBox1.Text += dt["Email"].ToString();
                richTextBox1.Text += "\nPhone    ";
                richTextBox1.Text += dt["Phone"].ToString();
                
            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            con.Open();
            OleDbDataReader dt = null;
            OleDbCommand cmd = new OleDbCommand("Select * from SallingDetail", con);
            dt = cmd.ExecuteReader();

            while (dt.Read())
            {
                richTextBox2.Text += "\nDates    ";
                richTextBox2.Text += dt["Dates"].ToString();
                richTextBox2.Text += "\nPurchasing    ";
                richTextBox2.Text += dt["Purchasing"].ToString();
                richTextBox2.Text += "\nSalling    ";
                richTextBox2.Text += dt["Salling"].ToString();
                richTextBox2.Text += "\nOtherExpence    ";
                richTextBox2.Text += dt["OtherExpence"].ToString();
                richTextBox2.Text += "\nTotalBudget    ";
                richTextBox2.Text += dt["TotalBudget"].ToString();
                
            }
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Wellcome_Page wl = new Wellcome_Page();
            this.Hide();
            wl.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

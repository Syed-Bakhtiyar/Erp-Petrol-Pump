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
        public int id;
        public string tbname;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                id = Int32.Parse(textBox1.Text);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                textBox1.Clear();
            }
            con.Open();
            OleDbDataReader dt = null;
            OleDbCommand cmd = new OleDbCommand("Select * from EmployRecord Where Nic="+id+"", con);
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
            try
            {
                id =Int32.Parse( textBox3.Text);
            }
            catch (Exception ex) {
                MessageBox.Show("Please write correct input");
                textBox3.Clear();
            }
            
            richTextBox2.Clear();
            con.Open();
            OleDbDataReader dt = null;
            OleDbCommand cmd = new OleDbCommand("Select * from "+tbname+" where Dates="+id+"", con);
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

        private void button2_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK) {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Arial",40,FontStyle.Bold),Brushes.Black,150,125);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbname = textBox2.Text;
            if (tbname.Equals("SallingDetail", StringComparison.Ordinal) ||
                tbname.Equals("Deisel", StringComparison.Ordinal) ||
                tbname.Equals("CNG", StringComparison.Ordinal)||
                tbname.Equals("Oil",StringComparison.Ordinal))
            {
                button4.Enabled = true;
                button3.Enabled = true;
                textBox3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Write correct Table Name with case sensitive");

            }
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox2.Text, new Font("Arial", 40, FontStyle.Bold), Brushes.Black, 150, 125);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument2;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument2.Print();
            }
        }

        private void Ckear(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Clear();
        }
    }
}

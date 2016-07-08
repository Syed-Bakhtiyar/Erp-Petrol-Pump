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
    public partial class Insertion : Form
    {
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Syed Inkisar Ahmed\\Documents\\Database1.accdb");
        public Insertion()
        {
            InitializeComponent();
        }
        public string name, fathername, phone, email;
        public int age, nic;
        public double salary,purchase,sale,expence;

        private void button2_Click(object sender, EventArgs e)
        {
            Wellcome_Page wl = new Wellcome_Page();
            this.Hide();
            wl.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Insertion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                name = textBox1.Text;
                fathername = textBox7.Text;
                email= textBox5.Text;
                phone = textBox6.Text;
                salary = Double.Parse(textBox3.Text);
                age = Int16.Parse(textBox2.Text);
                nic = Int16.Parse(textBox4.Text);
                OleDbCommand cmd = new OleDbCommand("INSERT into EmployRecord(Nic, Name, Age,Salary, FatherName, Email, Phone) Values('" + nic + "', '" + name + "', '" + age + "', '" + salary + "', '" + fathername + "', '" + email + "', '" + phone + "') ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                       
        }
    }
}

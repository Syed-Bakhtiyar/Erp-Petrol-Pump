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
    
    public partial class BossVeiw : Form
    {
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Syed Inkisar Ahmed\\Documents\\Database1.accdb");
        public BossVeiw()
        {
            InitializeComponent();
        }

        private void BossVeiw_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sel=0;
            try {
                con.Open();
                OleDbDataReader dt=null;
                OleDbCommand cmd = new OleDbCommand("Select Salling from SallingDetail",con);
                dt = cmd.ExecuteReader();
                while(dt.Read()){
                    sel += double.Parse(dt["Salling"].ToString());
                }
                textBox1.Text = sel.ToString();
                con.Close();
            }
            
            catch(Exception ex){
                MessageBox.Show("not execute");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sel = 0;
            try
            {
                con.Open();
                OleDbDataReader dt = null;
                OleDbCommand cmd = new OleDbCommand("Select TotalBudget from SallingDetail", con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    sel += double.Parse(dt["TotalBudget"].ToString());
                }
                textBox2.Text = sel.ToString();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("not execute");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sel = 0;
            try
            {
                con.Open();
                OleDbDataReader dt = null;
                OleDbCommand cmd = new OleDbCommand("Select Salary from EmployRecord", con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    sel += double.Parse(dt["Salary"].ToString());
                }
                textBox3.Text = sel.ToString();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("not execute");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sel = 0;
            try
            {
                con.Open();
                OleDbDataReader dt = null;
                OleDbCommand cmd = new OleDbCommand("Select Purchasing from SallingDetail", con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    sel += double.Parse(dt["Purchasing"].ToString());
                }
                textBox5.Text = sel.ToString();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("not execute");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sel = 0;
            try
            {
                con.Open();
                OleDbDataReader dt = null;
                OleDbCommand cmd = new OleDbCommand("Select OtherExpence from SallingDetail", con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    sel += double.Parse(dt["OtherExpence"].ToString());
                }
                textBox4.Text = sel.ToString();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("not execute");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Wellcome_Page el = new Wellcome_Page();
            this.Hide();
            el.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}

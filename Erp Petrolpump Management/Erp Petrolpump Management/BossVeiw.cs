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
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database1.accdb");
        public BossVeiw()
        {
            InitializeComponent();
        }
        public string tbname;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int sel = 0,TEMP=0;
            try
            {
            
                con.Open();
                OleDbDataReader dt = null;
                OleDbCommand cmd = new OleDbCommand("Select * from EmployRecord", con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {

                    textBox3.Text = dt["Salary"].ToString();
                    sel = Int32.Parse(textBox3.Text);
                    TEMP += sel;
                    /// 
                    textBox3.Show();
                    textBox3.Text = TEMP.ToString();
                }


                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("not execute");
            }
            finally {

                con.Close();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double sale = 0;
            try
            {
                textBox15.Hide();
                con.Open();
                OleDbDataReader dt = null;
                OleDbCommand cmd = new OleDbCommand("Select * from Oil", con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    textBox15.Text= dt["Salling"].ToString();
                    sale += long.Parse(textBox15.Text);
                }
                textBox15.Show();
                textBox15.Text = sale.ToString();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("not execute");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double tb = 0;
            try
            {
                con.Open();
                OleDbDataReader dt = null;
                OleDbCommand cmd = new OleDbCommand("Select *from Oil", con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    tb += double.Parse(dt["TotalBud"].ToString());
                }
                textBox14.Text = tb.ToString();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("not execute");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double pr = 0;
            try
            {
                con.Open();
                OleDbDataReader dt = null;
                OleDbCommand cmd = new OleDbCommand("Select * from Oil", con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    pr += double.Parse(dt["Price"].ToString());
                }
                textBox11.Text = pr.ToString();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("not execute");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double sale = 0;
            try
            {
                con.Open();
                OleDbDataReader dt = null;
                OleDbCommand cmd = new OleDbCommand("Select * from Oil", con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    sale += double.Parse(dt["Stock"].ToString());
                }
                textBox2.Text = sale.ToString();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("not execute");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tbname = textBox1.Text;
            if (tbname.Equals("SallingDetail", StringComparison.Ordinal) ||
                tbname.Equals("Deisel", StringComparison.Ordinal) ||
                tbname.Equals("CNG", StringComparison.Ordinal)
                )
            {
                groupBox2.Enabled = true;
                if (tbname.Equals("SallingDetail", StringComparison.Ordinal))
                {
                    label1.Text = "Petrol";
                }
                else
                {
                    label1.Text = tbname;
                }

            }
            else
            {

                MessageBox.Show("Write correct Table Name with case sensitive");
                groupBox2.Enabled = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double sel = 0;
            try
            {
                con.Open();
                OleDbDataReader dt = null;
                OleDbCommand cmd = new OleDbCommand("Select * from " + tbname + "", con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    sel += double.Parse(dt["Salling"].ToString());
                }
                textBox10.Text = sel.ToString();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("not execute");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double tbud = 0;
            try
            {
                con.Open();
                OleDbDataReader dt = null;
                OleDbCommand cmd = new OleDbCommand("Select * from " + tbname + "", con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    tbud += double.Parse(dt["TotalBudget"].ToString());
                }
                textBox9.Text = tbud.ToString();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("not execute");
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            double exp = 0;
            try
            {
                con.Open();
                OleDbDataReader dt = null;
                OleDbCommand cmd = new OleDbCommand("Select * from " + tbname + "", con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    exp += double.Parse(dt["OtherExpence"].ToString());
                }
                textBox7.Text = exp.ToString();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("not execute");
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            double pur = 0;
            try
            {
                con.Open();
                OleDbDataReader dt = null;
                OleDbCommand cmd = new OleDbCommand("Select * from " + tbname + "", con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    pur += double.Parse(dt["Purchasing"].ToString());
                }
                textBox6.Text = pur.ToString();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("not execute");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            double stock = 0;
            try
            {
                con.Open();
                OleDbDataReader dt = null;
                OleDbCommand cmd = new OleDbCommand("Select * from " + tbname + "", con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    stock += double.Parse(dt["Stock"].ToString());
                }
                textBox5.Text = stock.ToString();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("not execute");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double psel = 0, dsel = 0, csel = 0;
            //   try
            //  {
            con.Open();
            OleDbDataReader dt = null;
            OleDbCommand cmd = new OleDbCommand("Select Salling from SallingDetail", con);
            dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                psel += double.Parse(dt["Salling"].ToString());
            }
            dt = null;
            OleDbCommand dmd = new OleDbCommand("Select Salling from Deisel", con);
            dt = dmd.ExecuteReader();
            while (dt.Read())
            {

                dsel += double.Parse(dt["Salling"].ToString());
            }
            dt = null;
            OleDbCommand gmd = new OleDbCommand("Select Salling from CNG", con);
            dt = gmd.ExecuteReader();
            while (dt.Read())
            {

                csel += double.Parse(dt["Salling"].ToString());
            }
            double total = psel + dsel + csel;
            textBox20.Text = total.ToString();
            con.Close();
            //   }

            //   catch (Exception ex)
            //   {
            //     MessageBox.Show("not execute");
            //  }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double psel = 0, dsel = 0, csel = 0;
            //   try
            //  {
            con.Open();
            OleDbDataReader dt = null;
            OleDbCommand cmd = new OleDbCommand("Select * from SallingDetail", con);
            dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                psel += double.Parse(dt["TotalBudget"].ToString());
            }
            dt = null;
            OleDbCommand dmd = new OleDbCommand("Select * from Deisel", con);
            dt = dmd.ExecuteReader();
            while (dt.Read())
            {

                dsel += double.Parse(dt["TotalBudget"].ToString());
            }
            dt = null;
            OleDbCommand gmd = new OleDbCommand("Select * from CNG", con);
            dt = gmd.ExecuteReader();
            while (dt.Read())
            {

                csel += double.Parse(dt["TotalBudget"].ToString());
            }
            double total = psel + dsel + csel;
            textBox19.Text = total.ToString();
            con.Close();
            //   }

            //   catch (Exception ex)
            //   {
            //     MessageBox.Show("not execute");
            //  }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Wellcome_Page wl = new Wellcome_Page();
            this.Hide();
            wl.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int sel = 0, TEMP = 0;
            try
            {
            
                con.Open();
                OleDbDataReader dt = null;
                OleDbCommand cmd = new OleDbCommand("Select * from EmployRecord", con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {

                    textBox3.Text = dt["Salary"].ToString();
                    sel = Int32.Parse(textBox3.Text);
                    TEMP += sel;
                    /// 
                    
                }
                textBox18.Show();
                textBox18.Text = TEMP.ToString();


                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("not execute");
            }
            finally
            {

                con.Close();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double psel = 0, dsel = 0, csel = 0;
            //   try
            //  {
            con.Open();
            OleDbDataReader dt = null;
            OleDbCommand cmd = new OleDbCommand("Select * from SallingDetail", con);
            dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                psel += double.Parse(dt["OtherExpence"].ToString());
            }
            dt = null;
            OleDbCommand dmd = new OleDbCommand("Select * from Deisel", con);
            dt = dmd.ExecuteReader();
            while (dt.Read())
            {

                dsel += double.Parse(dt["OtherExpence"].ToString());
            }
            dt = null;
            OleDbCommand gmd = new OleDbCommand("Select * from CNG", con);
            dt = gmd.ExecuteReader();
            while (dt.Read())
            {

                csel += double.Parse(dt["OtherExpence"].ToString());
            }
            double total = psel + dsel + csel;
            textBox17.Text = total.ToString();
            con.Close();
            //   }

            //   catch (Exception ex)
            //   {
            //     MessageBox.Show("not execute");
            //  }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double psel = 0, dsel = 0, csel = 0;
            //   try
            //  {
            con.Open();
            OleDbDataReader dt = null;
            OleDbCommand cmd = new OleDbCommand("Select * from SallingDetail", con);
            dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                psel += double.Parse(dt["LitrePrice"].ToString());
            }
            dt = null;
            OleDbCommand dmd = new OleDbCommand("Select * from Deisel", con);
            dt = dmd.ExecuteReader();
            while (dt.Read())
            {

                dsel += double.Parse(dt["LitrePrice"].ToString());
            }
            dt = null;
            OleDbCommand gmd = new OleDbCommand("Select * from CNG", con);
            dt = gmd.ExecuteReader();
            while (dt.Read())
            {

                csel += double.Parse(dt["LitrePrice"].ToString());
            }
            double total = psel + dsel + csel;
            textBox16.Text = total.ToString();
            con.Close();
            //   }

            //   catch (Exception ex)
            //   {
            //     MessageBox.Show("not execute");
            //  }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            double psel = 0, dsel = 0, csel = 0;
            //   try
            //  {
            con.Open();
            OleDbDataReader dt = null;
            OleDbCommand cmd = new OleDbCommand("Select * from SallingDetail", con);
            dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                psel += double.Parse(dt["Stock"].ToString());
            }
            dt = null;
            OleDbCommand dmd = new OleDbCommand("Select * from Deisel", con);
            dt = dmd.ExecuteReader();
            while (dt.Read())
            {

                dsel += double.Parse(dt["Stock"].ToString());
            }
            dt = null;
            OleDbCommand gmd = new OleDbCommand("Select * from CNG", con);
            dt = gmd.ExecuteReader();
            while (dt.Read())
            {

                csel += double.Parse(dt["Stock"].ToString());
            }
            double total = psel + dsel + csel;
            textBox4.Text = total.ToString();
            con.Close();
            //   }

            //   catch (Exception ex)
            //   {
            //     MessageBox.Show("not execute");
            //  }
        }
    }
}

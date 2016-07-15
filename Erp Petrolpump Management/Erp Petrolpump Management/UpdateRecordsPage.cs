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
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database1.accdb");
        
        public UpdateRecordsPage()
        {
            InitializeComponent();
        }
        public string tbname;
        public double tx,sale,tb,purc,ltpr,exp,ltr,price;
        public int II;
        public long dtm; 
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
                MessageBox.Show("Updated");
                textBox12.Clear();
                textBox16.Clear();
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
            textBox11.Clear();
            textBox15.Clear();
            MessageBox.Show("Updated");
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
            MessageBox.Show("Updated");
            textBox10.Clear();
            textBox14.Clear();
            con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Invalid nic number");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String tx = textBox8.Text;
            if (tx.IndexOf('@') == -1 || tx.IndexOf('.') == -1)
            {
                MessageBox.Show("Invalid email please type correct");
                textBox8.Clear();
            }
            else
            {
                try
                {
                    
                    int II = Int32.Parse(textBox13.Text);
                    OleDbCommand upi = new OleDbCommand("UPDATE EmployRecord SET Email ='" + tx + "' WHERE Nic=" + II + "", con);
                    con.Open();
                    upi.ExecuteNonQuery();
                    MessageBox.Show("Updated");
                    textBox8.Clear();
                    textBox13.Clear();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid nic number");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String tx = textBox7.Text;
            if (tx.Length == 11)
            {
                try
                {

                    int II = Int32.Parse(textBox9.Text);
                    OleDbCommand upi = new OleDbCommand("UPDATE EmployRecord SET Phone ='" + tx + "' WHERE Nic=" + II + "", con);
                    con.Open();
                    upi.ExecuteNonQuery();
                    MessageBox.Show("Updated");
                    textBox7.Clear();
                    textBox9.Clear();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid nic number");
                }
            }
            else {
                MessageBox.Show("Please Enter Correct format of Pakistani Phone Number");
                textBox7.Clear();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            double stock,temp;
            try
            {
                tx = double.Parse(textBox25.Text);
                
                II = Int32.Parse(textBox28.Text);
                con.Open();
                OleDbDataReader dt = null;
                OleDbCommand cmd = new OleDbCommand("Select * from SallingDetail where Dates="+II+"", con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    sale = double.Parse(dt["Salling"].ToString());
                    purc =  double.Parse(dt["Litre"].ToString());
                    tb = double.Parse(dt["TotalBudget"].ToString());
                    ltpr = double.Parse(dt["LitrePrice"].ToString());
                    exp = double.Parse(dt["OtherExpence"].ToString());
                    stock = double.Parse(dt["Stock"].ToString());
                }
              //  textBox1.Text = sel.ToString();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("not execute");
            }

            
            stock = tx-sale ;
            
            purc = ltpr * tx;
            double tbs = (tx-sale)*ltpr;
            
                try
                {

                    OleDbCommand upi = new OleDbCommand("UPDATE "+tbname+" SET Litre =" + tx + ", Purchasing=" + purc + ", TotalBudget=" + tbs + ", Stock=" + stock + " WHERE Dates=" + II + "", con);
                    con.Open();
                    upi.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid nic number");
                }
            
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
          
            double stock, temp;
            try
            {
                tx = double.Parse(textBox25.Text);
                II = Int32.Parse(textBox28.Text);
                con.Open();
                OleDbDataReader dt = null;
                OleDbCommand cmd = new OleDbCommand("Select * from SallingDetail where Dates=" + II + "", con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    sale = double.Parse(dt["Salling"].ToString());
                    purc = double.Parse(dt["Purchasing"].ToString());
                    tb = double.Parse(dt["TotalBudget"].ToString());
                    ltpr = double.Parse(dt["LitrePrice"].ToString());
                    stock = double.Parse(dt["Stock"].ToString());
                }
                //  textBox1.Text = sel.ToString();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("not execute");
            }

            double tbs = purc - sale;
            stock = tx - sale;
            temp = purc;
            purc = ltpr * tx;

            if (sale <= stock)
            {
                try
                {

                    OleDbCommand upi = new OleDbCommand("UPDATE "+tbname+" SET Litre =" + tx + ", Purchasing=" + purc + ", TotalBudget=" + tbs + ", Stock=" + stock + " WHERE Dates=" + II + "", con);
                    con.Open();
                    upi.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid nic number");
                }
            }
            else
            {
                MessageBox.Show("purchasing se ziada to selling he :/");
                textBox25.Clear();
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
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

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tbname = textBox29.Text;
            if (tbname.Equals("SallingDetail", StringComparison.Ordinal) ||
                tbname.Equals("Deisel", StringComparison.Ordinal) ||
                tbname.Equals("CNG", StringComparison.Ordinal) )
            {
                groupBox1.Enabled = true;
                if (tbname.Equals("SallingDetail", StringComparison.Ordinal))
                {
                    groupBox1.Text = "Petrol";
                }
                else
                {
                    groupBox1.Text = tbname;
                }

            }
            else
            {

                MessageBox.Show("Write correct Table Name with case sensitive");
                groupBox1.Enabled = false;
            }
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            tbname = textBox29.Text;
            if (tbname.Equals("SallingDetail", StringComparison.Ordinal) ||
                tbname.Equals("Deisel", StringComparison.Ordinal) ||
                tbname.Equals("CNG", StringComparison.Ordinal))
            {
                groupBox1.Enabled = true;
                if (tbname.Equals("SallingDetail", StringComparison.Ordinal))
                {
                    groupBox1.Text = "Petrol";
                }
                else
                {
                    groupBox1.Text = tbname;
                }

            }
            else
            {

                MessageBox.Show("Write correct Table Name with case sensitive");
                groupBox1.Enabled = false;
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            try                                        //id number
            {
                dtm = long.Parse(textBox28.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Must ID without space got it?");
                textBox28.Clear();
            }

            try                            //litre
            {

                ltr = double.Parse(textBox25.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter correct");
                textBox25.Clear();
            }

            try                             //sale
            {
                sale = double.Parse(textBox24.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter correct");
                textBox24.Clear();
            }
            try                             //expence
            {
                exp = double.Parse(textBox33.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter correct");
                textBox33.Clear();
            }

            try                        //litre price
            {
                price = double.Parse(textBox23.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Litre Price must enter");
                textBox23.Clear();
            }

            double lp = ltr * price;
            double totalp = (sale * ltr) - exp;
            double stock = ltr - sale;

            //    try
            //   {
            OleDbCommand cmd = new OleDbCommand("UPDATE " + tbname + " SET Purchasing=" + lp + ", Salling=" + sale + ", OtherExpence=" + exp + ", TotalBudget=" + totalp + ", LitrePrice=" + price + ", Litre=" + ltr + ", Stock=" + stock + " WHERE Dates=" + dtm + "", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted");
            textBox28.Clear();
            textBox25.Clear();
            textBox24.Clear();
            textBox33.Clear();
            textBox23.Clear();
            con.Close();
            //    }
            //    catch (Exception ex)
            //   {
            //       MessageBox.Show("Date must be diffrent from others dubara likh :/ Got it?");

            //   }
        }
    }
}

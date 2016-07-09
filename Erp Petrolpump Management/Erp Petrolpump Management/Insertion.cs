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
        public long dtm;
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
            try
            {
                name = textBox1.Text;
                fathername = textBox7.Text;
                email = textBox5.Text;
                phone = textBox6.Text;
                salary = Double.Parse(textBox3.Text);
                age = Int16.Parse(textBox2.Text);
                nic = Int16.Parse(textBox4.Text);
               // int count = 0;
              /*  for (int i=0;i<phone.Length ;i++ )
                {
                    if(email.ElementAt(i)!='@'){
                        count++;
                    }
                }



                if (true) { }
                else
                {*/

                    OleDbCommand cmd = new OleDbCommand("INSERT into EmployRecord(Nic, Name, Age,Salary, FatherName, Email, Phone) Values('" + nic + "', '" + name + "', '" + age + "', '" + salary + "', '" + fathername + "', '" + email + "', '" + phone + "') ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    con.Close();
                //}
            }catch(Exception ex){
                MessageBox.Show("Please correct your input");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                
            
            }
                       
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                purchase = double.Parse(textBox22.Text);
            }
            catch (Exception ex) { 
            MessageBox.Show("Please Enter correct");
            textBox22.Clear();
            }

            try
            {
                sale = double.Parse(textBox21.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter correct");
                textBox21.Clear();
            }
            try
            {
                expence = double.Parse(textBox19.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter correct");
                textBox19.Clear();
            }
            try
            {
                dtm = long.Parse(textBox8.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Must date without space got it?");
                textBox19.Clear();
            }
            double totalp = sale - expence;
            OleDbCommand cmd = new OleDbCommand("INSERT into SallingDetail(Dates, Purchasing, Salling, OtherExpence, TotalBudget ) Values('"+dtm+"', '"+purchase+"', '"+sale+"','"+expence+"', '"+totalp+"')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            
            
            


        }
    }
}

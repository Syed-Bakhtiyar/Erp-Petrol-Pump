using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;
namespace Erp_Petrolpump_Management
{
    public partial class Insertion : Form
    {
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database1.accdb");
        public Insertion()
        {
            InitializeComponent();
        }
        public string tbname,prname;
        public int[] arr = new int[7];
        public string name, fathername, phone, email, bksp;
        public int age, nic;
        public long dtm;
        public double salary,qnty, purchase, sale, expence, litre = 1, ltrr,stock;
        public void clearall(){
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        
        }

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

            string dtm = DateTime.Now.ToLongDateString();
            for (int i=0;i<arr.Length ;i++ ) {
                arr[i] = 0;
            }
        
            
            try
            {
                salary = Double.Parse(textBox3.Text);
                
                arr[0] = 1;
                if (salary < 0 || salary > 300)
                {
                    arr[0] = 0;
                }
                else {
                    arr[0] = 1;
                }
            }
            catch (Exception ex) { }

            
            try {
            age = Int16.Parse(textBox2.Text);
                if(age>15&&age<75)
            arr[1] = 1;
            }
            catch(Exception ex){}

            try {
                nic = Int16.Parse(textBox4.Text);
                arr[2] = 1;
            }catch(Exception ex){}
            email = textBox5.Text;
            
            
            
            name = textBox1.Text;
            fathername = textBox7.Text;
           
            phone = textBox6.Text;
            arr[5] = 1;
            
            
            
            if (!email.Contains("@") || !email.Contains(".com"))
            {
                arr[3] = 0;
            }
            else { arr[3] = 1; }


            if(!(fathername.Equals(name,StringComparison.Ordinal))){
                arr[4] = 1;
                arr[6] = 1;
            }
            
            
            
            
            if(arr[0]==0){
                MessageBox.Show("Enter Correct Salary or greater than 300 is not valid");
                textBox3.Clear();
            }
            if (arr[1] == 0)
            {
                MessageBox.Show("Enter Correct Age");
                textBox2.Clear();
            }
            if (arr[2] == 0)
            {
                MessageBox.Show("Enter Correct Nic");
                textBox4.Clear();
            }
            if (arr[3] == 0)
            {
                MessageBox.Show("Enter Correct Email");
                textBox5.Clear();
            }
            
            if (arr[4] == 0||arr[6]==0)
            {
                MessageBox.Show("Match Name and Father Name");
                textBox1.Clear();
                textBox7.Clear();
            }
            if(arr[5]==0){
                MessageBox.Show("Invalid phone number");
            }
            
                
               
                if(arr[0]==1&&arr[1]==1&&arr[2]==1&&arr[3]==1&&arr[4]==1&&arr[5]==1&&arr[6]==1){
                    try{
                    OleDbCommand cmd = new OleDbCommand("INSERT into EmployRecord(Nic, Name, Age,Salary, FatherName, Email, Phone, datetm) Values('" + nic + "', '" + name + "', '" + age + "', '" + salary + "', '" + fathername + "', '" + email + "', '" + phone + "','"+dtm+"') ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    MessageBox.Show("insert successfully");
                    con.Close();
                //}
            }catch(Exception ex){
                MessageBox.Show("Nic must be diffrent from others :/ Got it?");
                
                textBox4.Clear();
                
            
            }
          }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string dttm = DateTime.Now.ToLongDateString();
            try
            {
                purchase = double.Parse(textBox22.Text);
                ltrr = double.Parse(textBox22.Text);
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
            try
            {
                litre = double.Parse(textBox9.Text);
            }
            catch (Exception ex) {
                MessageBox.Show("Form must fill");
            }

            double lp = litre*purchase;
            double totalp = (sale * litre)-expence;
            stock = purchase - sale;
            //if (sale < purchase == true)
            //{
                try
                {
                    OleDbCommand cmd = new OleDbCommand("INSERT into "+tbname+"(Dates, Purchasing, Salling, OtherExpence, TotalBudget, LitrePrice, Litre, Stock, datetm) Values('" + dtm + "', '" + lp + "', '" + sale + "','" + expence + "', '" + totalp + "', '" + litre + "', '" + ltrr + "', '"+stock+"','"+dttm+"')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserted");
                    textBox22.Clear();
                    textBox9.Clear();
                    textBox21.Clear();
                    textBox19.Clear();
                    textBox8.Clear();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Date must be diffrent from others dubara likh :/ Got it?");
                    
                }
           // }
            //else {
              //  MessageBox.Show("Itna stock ni he jitna tu bechna chahta hey dubara Sahi likh");
                //textBox21.Clear();
            //}
            
            
            


        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar < '0' || e.KeyChar > '9') {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number like this 2232016 or 21213");
                e.KeyChar = (char)0;
            }
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number");
                e.KeyChar = (char)0;
            }
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number");
                e.KeyChar = (char)0;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string dttm = DateTime.Now.ToLongDateString();
            
                prname = textBox14.Text;
               
            

            try
            {
                qnty = double.Parse(textBox13.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter correct in numbers");
                textBox13.Clear();
            }
            try
            {
                sale = double.Parse(textBox12.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter correct");
                textBox12.Clear();
            }
            try
            {
                dtm = long.Parse(textBox11.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Must date without space got it?");
                textBox11.Clear();
            }
            try
            {
                purchase = double.Parse(textBox10.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form must fill");
                textBox10.Clear();
            }
           
            double totalp = sale * purchase;
            stock = qnty - sale;
            double tpr = purchase * qnty;
            
            try
            {
                OleDbCommand cmd = new OleDbCommand("INSERT into Oil(Dates, ProductName, Price, quantity, Salling, TotalBud, Stock, datetm) Values('" + dtm + "', '" + prname + "', '" + tpr + "','" + (qnty*12) + "', '"+sale+"', '" + totalp + "', '"+stock+"','"+dttm+"')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted");
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox14.Clear();
                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Date must be diffrent from others :/ Got it?");
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

            
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbname = textBox23.Text;
            if (tbname.Equals("SallingDetail", StringComparison.Ordinal) ||
                tbname.Equals("Deisel", StringComparison.Ordinal) ||
                tbname.Equals("CNG", StringComparison.Ordinal))
            {
                groupBox2.Enabled = true;
            //    button8.Enabled = false;
              //  textBox23.Enabled = false;
                label24.Enabled = false;
            }
            else { MessageBox.Show("Write correct Table Name with case sensitive");
            
            }

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            


        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox22.Clear();
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            textBox9.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox21.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox19.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox14.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox13.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox12.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox11.Clear();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox9_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }
    }
}

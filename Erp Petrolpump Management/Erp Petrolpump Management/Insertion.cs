﻿using System;
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
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Syed Inkisar Ahmed\\Documents\\Database1.accdb");
        public Insertion()
        {
            InitializeComponent();
        }
        public int[] arr = new int[7];
        public string name, fathername, phone, email;
        public int age, nic;
        public long dtm;
        public double salary, purchase, sale, expence, litre = 1, ltrr,stock;
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
            for (int i=0;i<arr.Length ;i++ ) {
                arr[i] = 0;
            }
        
            
            try
            {
                salary = Double.Parse(textBox3.Text);
                
                arr[0] = 1;
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
            
            
            
            if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1)
            {
                arr[3] = 0;
            }
            else { arr[3] = 1; }


            if(!(fathername.Equals(name,StringComparison.Ordinal))){
                arr[4] = 1;
                arr[6] = 1;
            }
            
            
            
            
            if(arr[0]==0){
                MessageBox.Show("Enter Correct Salary");
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
            double totalp = sale * litre;
            stock = purchase - sale;
            if (sale < purchase == true)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("INSERT into SallingDetail(Dates, Purchasing, Salling, OtherExpence, TotalBudget, LitrePrice, Litre, Stock) Values('" + dtm + "', '" + lp + "', '" + sale + "','" + expence + "', '" + totalp + "', '" + litre + "', '" + ltrr + "', '"+stock+"')", con);
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
            }
            else {
                MessageBox.Show("Itna stock ni he jitna tu bechna chahta hey dubara Sahi likh");
                textBox21.Clear();
            }
            
            
            


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
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter type only number");
                e.KeyChar = (char)0;
            }
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

            try
            {
                purchase = double.Parse(textBox14.Text);
                ltrr = double.Parse(textBox14.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter correct");
                textBox14.Clear();
            }

            try
            {
                sale = double.Parse(textBox13.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter correct");
                textBox13.Clear();
            }
            try
            {
                expence = double.Parse(textBox12.Text);
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
                litre = double.Parse(textBox10.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form must fill");
                textBox10.Clear();
            }
            double lp = litre * purchase;
            double totalp = sale * litre;
            stock = purchase - sale;
            if(sale<purchase){
            try
            {
                OleDbCommand cmd = new OleDbCommand("INSERT into Deisel(Dates, Purchasing, Salling, OtherExpence, TotalBudget, LitrePrice, Litre, Stock) Values('" + dtm + "', '" + lp + "', '" + sale + "','" + expence + "', '" + totalp + "', '" + litre + "', '" + ltrr + "', '"+stock+"')", con);
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
            else{
                MessageBox.Show("Itna stock ni he jitna tu bechna chahta hey dubara Sahi likh");
                textBox13.Clear();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                purchase = double.Parse(textBox20.Text);
                ltrr = double.Parse(textBox20.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter correct");
                textBox20.Clear();
            }

            try
            {
                sale = double.Parse(textBox18.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter correct");
                textBox18.Clear();
            }
            try
            {
                expence = double.Parse(textBox17.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter correct");
                textBox17.Clear();
            }
            try
            {
                dtm = long.Parse(textBox16.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Must date without space got it?");
                textBox16.Clear();
            }
            try
            {
                litre = double.Parse(textBox15.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form must fill");
                textBox15.Clear();
            }
            double lp = litre * purchase;
            double totalp = sale * litre;
            stock = purchase - sale;
            if(sale<purchase){
            try
            {
                OleDbCommand cmd = new OleDbCommand("INSERT into CNG(Dates, Purchasing, Salling, OtherExpence, TotalBudget, LitrePrice, Litre, Stock) Values('" + dtm + "', '" + lp + "', '" + sale + "','" + expence + "', '" + totalp + "', '" + litre + "', '" + ltrr + "', '"+stock+"')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted");
                textBox15.Clear();
                textBox16.Clear();
                textBox17.Clear();
                textBox18.Clear();
                textBox20.Clear();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Date must be diffrent from others :/ Got it?");
            }
            }
            else{
                MessageBox.Show("Itna stock ni he jitna tu bechna chahta hey dubara Sahi likh");
                textBox18.Clear();
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
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }
    }
}

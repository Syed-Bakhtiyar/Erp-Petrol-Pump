using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Erp_Petrolpump_Management
{
    public partial class Form1 : Form
    {
        String password="password.dat";
        String tempos, pssword;
        public Form1()
        {
            InitializeComponent();
        }
        public void btn10() {
            button10.Show();
        }
        public void clearall() {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }
        void btn1() {

            button1.Hide();
        }
        public void disable() {
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            
            button1.Show();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            
            label2.Hide();
            


        
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (TextReader tr = File.OpenText(@"username.txt"))
            {
                label1.Text = tr.ReadLine();

            }
            if (File.Exists(password))
            {
                disable();
                button1.Hide();
                textBox1.Show();
                button6.Show();
                   
            
            }
            else
            {
                disable();
                button1.Show();
            }
            
            
            
            
            
            
           textBox1.Hide();
           button6.Hide();
            if(File.Exists(password)){
                button1.Hide();
                textBox1.Show();
                button6.Show();
            }







        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wellcome_Page wel = new Wellcome_Page();
            this.Hide();
            wel.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tempos=textBox1.Text;
            
            
            using(BinaryReader bb = new BinaryReader(File.Open(password,FileMode.Open))){
             
                pssword = bb.ReadString();
                if (pssword.Equals(tempos,StringComparison.Ordinal))
                {
                    bb.Close();
                    disable();
                    
                }
                else {
                    MessageBox.Show("Please enter correct password");
                    textBox1.Clear();
                    bb.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disable();
            btn1();
            btn10();
            textBox2.Show();
            button7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            String user = textBox2.Text;
            if(user.Equals(" ")){
                MessageBox.Show("Please type name correctly");
                textBox2.Clear();
            }else{
                File.Delete("username.txt");
                using (TextWriter bb = File.CreateText("username.txt"))
                {
                    bb.Write(user);
                   
                    bb.Close();
                    textBox2.Clear();
                 using(TextReader tr = File.OpenText(@"username.txt")){
                     label1.Text = tr.ReadLine();
                 
                 }   

                }
            
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            
            disable();
            btn1();
            btn10();
            textBox3.Show();
            button8.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            String pswrd;
            pswrd = textBox3.Text;
            if (pswrd.Length < 8)
            {
                MessageBox.Show("password should be maximum 8 characters");
                textBox3.Clear();
            }
            else
            {
                if (File.Exists(password)==true)
                {
                    MessageBox.Show("Password already exist");
                    textBox3.Clear();
                }
                else if(!File.Exists(password))
                {
                    using (BinaryWriter writ = new BinaryWriter(File.Open(password, FileMode.OpenOrCreate)))
                    {
                        //writ.Seek(0,0);
                        writ.Write(pswrd);
                        textBox3.Clear();
                        textBox3.Hide();
                        button8.Hide();
                        textBox1.Show();
                        button6.Show();
                        writ.Close();
                    }

                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            disable();
            btn1();
            btn10();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            disable();
            btn1();
            btn10();
            button9.Show();
            textBox4.Show();
            label2.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (File.Exists(password))
            {
                using (BinaryReader read = new BinaryReader(File.Open(password, FileMode.Open)))
                {
                    String rem = textBox4.Text;
                    String dlt = read.ReadString();
                    if (dlt.Equals(rem, StringComparison.OrdinalIgnoreCase))
                    {
                        read.Close();
                        File.Delete("password.dat");
                        button9.Hide();
                        textBox4.Hide();
                        label2.Hide();
                    }
                    else
                    {
                        MessageBox.Show("you have entered wrong password");
                    }
                }
            }
            else {
                MessageBox.Show("There is no password");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (File.Exists(password))
            {
                disable();
                btn1();
                textBox1.Show();
                button6.Show();
            }
            else {
                disable();
                button1.Show();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            

            
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            clearall();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace Erp_Petrolpump_Management
{
    public partial class FaxPageForOrdered : Form
    {
        public FaxPageForOrdered()
        {
            InitializeComponent();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            try
            {
                String prnm = textBox1.Text, tomail, frommail, pswrd, flname = "file1.txt";
                int quant = Int32.Parse(textBox2.Text);
                count = 1;
            //    string fax = textBox3.Text;
                frommail = textBox3.Text;
                tomail = textBox4.Text;
                pswrd = textBox5.Text;
                if (frommail.IndexOf('@') == -1 || frommail.IndexOf('.') == -1)
                {
                    MessageBox.Show("invalid email type correct");
                    textBox3.Clear();
                }
                if (tomail.IndexOf('@') == -1 || tomail.IndexOf('.') == -1)
                {
                    MessageBox.Show("invalid email type correct");
                    textBox4.Clear();
                }

                
                MailMessage ms = new MailMessage();
                SmtpClient smt = new SmtpClient("smtp.gmail.com");
                ms.From = new MailAddress(frommail);
                ms.To.Add(tomail);
                ms.Subject = "product: " + prnm + " Quantity: " + quant.ToString();
                ms.Body = "ABCPetrolpump";
                smt.Port = 587;
                smt.Credentials = new System.Net.NetworkCredential("SYED BAKHTIYAR", pswrd);
                smt.EnableSsl = true;
                smt.Send(ms);
                MessageBox.Show("send");
            }
            catch (Exception ex) {
                if (count == 0)
                {
                    MessageBox.Show("please fill form and enter correct quantity in number like 22343");
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("If you want to access with your application with your gmail id then logint to your account in settings click\nForwarding and POP/IMAP and then click enable IMAP\n now going to this link https://www.google.com/settings/security/lesssecureapps and click radio button turn on but it is so risk\n\nGot it?");
                }
                }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Wellcome_Page wl = new Wellcome_Page();
            this.Hide();
            wl.Show();
        }

        private void FaxPageForOrdered_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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

            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String prnm = textBox1.Text;
            int quant = Int32.Parse(textBox2.Text); 
            string fax = textBox3.Text;
            using (TextWriter bb = File.CreateText("file1.txt"))
            {
                bb.Write("product name:  "+prnm+"\n");
                bb.Write("quantity:   " + quant + "\n");

                bb.Close();
                //textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wellcome_Page wl = new Wellcome_Page();
            this.Hide();
            wl.Show();
        }
    }
}

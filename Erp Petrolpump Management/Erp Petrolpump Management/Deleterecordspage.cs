﻿using System;
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
    public partial class Deleterecordspage : Form
    {
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Syed Inkisar Ahmed\\Documents\\Database1.accdb");
        public Deleterecordspage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Wellcome_Page wl = new Wellcome_Page();
            this.Hide();
            wl.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dl = Int16.Parse(textBox1.Text);
            OleDbCommand dlt = new OleDbCommand("DELETE FROM EmployRecord Where Nic="+dl+"",con);
            con.Open();
            dlt.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteForm d = new DeleteForm();
            this.Hide();
            d.Show();
        }
    }
}

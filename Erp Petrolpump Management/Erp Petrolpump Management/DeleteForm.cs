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
    public partial class DeleteForm : Form
    {
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Syed Inkisar Ahmed\\Documents\\Database1.accdb");
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand dlt = new OleDbCommand("DELETE FROM EmployRecord", con);
            con.Open();
            dlt.ExecuteNonQuery();
            con.Close();
            Deleterecordspage dl = new Deleterecordspage();
            this.Hide();
            dl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deleterecordspage dl = new Deleterecordspage();
            this.Hide();
            dl.Show();
        }
    }
}

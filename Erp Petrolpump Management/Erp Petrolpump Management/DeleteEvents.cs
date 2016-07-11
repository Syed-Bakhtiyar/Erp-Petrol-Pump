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
    public partial class DeleteEvents : Form
    {
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Syed Inkisar Ahmed\\Documents\\Database1.accdb");
        public DeleteEvents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand dlt = new OleDbCommand("DELETE FROM Events", con);
                con.Open();
                dlt.ExecuteNonQuery();
                con.Close();
                Events ev = new Events();
                this.Hide();
                ev.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("can't Delete");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Events ev = new Events();
            this.Hide();
            ev.Show();
        }
    }
}

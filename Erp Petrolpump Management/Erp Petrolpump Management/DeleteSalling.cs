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
    public partial class DeleteSalling : Form
    {
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Syed Inkisar Ahmed\\Documents\\Database1.accdb");
        public DeleteSalling(String tb)
        {
            this.tbname = tb;
            InitializeComponent();
        }
        public string tbname;
        public void rec(string tname)
        {
            this.tbname = tname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deleterecordspage dr = new Deleterecordspage();
            try {
                OleDbCommand dlt = new OleDbCommand("DELETE FROM "+tbname+"", con);
                con.Open();
                dlt.ExecuteNonQuery();
                con.Close();
                //Deleterecordspage dl = new Deleterecordspage();
                this.Hide();
                dr.Show();
            }catch(Exception ex){
            MessageBox.Show("can't deleted");
            this.Hide();
            dr.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deleterecordspage ds = new Deleterecordspage();
            this.Hide();
            ds.Show();
        }

        private void DeleteSalling_Load(object sender, EventArgs e)
        {

        }
    }
}

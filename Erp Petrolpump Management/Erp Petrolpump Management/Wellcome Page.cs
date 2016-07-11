using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Erp_Petrolpump_Management
{
    public partial class Wellcome_Page : Form
    {
        public Wellcome_Page()
        {
            InitializeComponent();
        }

        private void Wellcome_Page_Load(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insertion ins = new Insertion();
            this.Hide();
            ins.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            this.Hide();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateRecordsPage up = new UpdateRecordsPage();
            this.Hide();
            up.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VeiwAll read = new VeiwAll();
            this.Hide();
            read.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchEmployDetail sr = new SearchEmployDetail();
            this.Hide();
            sr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Deleterecordspage dl = new Deleterecordspage();
            this.Hide();
            dl.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Help hl = new Help();
            this.Hide();
            hl.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Events ev = new Events();
            this.Hide();
            ev.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            BossVeiw bs = new BossVeiw();
            this.Hide();
            bs.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            PrintPageForm pr = new PrintPageForm();
            this.Hide();
            pr.Show();
        }
    }
}

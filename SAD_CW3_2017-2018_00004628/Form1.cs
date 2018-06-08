using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD_CW3_2017_2018_00004628
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ln = new Login();
            ln.ShowDialog();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffFormRead sfr = new StaffFormRead();
            sfr.ShowDialog();
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModulesFormRead mfr = new ModulesFormRead();
            mfr.ShowDialog();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventsFormRead efr = new EventsFormRead();
            efr.ShowDialog();
        }

        private void btnNews_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewsFormRead nfr = new NewsFormRead();
            nfr.ShowDialog();
        }
    }
}

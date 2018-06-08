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
    public partial class Back_desk : MetroFramework.Forms.MetroForm
    {
        public Back_desk()
        {
            InitializeComponent();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffForm sf = new StaffForm();
            sf.ShowDialog();
        }

        private void btnGoFront_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fd = new Form1();
            fd.ShowDialog();
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModulesForm mf = new ModulesForm();
            mf.ShowDialog();
        }

        private void btnNews_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewsForm nf = new NewsForm();
            nf.ShowDialog();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventsForm ef = new EventsForm();
            ef.ShowDialog();
        }
    }
}

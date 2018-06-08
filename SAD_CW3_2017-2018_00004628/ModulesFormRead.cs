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
    public partial class ModulesFormRead : MetroFramework.Forms.MetroForm
    {
        public ModulesFormRead()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void ModulesFormRead_Load(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                modulesBindingSource.DataSource = db.ModulesList.ToList();
            }
        }

        private void staffGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

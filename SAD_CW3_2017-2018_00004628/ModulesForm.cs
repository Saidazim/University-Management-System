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
    public partial class ModulesForm : MetroFramework.Forms.MetroForm
    {
        public ModulesForm()
        {
            InitializeComponent();
        }

        private void ModulesForm_Load(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                modulesBindingSource.DataSource = db.ModulesList.ToList();
            }
            pContainer.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pContainer.Enabled = true;
            modulesBindingSource.Add(new Modules());
            modulesBindingSource.MoveLast();
            txtModulesName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pContainer.Enabled = true;
            txtModulesName.Focus();
            Modules obj = modulesBindingSource.Current as Modules;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pContainer.Enabled = false;
            modulesBindingSource.ResetBindings(false);
            ModulesForm_Load(sender, e);
        }

        private void modulesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Modules obj = modulesBindingSource.Current as Modules;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are u sure to delete it?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (ModelContext db = new ModelContext())
                {
                    Modules obj = modulesBindingSource.Current as Modules;
                    if (obj != null)
                    {
                        if (db.Entry<Modules>(obj).State == System.Data.Entity.EntityState.Detached)
                            db.Set<Modules>().Attach(obj);
                        db.Entry<Modules>(obj).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        modulesBindingSource.RemoveCurrent();
                        pContainer.Enabled = false;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                Modules obj = modulesBindingSource.Current as Modules;
                if (obj != null)
                {
                    if (db.Entry<Modules>(obj).State == System.Data.Entity.EntityState.Detached)
                        db.Set<Modules>().Attach(obj);
                    if (obj.ModuleID == 0)
                    {
                        db.Entry<Modules>(obj).State = System.Data.Entity.EntityState.Added;
                    }
                    else
                    {
                        db.Entry<Modules>(obj).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                    modulesGrid.Refresh();
                    pContainer.Enabled = false;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Back_desk bd = new Back_desk();
            bd.ShowDialog();
        }
    }
}

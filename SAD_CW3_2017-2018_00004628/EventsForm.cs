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
    public partial class EventsForm : MetroFramework.Forms.MetroForm
    {
        public EventsForm()
        {
            InitializeComponent();
        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                eventsBindingSource.DataSource = db.EventsList.ToList();
            }
            pContainer.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pContainer.Enabled = true;
            eventsBindingSource.Add(new Events());
            eventsBindingSource.MoveLast();
            txtEventsDesc.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pContainer.Enabled = true;
            txtEventsDesc.Focus();
            Events obj = eventsBindingSource.Current as Events;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pContainer.Enabled = false;
            eventsBindingSource.ResetBindings(false);
            EventsForm_Load(sender, e);
        }

        private void eventsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Events obj = eventsBindingSource.Current as Events;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are u sure to delete it?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (ModelContext db = new ModelContext())
                {
                    Events obj = eventsBindingSource.Current as Events;
                    if (obj != null)
                    {
                        if (db.Entry<Events>(obj).State == System.Data.Entity.EntityState.Detached)
                            db.Set<Events>().Attach(obj);
                        db.Entry<Events>(obj).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        eventsBindingSource.RemoveCurrent();
                        pContainer.Enabled = false;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                Events obj = eventsBindingSource.Current as Events;
                if (obj != null)
                {
                    if (db.Entry<Events>(obj).State == System.Data.Entity.EntityState.Detached)
                        db.Set<Events>().Attach(obj);
                    if (obj.EventID == 0)
                    {
                        db.Entry<Events>(obj).State = System.Data.Entity.EntityState.Added;
                    }
                    else
                    {
                        db.Entry<Events>(obj).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                    eventsGrid.Refresh();
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

        private void chkEventsStatus_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkEventsStatus.CheckState == CheckState.Checked)
                chkEventsStatus.Text = "Planned";
            else if (chkEventsStatus.CheckState == CheckState.Unchecked)
                chkEventsStatus.Text = "Ended";
            else
                chkEventsStatus.Text = "???";
        }
    }
}

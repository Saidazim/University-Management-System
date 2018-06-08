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
    public partial class StaffForm : MetroFramework.Forms.MetroForm
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg"})
            {
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    picStaff.Image = Image.FromFile(ofd.FileName);
                    Staff obj = staffBindingSource.Current as Staff;
                    if (obj != null)
                    {
                        obj.ImageUrl = ofd.FileName;
                    }
                }
            }
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            using(ModelContext db = new ModelContext())
            {
                staffBindingSource.DataSource = db.StaffList.ToList();
            }
            pContainer.Enabled = false;
            Staff obj = staffBindingSource.Current as Staff;
            if (obj != null)
            {
                if (obj.FullName != null)
                {
                    picStaff.Image = Image.FromFile(obj.ImageUrl);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            picStaff.Image = null;
            pContainer.Enabled = true;
            staffBindingSource.Add(new Staff());
            staffBindingSource.MoveLast();
            txtStaffName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pContainer.Enabled = true;
            txtStaffName.Focus();
            Staff obj = staffBindingSource.Current as Staff;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pContainer.Enabled = false;
            staffBindingSource.ResetBindings(false);
            StaffForm_Load(sender, e);
        }

        private void staffGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Staff obj = staffBindingSource.Current as Staff;
            if (obj != null)
            {
                if (obj.FullName != null)
                {
                    picStaff.Image = Image.FromFile(obj.ImageUrl);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are u sure to delete it?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                using (ModelContext db = new ModelContext())
                {
                    Staff obj = staffBindingSource.Current as Staff;
                    if (obj != null)
                    {
                        if (db.Entry<Staff>(obj).State == System.Data.Entity.EntityState.Detached)
                            db.Set<Staff>().Attach(obj);
                        db.Entry<Staff>(obj).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        staffBindingSource.RemoveCurrent();
                        pContainer.Enabled = false;
                        picStaff.Image = null;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                Staff obj = staffBindingSource.Current as Staff;
                if (obj != null && picStaff.Image != null)
                {
                    if (db.Entry<Staff>(obj).State == System.Data.Entity.EntityState.Detached)
                        db.Set<Staff>().Attach(obj);
                    if (obj.StaffID == 0)
                    {
                        db.Entry<Staff>(obj).State = System.Data.Entity.EntityState.Added;
                    }
                    else
                    {
                        db.Entry<Staff>(obj).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                    staffGrid.Refresh();
                    pContainer.Enabled = false;
                }
                else
                    MessageBox.Show("Please, Fill all");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Back_desk bd = new Back_desk();
            bd.ShowDialog();
        }

        private void chkStaffGender_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkStaffGender.CheckState == CheckState.Checked)
                chkStaffGender.Text = "Female";
            else if (chkStaffGender.CheckState == CheckState.Unchecked)
                chkStaffGender.Text = "Male";
            else
                chkStaffGender.Text = "???";
        }
    }
}

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
    public partial class NewsForm : MetroFramework.Forms.MetroForm
    {
        public NewsForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picNews.Image = Image.FromFile(ofd.FileName);
                    News obj = newsBindingSource.Current as News;
                    if (obj != null)
                    {
                        obj.ImageUrl = ofd.FileName;
                    }
                }
            }
        }

        private void NewsForm_Load(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                newsBindingSource.DataSource = db.NewsList.ToList();
            }
            pContainer.Enabled = false;
            News obj = newsBindingSource.Current as News;
            if (obj != null)
            {
                picNews.Image = Image.FromFile(obj.ImageUrl);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            picNews.Image = null;
            pContainer.Enabled = true;
            newsBindingSource.Add(new News());
            newsBindingSource.MoveLast();
            txtNewsTitle.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pContainer.Enabled = true;
            txtNewsTitle.Focus();
            News obj = newsBindingSource.Current as News;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pContainer.Enabled = false;
            newsBindingSource.ResetBindings(false);
            NewsForm_Load(sender, e);
        }

        private void newsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            News obj = newsBindingSource.Current as News;
            if (obj != null)
            {
                if (obj.Title != null)
                {
                    picNews.Image = Image.FromFile(obj.ImageUrl);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are u sure to delete it?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (ModelContext db = new ModelContext())
                {
                    News obj = newsBindingSource.Current as News;
                    if (obj != null)
                    {
                        if (db.Entry<News>(obj).State == System.Data.Entity.EntityState.Detached)
                            db.Set<News>().Attach(obj);
                        db.Entry<News>(obj).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        newsBindingSource.RemoveCurrent();
                        pContainer.Enabled = false;
                        picNews.Image = null;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                News obj = newsBindingSource.Current as News;
                if (obj != null && picNews.Image != null)
                {
                    if (db.Entry<News>(obj).State == System.Data.Entity.EntityState.Detached)
                        db.Set<News>().Attach(obj);
                    if (obj.NewsID == 0)
                    {
                        db.Entry<News>(obj).State = System.Data.Entity.EntityState.Added;
                    }
                    else
                    {
                        db.Entry<News>(obj).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                    newsGrid.Refresh();
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
    }
}

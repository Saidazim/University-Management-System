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
    public partial class NewsFormRead : MetroFramework.Forms.MetroForm
    {
        public NewsFormRead()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void NewsFormRead_Load(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                newsBindingSource.DataSource = db.NewsList.ToList();
            }
            News obj = newsBindingSource.Current as News;
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
                    }
                }
            }
        }
    }
}

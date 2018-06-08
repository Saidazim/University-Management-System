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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "admin" && tbxPassword.Text == "1")
            {
                this.Hide();
                Back_desk bd = new Back_desk();
                bd.ShowDialog();
                lblError.Text = "";
            }
            else if (tbxUsername.Text == "" || tbxPassword.Text == "")
            {
                lblError.Text = "Fields should not be blank";
            }
            else
            {
                lblError.Text = "Incorrect Username or Password";
            }
        }
    }
}

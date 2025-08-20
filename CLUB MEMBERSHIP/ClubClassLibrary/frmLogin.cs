using ClubClassLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubUI
{
    public partial class frmLogin : Form
    {
        UserRepository repoUser = new UserRepository();
        public bool LoggedIn = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var user = repoUser.CheckLogin(emailTB.Text, PasswordTB.Text);
            if (user != null) { 
                App.CurrentUser = user; 
                LoggedIn = true;
                this.Close();
            } else
            {
                MessageBox.Show("INVALID LOGIN INFO!");
            }
        }
    }
}

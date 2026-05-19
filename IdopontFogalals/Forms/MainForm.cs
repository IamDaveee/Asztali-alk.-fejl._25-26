using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdopontFogalals
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            if (loginForm.DialogResult==DialogResult.OK)
            {
                btnLogin.Visible = false;
                btnLogout.Visible = true;
                lblGreeting.Text = $"Welcome back, {Session.Username}";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Logout();
            MessageBox.Show("Logout successful.");
            btnLogin.Visible = true;
            btnLogout.Visible = false;
            lblGreeting.Text = "Please Log in to use all the functions";
        }

        private void btnFoglalas_Click(object sender, EventArgs e)
        {
            if (Session.UserId!=0)
            {
                Foglalas foglalas = new Foglalas();
                foglalas.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please login first!");
            }
        }

        private void btnLekerdezes_Click(object sender, EventArgs e)
        {
            if (Session.UserId!=0)
            {
                Lekérdezés lekerdezes = new Lekérdezés();
                lekerdezes.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please login first!");
            }
        }
    }
}

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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username=txtUsername.Text;
            string email=txtEmail.Text;
            string mobile=txtMobile.Text;
            string password=txtPassword.Text;
            string confirmPassword=txtConfirmPassword.Text;

            List<string> errors = new List<string>();

            
            if (ValidationHelper.IsEmpty(username) ||
            ValidationHelper.IsEmpty(email) ||
            ValidationHelper.IsEmpty(mobile) ||
            ValidationHelper.IsEmpty(password) ||
            ValidationHelper.IsEmpty(confirmPassword))
            {
                errors.Add("Please fill in every field.");
            }

            if (ValidationHelper.IsValidEmail(email))
            {
                errors.Add("Email is not valid.");
            }

            if (password != confirmPassword)
            {
                errors.Add("Passwords do not match.");
            }

            UserRepository userRepository = new UserRepository();

            if (userRepository.UsernameExists(username))
            {
                errors.Add("Username is already taken.");
            }
            if (userRepository.EmailExists(email))
            {
                errors.Add("Email is already registered");
            }
            if (userRepository.MobileExists(mobile))
            {
                errors.Add("Mobile number is already registered");
            }

            if (errors.Count>0)
            {
                MessageBox.Show(
                    string.Join("\n", errors),
                    "Registration error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            else
            {
                userRepository.RegisterUser(username, email, mobile, password);
                MessageBox.Show("Registration sucessful.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

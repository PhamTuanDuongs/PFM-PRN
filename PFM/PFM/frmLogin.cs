using PFM.Models;
using System.Text.RegularExpressions;

namespace PFM
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            frmSignup s = new frmSignup();
            s.Show();
            this.Hide();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            using (PFMContext context = new PFMContext())
            {
                if (ValidateChildren())
                {
                    // ValidateChildren là một phương thức có sẵn trong Windows Forms để kích hoạt kiểm tra
                    // validating trên tất cả các control con trong form. 
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;
                    Account account = context.Accounts.FirstOrDefault(x => x.Username == username && x.Password == password);
                    if (account != null)
                    {
                        LoginInfo.Id = account.Id;
                        LoginInfo.Username = txtUsername.Text;
                        MessageBox.Show("Login Successfully");
                        frmMain dashboard = new frmMain();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Fail");

                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "Name should not be left blank!");
            }
            else if (!Regex.Match(txtUsername.Text, @"^[0-9\\-\\+]{10}$").Success)
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "Username must be a phone number with length 10 digits");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, "");

            }
        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Name should not be left blank!");
            }
            else if (txtPassword.Text.Length > 50)
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Password should not larger than 50 characters");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, "");

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
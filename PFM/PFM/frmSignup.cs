using PFM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFM
{
    public partial class frmSignup : Form
    {
        PFMContext context;
        public frmSignup()
        {
            context = new PFMContext();
            InitializeComponent();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            bool checkExitUsername = (from account in context.Accounts
                                      where account.Username == txtUsername.Text
                                      select account).Any();

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
                errorProvider1.SetError(txtUsername, "User name must be a phone number with length 10 digits");
            }
            else if (checkExitUsername)
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "Username is exited !!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, "");

            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
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

        private void txtDisplayName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDisplayName.Text))
            {
                e.Cancel = true;
                txtDisplayName.Focus();
                errorProvider1.SetError(txtDisplayName, "Name should not be left blank!");
            }
            else if (txtDisplayName.Text.Length > 50)
            {
                e.Cancel = true;
                txtDisplayName.Focus();
                errorProvider1.SetError(txtDisplayName, "Password should not larger than 50 characters");
            }
            else
            {

                e.Cancel = false;
                errorProvider1.SetError(txtDisplayName, "");


            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Username = txtUsername.Text;
            account.Password = txtPassword.Text;
            account.Displayname = txtDisplayName.Text;
            context.Accounts.Add(account);
            context.SaveChanges();
            MessageBox.Show("Sign Up successfully");
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }


    }
}

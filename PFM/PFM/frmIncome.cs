using PFM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFM
{
    public partial class frmIncome : Form
    {
        PFMContext context;
        public frmIncome()
        {
            context = new PFMContext();
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            Income income = new Income();
            income.Name = txtName.Text;
            income.Description = txtDescription.Text;
            income.CreatedAt = DateTime.Parse(dtCreated.Value.ToString());
            income.Amount = Double.Parse(txtAmount.Text);
            income.AccountId = LoginInfo.Id;
            income.CategoryId = Convert.ToInt32(cbCategory.SelectedValue.ToString());
            context.Incomes.Add(income);
            context.SaveChanges();
            MessageBox.Show("add income successfully");
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                validate.SetError(txtName, "Name should not be left blank!");
            }
            else if (txtName.Text.Length > 150)
            {
                e.Cancel = true;
                txtName.Focus();
                validate.SetError(txtName, "The length of income name should not be larger than 150 characters");
            }
            else
            {
                e.Cancel = false;
                validate.SetError(txtName, "");
            }
        }

        private void dtCreated_Validating(object sender, CancelEventArgs e)
        {
            if (dtCreated.Value > DateTime.Now)
            {
                e.Cancel = true;
                dtCreated.Focus();
                validate.SetError(dtCreated, "Datetime should not be larger than current date");
            }
            else
            {
                e.Cancel = false;
                validate.SetError(dtCreated, "");
            }
        }

        private void txtAmount_Validating(object sender, CancelEventArgs e)
        {
            decimal d;
            bool check = decimal.TryParse(txtAmount.Text, out d);

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                validate.SetError(txtName, "Name should not be left blank!");
            }
            else if (!check || d < 0)
            {
                e.Cancel = true;
                txtAmount.Focus();
                validate.SetError(txtAmount, "The amount must be a number and positive number");
            }
            else if (Regex.Match(txtAmount.Text, @"^\\d{16}$ ").Success)
            {
                e.Cancel = true;
                txtAmount.Focus();
                validate.SetError(txtAmount, "The amount entered is not valid");
            }
            else
            {
                e.Cancel = false;
                validate.SetError(txtAmount, "");
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (txtDescription.Text.Length > 250)
            {
                e.Cancel = true;
                txtDescription.Focus();
                validate.SetError(txtDescription, "The length of description should not be larger than 250 characters");
            }
        }

        private void frmIncome_Load(object sender, EventArgs e)
        {
            cbCategory.DataSource = context.Categories.Where(x => x.CategoryType == 1).ToList();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "Id";
        }
    }
}

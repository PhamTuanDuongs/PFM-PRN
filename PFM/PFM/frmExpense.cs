using PFM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PFM
{
    public partial class frmExpense : Form
    {
        PFMContext context;
        public frmExpense()
        {
            context = new PFMContext();
            InitializeComponent();
        }

        private void frmExpense_Load(object sender, EventArgs e)
        {
            cbCategory.DataSource = context.Categories.Where(x => x.CategoryType == 0).ToList();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "Id";
            cbCategory.SelectedIndex = 0;
            sumExpense();
        }
        private void sumExpense()
        {
            lbltotalExpense.Text = string.Format("{0:#,##}", double.Parse(context.Expenses.Sum(x => x.Amount).ToString()));

        }

        private void txtExpense_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExpense.Text))
            {
                e.Cancel = true;
                txtExpense.Focus();
                validate.SetError(txtExpense, "Name should not be left blank!");
            }
            else if (txtExpense.Text.Length > 150)
            {
                e.Cancel = true;
                txtExpense.Focus();
                validate.SetError(txtExpense, "The length of income name should not be larger than 150 characters");
            }
            else
            {
                e.Cancel = false;
                validate.SetError(txtExpense, "");
            }
        }

        private void nmAmount_Validating(object sender, CancelEventArgs e)
        {

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

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (txtDescription.Text.Length > 250)
            {
                e.Cancel = true;
                txtDescription.Focus();
                validate.SetError(txtDescription, "The length of description should not be larger than 250 characters");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Expense expense = new Expense();
                expense.Name = txtExpense.Text;
                expense.Description = string.IsNullOrEmpty(txtDescription.Text) ? null : txtDescription.Text;
                expense.CreatedAt = DateTime.Parse(dtCreated.Value.ToString());
                expense.Amount = Double.Parse(nmAmount.Value.ToString());
                expense.AccountId = 1;
                expense.CategoryId = Convert.ToInt32(cbCategory.SelectedValue.ToString());
                context.Expenses.Add(expense);
                context.SaveChanges();
                MessageBox.Show("add expense successfully");
                sumExpense();
            }
        }
    }
}

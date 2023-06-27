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

namespace PFM
{
    public partial class frmViewExpense : Form
    {
        public frmViewExpense()
        {
            InitializeComponent();
        }
        private bool isUserSelection = false;
        public void StyleDataGridView()
        {
            dtgExpense.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 10, FontStyle.Bold);
            dtgExpense.EnableHeadersVisualStyles = false;
            dtgExpense.ColumnHeadersDefaultCellStyle.BackColor = Color.BlueViolet;
            dtgExpense.DefaultCellStyle.BackColor = ColorTranslator.FromHtml(ManageColor.hexColor2);
            dtgExpense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgExpense.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void frmViewExpense_Load(object sender, EventArgs e)
        {
            using (PFMContext context = new PFMContext())
            {
                cbCategories.DisplayMember = "CategoryName";
                cbCategories.ValueMember = "id";
                cbCategories.DataSource = context.Categories.Where(x => x.CategoryType == 0).ToList();
                cbCategoryUpdate.DisplayMember = "CategoryName";
                cbCategoryUpdate.ValueMember = "id";
                cbCategoryUpdate.DataSource = context.Categories.Where(x => x.CategoryType == 0).ToList();
                cbCategories.SelectedIndex = -1;
                cbCategoryUpdate.SelectedIndex = -1;
                isUserSelection = false;
            }
            LoadData();
            StyleDataGridView();
            cbFilter.Items.Add("Day");
            cbFilter.Items.Add("Money");
        }

        public void LoadData()
        {
            using (PFMContext context = new PFMContext())
            {
                dtgExpense.DataSource = (from i in context.Expenses
                                         where i.AccountId == LoginInfo.Id && i.Category.CategoryType == 0
                                         select new
                                         {
                                             No = i.Id,
                                             ExpenseName = i.Name,
                                             ExpenseAmount = string.Format("{0:#,##}", double.Parse(i.Amount.ToString())),
                                             ExpenseCategory = i.Category.CategoryName,
                                             ExpenseDate = i.CreatedAt.Date,
                                             ExpenseDescription = i.Description,
                                             ExpenseUser = i.Account.Displayname
                                         }
                                    ).ToList();
            }
        }
        private void txtExpense_KeyUp(object sender, KeyEventArgs e)
        {

            cbCategories.SelectedIndex = -1;
            using (PFMContext context = new PFMContext())
            {
                dtgExpense.DataSource = (from i in context.Expenses
                                         where i.Name.Contains(txtExpenseName.Text)
                                         select new
                                         {
                                             No = i.Id,
                                             ExpenseName = i.Name,
                                             ExpenseAmount = string.Format("{0:#,##}", double.Parse(i.Amount.ToString())),
                                             ExpenseCategory = i.Category.CategoryName,
                                             ExpenseDate = i.CreatedAt.Date,
                                             ExpenseDescription = i.Description,
                                             ExpenseUser = i.Account.Displayname
                                         }
                               ).ToList();
            }
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (PFMContext context = new PFMContext())
            {
                if (isUserSelection && cbCategories.SelectedIndex != -1)
                {
                    txtExpenseName.Text = string.Empty;
                    cbFilter.SelectedIndex = -1;
                    dtgExpense.DataSource = (from i in context.Expenses
                                             where i.Category.CategoryName == cbCategories.Text
                                             select new
                                             {
                                                 No = i.Id,
                                                 ExpenseName = i.Name,
                                                 ExpenseAmount = string.Format("{0:#,##}", double.Parse(i.Amount.ToString())),
                                                 ExpenseCategory = i.Category.CategoryName,
                                                 ExpenseDate = i.CreatedAt.Date,
                                                 ExpenseDescription = i.Description,
                                                 ExpenseUser = i.Account.Displayname
                                             }
                                    ).ToList();
                }
                else
                {
                    isUserSelection = true;
                }
            }
        }

        private void cbCategories_Click(object sender, EventArgs e)
        {
            isUserSelection = true;
        }

        private void btnViewall_Click(object sender, EventArgs e)
        {
            cbCategories.SelectedIndex = -1;
            cbFilter.SelectedIndex = -1;    
            txtExpenseName.Text = string.Empty;
            LoadData();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (PFMContext context = new PFMContext())
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    if (ValidateChildren())
                    {
                        Expense oldExpense = context.Expenses.FirstOrDefault(i => i.Id == Convert.ToInt32(txtID.Text));
                        oldExpense.Name = txtName.Text;
                        oldExpense.Description = txtDescription.Text;
                        oldExpense.CreatedAt = dtCreated.Value;
                        oldExpense.Amount = Double.Parse(nmAmount.Value.ToString());
                        oldExpense.CategoryId = Convert.ToInt32(cbCategoryUpdate.SelectedValue);
                        context.SaveChanges();
                        MessageBox.Show("Update expense successfully");
                        LoadData();
                        Reset();
                    }
                }
                else
                {
                    MessageBox.Show("You must choose a expense to update");
                }
            }
        }

        private void Reset()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            nmAmount.Value = 0;
            cbCategoryUpdate.SelectedIndex = -1;
            dtCreated.Value = DateTime.Now;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (PFMContext context = new PFMContext())
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("You must choose a expense to delete");
                }
                else
                {
                    Expense oldExpense = context.Expenses.FirstOrDefault(i => i.Id == Convert.ToInt32(txtID.Text));
                    context.Expenses.Remove(oldExpense);
                    context.SaveChanges();
                    MessageBox.Show("Delete expense successfully");
                    LoadData();
                    Reset();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dtgExpense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            txtID.Text = dtgExpense.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtName.Text = dtgExpense.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            nmAmount.Text = dtgExpense.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            cbCategoryUpdate.Text = dtgExpense.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            dtCreated.Value = DateTime.Parse(dtgExpense.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
            txtDescription.Text = dtgExpense.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (PFMContext context = new PFMContext())
            {
                if (cbFilter.SelectedIndex == 0)
                {


                    txtExpenseName.Text = string.Empty;
                    cbCategories.SelectedIndex = -1;
                    dtgExpense.DataSource = (from i in context.Expenses
                                             orderby i.CreatedAt.Date ascending
                                            select new
                                            {
                                                No = i.Id,
                                                IncomeName = i.Name,
                                                IncomeAmount = string.Format("{0:#,##}", double.Parse(i.Amount.ToString())),
                                                IncomeCategory = i.Category.CategoryName,
                                                IncomeDate = i.CreatedAt.Date,
                                                IncomeDescription = i.Description,
                                                IncomeUser = i.Account.Displayname
                                            }
                                    ).ToList();
                }
                else
                {
                    txtExpenseName.Text = string.Empty;
                    cbCategories.SelectedIndex = -1;
                    dtgExpense.DataSource = (from i in context.Expenses
                                            orderby i.Amount ascending
                                            select new
                                            {
                                                No = i.Id,
                                                IncomeName = i.Name,
                                                IncomeAmount = string.Format("{0:#,##}", double.Parse(i.Amount.ToString())),
                                                IncomeCategory = i.Category.CategoryName,
                                                IncomeDate = i.CreatedAt.Date,
                                                IncomeDescription = i.Description,
                                                IncomeUser = i.Account.Displayname
                                            }
                                    ).ToList();
                }
            }
        }
    }
}

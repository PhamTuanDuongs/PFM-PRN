using PFM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFM
{
    public partial class frmViewIncome : Form
    {

        public frmViewIncome()
        {

            InitializeComponent();
        }
        private bool isUserSelection = false;
        public void StyleDataGridView()
        {
            dtgIncome.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 10, FontStyle.Bold);
            dtgIncome.EnableHeadersVisualStyles = false;
            dtgIncome.ColumnHeadersDefaultCellStyle.BackColor = Color.BlueViolet;
            dtgIncome.DefaultCellStyle.BackColor = ColorTranslator.FromHtml(ManageColor.hexColor2);
            dtgIncome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgIncome.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public void LoadData()
        {
            using (PFMContext context = new PFMContext())
            {
                dtgIncome.DataSource = (from i in context.Incomes
                                        where i.AccountId == LoginInfo.Id && i.Category.CategoryType == 1
                                        select new
                                        {
                                            No = i.Id,
                                            IncomeName = i.Name,
                                            IncomeAmount = string.Format("{0:#,##}", double.Parse(i.Amount.ToString())),
                                            IncomeCategory = i.Category.CategoryName,
                                            IncomeDate = i.CreatedAt.Date,
                                            IncomeDescription = i.Description,
                                            User = i.Account.Displayname
                                        }
                                        ).ToList();
            }

        }

        private void frmViewIncome_Load(object sender, EventArgs e)
        {
            using (PFMContext context = new PFMContext())
            {
                cbCategories.DisplayMember = "CategoryName";
                cbCategories.ValueMember = "id";
                cbCategories.DataSource = context.Categories.Where(x => x.CategoryType == 1).ToList();
                cbCategoryUpdate.DisplayMember = "CategoryName";
                cbCategoryUpdate.ValueMember = "id";
                cbCategoryUpdate.DataSource = context.Categories.Where(x => x.CategoryType == 1).ToList();
                cbCategories.SelectedIndex = -1;
            }
            isUserSelection = false;
            LoadData();
            StyleDataGridView();
            cbFilter.Items.Add("Day");
            cbFilter.Items.Add("Money");
        }

        private void txtIncomeName_KeyUp(object sender, KeyEventArgs e)
        {
            using (PFMContext context = new PFMContext())
            {
                cbCategories.SelectedIndex = -1;
                dtgIncome.DataSource = (from i in context.Incomes
                                        where i.Name.Contains(txtIncomeName.Text)
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
        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (PFMContext context = new PFMContext())
            {
                if (isUserSelection && cbCategories.SelectedIndex != -1)
                {
                    txtIncomeName.Text = string.Empty;
                    cbFilter.SelectedIndex = -1;
                    dtgIncome.DataSource = (from i in context.Incomes
                                            where i.Category.CategoryName == cbCategories.Text
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
            txtIncomeName.Text = string.Empty;
            LoadData();
        }

        private void dtgIncome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            txtID.Text = dtgIncome.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtName.Text = dtgIncome.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            nmAmount.Text = dtgIncome.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            cbCategoryUpdate.Text = dtgIncome.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            dtCreated.Value = DateTime.Parse(dtgIncome.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
            txtDescription.Text = dtgIncome.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (PFMContext context = new PFMContext())
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    if (ValidateChildren())
                    {
                        Income newIcome = context.Incomes.FirstOrDefault(i => i.Id == Convert.ToInt32(txtID.Text));
                        newIcome.Name = txtName.Text;
                        newIcome.Description = txtDescription.Text;
                        newIcome.CreatedAt = dtCreated.Value;
                        newIcome.Amount = Double.Parse(nmAmount.Value.ToString());
                        newIcome.CategoryId = Convert.ToInt32(cbCategoryUpdate.SelectedValue);
                        context.SaveChanges();
                        MessageBox.Show("Update income successfully");
                        LoadData();
                        Reset();
                    }
                }
                else
                {
                    MessageBox.Show("You must choose a income to update");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (PFMContext context = new PFMContext())
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("You must choose a income to delete");
                }
                else
                {
                    Income oldIcome = context.Incomes.FirstOrDefault(i => i.Id == Convert.ToInt32(txtID.Text));
                    context.Incomes.Remove(oldIcome);
                    context.SaveChanges();
                    MessageBox.Show("Delete income successfully");
                    LoadData();
                    Reset();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
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

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (txtDescription.Text.Length > 250)
            {
                e.Cancel = true;
                txtDescription.Focus();
                validate.SetError(txtDescription, "The length of description should not be larger than 250 characters");
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
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (PFMContext context = new PFMContext())
            {
                if (cbFilter.SelectedIndex == 0)
                {


                    txtIncomeName.Text = string.Empty;
                    cbCategories.SelectedIndex = -1;
                    dtgIncome.DataSource = (from i in context.Incomes
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
                    txtIncomeName.Text = string.Empty;
                    cbCategories.SelectedIndex = -1;
                    dtgIncome.DataSource = (from i in context.Incomes
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

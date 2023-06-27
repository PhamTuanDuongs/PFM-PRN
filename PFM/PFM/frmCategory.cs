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
    public partial class frmCategory : Form
    {
        PFMContext context;
        public frmCategory()
        {
            context = new PFMContext();
            InitializeComponent();
            dtCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtCategory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            rdExpense.Checked = true;
            rdExpense.Checked = false;
        }

        private void LoaddataExpense()
        {
            dtCategory.DataSource = (
                from c in context.Categories
                where c.CategoryType == 0
                select new
                {
                    No = c.Id,
                    c.CategoryName,
                }
                ).ToList();
        }
        private void rdExpense_CheckedChanged(object sender, EventArgs e)
        {
            if (rdExpense.Checked)
            {
                LoaddataExpense();
            }
        }

        private void LoadDataWithCondition()
        {
            if (rdExpense.Checked)
            {
                LoaddataExpense();
            }
            else
            {
                LoaddataIncome();
            }
        }
        private void LoaddataIncome()
        {
            dtCategory.DataSource = (
                from c in context.Categories
                where c.CategoryType == 1
                select new
                {
                    No = c.Id,
                    CategoryName = c.CategoryName,
                }
                ).ToList();
        }
        private void rdIncome_CheckedChanged(object sender, EventArgs e)
        {
            if (rdIncome.Checked)
            {
                LoaddataIncome();
            }
        }

        private void txtCategoryName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                e.Cancel = true;
                txtCategoryName.Focus();
                validate.SetError(txtCategoryName, "Name should not be left blank!");
            }
            else if (txtCategoryName.Text.Length > 150)
            {
                e.Cancel = true;
                txtCategoryName.Focus();
                validate.SetError(txtCategoryName, "The length of income name should not be larger than 150 characters");
            }
            else
            {
                e.Cancel = false;
                validate.SetError(txtCategoryName, "");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                int categoryType;
                if (rdExpense.Checked)
                {
                    categoryType = 0;
                }
                else
                {
                    categoryType = 1;
                }
                string name = txtCategoryName.Text;
                Category checkCategory = context.Categories.FirstOrDefault(x => x.CategoryName.Equals(name));
                if (checkCategory == null)
                {
                    Category category = new Category();
                    category.CategoryName = name;
                    category.CategoryType = categoryType;
                    context.Categories.Add(category);
                    context.SaveChanges();
                    MessageBox.Show("A new category added successfully");
                    LoadDataWithCondition();
                }
                else
                {
                    MessageBox.Show("This category name exits ");
                }
            }
        }


        private void frmViewCategory_Load_1(object sender, EventArgs e)
        {
            rdExpense.Checked = true;
            LoaddataExpense();
        }

        private void dtCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            txtId.Text = dtCategory.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtCategoryName.Text = dtCategory.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text) || string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("You must choose a category to update");
            }
            else
            {
                Category oldCategory = context.Categories.FirstOrDefault(c => c.Id == Convert.ToInt32(txtId.Text));
                if (oldCategory != null)
                {
                    oldCategory.CategoryName = txtCategoryName.Text;
                    context.SaveChanges();
                    MessageBox.Show("Update category successfully");
                    LoadDataWithCondition();
                }
                else
                {
                    MessageBox.Show("This category does not exit to update");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCategoryName.Text) || string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("You must choose a category to delete");
            }
            else
            {
                Category oldCategory = context.Categories.FirstOrDefault(c => c.Id == Convert.ToInt32(txtId.Text));
                context.Categories.Remove(oldCategory);
                context.SaveChanges();
                MessageBox.Show("Delete category successfully");
                txtCategoryName.Text = string.Empty;
                txtId.Text = string.Empty;
                LoadDataWithCondition();
            }
        }
    }
}

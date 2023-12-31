﻿using PFM.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            if (ValidateChildren())
            {
                Income income = new Income();
                income.Name = txtName.Text;
                income.Description = string.IsNullOrEmpty(txtDescription.Text) ? null : txtDescription.Text;
                income.CreatedAt = DateTime.Parse(dtCreated.Value.ToString());
                income.Amount = Double.Parse(nmAmount.Value.ToString());
                income.AccountId = 1;
                income.CategoryId = Convert.ToInt32(cbCategory.SelectedValue.ToString());
                context.Incomes.Add(income);
                context.SaveChanges();
                MessageBox.Show("add income successfully");
                sumIncome();
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
        private void sumIncome()
        {
            lblIncome.Text = string.Format("{0:#,##}", double.Parse(context.Incomes.Sum(x => x.Amount).ToString()));

        }
        private void frmIncome_Load(object sender, EventArgs e)
        {
            cbCategory.DataSource = context.Categories.Where(x => x.CategoryType == 1).ToList();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "Id";
            cbCategory.SelectedIndex = 0;
            sumIncome();
        }
    }
}

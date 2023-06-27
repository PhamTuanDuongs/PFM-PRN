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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            using (PFMContext context = new PFMContext())
            {
                lblITotalncome.Text = string.Format("{0:#,##}", double.Parse(context.Incomes.Where(x => x.AccountId == LoginInfo.Id).Sum(x => x.Amount).ToString())); ;
                lblTotalExpense.Text = string.Format("{0:#,##}", double.Parse(context.Expenses.Where(x => x.AccountId == LoginInfo.Id).Sum(x => x.Amount).ToString()));

                lblTransactionIncome.Text += " " + context.Incomes.Where(x => x.CreatedAt.Date == DateTime.Today.Date && x.AccountId == LoginInfo.Id).Count().ToString();
                lblTransactionExpense.Text += " " + context.Expenses.Where(x => x.CreatedAt.Date == DateTime.Today.Date && x.AccountId == LoginInfo.Id).Count().ToString();


                lblTransactionsIncomeToday.Text = DateTime.Today.ToString("MM/dd/yyyy");
                lblTransactionsExpenseToday.Text = DateTime.Today.ToString("MM/dd/yyyy");

                double maxIncome = context.Incomes.Where(x => x.AccountId == LoginInfo.Id).Max(x => (double?)x.Amount) ?? 0;
                double maxExpenses = context.Expenses.Where(x => x.AccountId == LoginInfo.Id).Max(x => (double?)x.Amount) ?? 0;

                lblMaxIncome.Text = string.Format("{0:#,##}", maxIncome);
                lblMaxExpense.Text = string.Format("{0:#,##}", maxExpenses);

                double minIncome = context.Incomes.Where(x => x.AccountId == LoginInfo.Id).Min(x => (double?)x.Amount) ?? 0;
                double minExpense = context.Expenses.Where(x => x.AccountId == LoginInfo.Id).Min(x => (double?)x.Amount) ?? 0;

                lblMinimumIncome.Text = string.Format("{0:#,##}", minIncome);
                lblMinimumExpense.Text = string.Format("{0:#,##}", minExpense);

                var hasIncomes = context.Incomes.Any(x => x.AccountId == LoginInfo.Id);
                DateTime? lastIncome = hasIncomes ? context.Incomes.Where(x => x.AccountId == LoginInfo.Id).Max(x => x.CreatedAt) : null;
                lblLastIncome.Text = lastIncome == null ? " " : lastIncome?.ToString("MM/dd/yyyy HH:mm tt");

                var hasExpense = context.Expenses.Any(x => x.AccountId == LoginInfo.Id);
                DateTime? lastExpense = hasIncomes ? context.Incomes.Where(x => x.AccountId == LoginInfo.Id).Max(x => x.CreatedAt) : null;
                lblLastExpense.Text = lastExpense == null ? " " : lastExpense?.ToString("MM/dd/yyyy HH:mm tt");
            }
        }
    }
}

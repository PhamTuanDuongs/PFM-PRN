using System;
using System.Collections.Generic;

namespace PFM.Models
{
    public partial class Category
    {
        public Category()
        {
            Budgets = new HashSet<Budget>();
            Expenses = new HashSet<Expense>();
            Incomes = new HashSet<Income>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public int CategoryType { get; set; }

        public virtual ICollection<Budget> Budgets { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public virtual ICollection<Income> Incomes { get; set; }
    }
}

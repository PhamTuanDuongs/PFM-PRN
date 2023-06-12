using System;
using System.Collections.Generic;

namespace PFM.Models
{
    public partial class Budget
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public double Amount { get; set; }

        public virtual Category Category { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace PFM.Models
{
    public partial class Income
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int AccountId { get; set; }
        public int CategoryId { get; set; }
        public string? Name { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Category Category { get; set; } = null!;
    }
}

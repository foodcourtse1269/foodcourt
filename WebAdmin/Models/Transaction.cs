using System;
using System.Collections.Generic;

namespace WebAdmin.Models
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public double Value { get; set; }
        public DateTime InputDate { get; set; }
        public string Status { get; set; }
        public int TransactionTypeId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual TransactionType TransactionType { get; set; }
    }
}

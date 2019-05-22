using System;
using System.Collections.Generic;

namespace WebAdmin.Models
{
    public partial class TransactionType
    {
        public TransactionType()
        {
            Transaction = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}

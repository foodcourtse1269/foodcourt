using System;
using System.Collections.Generic;

namespace WebAdmin.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Order = new HashSet<Order>();
            Transaction = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double MoneyAccount { get; set; }
        public string FullName { get; set; }
        public DateTime? DayOfBirth { get; set; }
        public string Avatar { get; set; }

        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}

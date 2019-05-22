using System;
using System.Collections.Generic;

namespace WebAdmin.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Transaction = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}

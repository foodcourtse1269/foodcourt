using System;
using System.Collections.Generic;

namespace WebAdmin.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderStore = new HashSet<OrderStore>();
        }

        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderStore> OrderStore { get; set; }
    }
}

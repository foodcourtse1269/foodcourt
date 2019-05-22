using System;
using System.Collections.Generic;

namespace WebAdmin.Models
{
    public partial class OrderStore
    {
        public OrderStore()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Status { get; set; }
        public double Coefficient { get; set; }
        public string Notes { get; set; }
        public double TotalPrice { get; set; }

        public virtual Order Order { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}

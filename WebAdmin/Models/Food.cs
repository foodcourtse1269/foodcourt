using System;
using System.Collections.Generic;

namespace WebAdmin.Models
{
    public partial class Food
    {
        public Food()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int? StoreId { get; set; }
        public string ImageFull { get; set; }
        public string Slug { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}

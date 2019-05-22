using System;
using System.Collections.Generic;

namespace WebAdmin.Models
{
    public partial class OrderDetail
    {
        public int FoodId { get; set; }
        public int OrderStoreId { get; set; }
        public double FoodPrice { get; set; }
        public int Quantity { get; set; }

        public virtual Food Food { get; set; }
        public virtual OrderStore OrderStore { get; set; }
    }
}

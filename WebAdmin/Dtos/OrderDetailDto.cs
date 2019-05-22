using System;
using System.Collections.Generic;

namespace WebAdmin.Dtos
{
    public class OrderDetailDto
    {
        public int FoodId { get; set; }
        public int OrderStoreId { get; set; }
        public double FoodPrice { get; set; }
        public int Quantity { get; set; }

    }
}

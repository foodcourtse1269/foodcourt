using System;
using System.Collections.Generic;

namespace WebAdmin.Dtos
{
    public class OrderStoreDto
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Status { get; set; }
        public double Coefficient { get; set; }
        public string Notes { get; set; }
        public double TotalPrice { get; set; }

    }
}

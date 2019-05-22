using System;
using System.Collections.Generic;

namespace WebAdmin.Dtos
{
    public class FoodDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int? StoreId { get; set; }
        public string ImageFull { get; set; }
        public string Slug { get; set; }
        public int CategoryId { get; set; }

    }
}

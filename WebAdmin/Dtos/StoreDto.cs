using System;
using System.Collections.Generic;

namespace WebAdmin.Dtos
{
    public class StoreDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Slug { get; set; }
        public string ImageFull { get; set; }
        public double Coefficient { get; set; }
    }
}

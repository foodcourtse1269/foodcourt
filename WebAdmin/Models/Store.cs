using System;
using System.Collections.Generic;

namespace WebAdmin.Models
{
    public partial class Store
    {
        public Store()
        {
            Food = new HashSet<Food>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Slug { get; set; }
        public string ImageFull { get; set; }
        public double Coefficient { get; set; }

        public virtual ICollection<Food> Food { get; set; }
    }
}

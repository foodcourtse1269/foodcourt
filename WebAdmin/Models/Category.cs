using System;
using System.Collections.Generic;

namespace WebAdmin.Models
{
    public partial class Category
    {
        public Category()
        {
            Food = new HashSet<Food>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Food> Food { get; set; }
    }
}

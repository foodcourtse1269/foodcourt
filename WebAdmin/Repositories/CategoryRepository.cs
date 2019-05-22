using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAdmin.Models;

namespace WebAdmin.Repositories
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(FoodCourtContext dataContext) : base(dataContext)
        {
        }
    }
}

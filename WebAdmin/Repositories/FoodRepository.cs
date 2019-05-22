using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAdmin.Models;

namespace WebAdmin.Repositories
{
    public class FoodRepository : BaseRepository<Food>
    {
        public FoodRepository(FoodCourtContext dataContext) : base(dataContext)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAdmin.Models;

namespace WebAdmin.Repositories
{
    public class StoreRepository : BaseRepository<Store>
    {
        public StoreRepository(FoodCourtContext dataContext) : base(dataContext)
        {
        }
    }
}

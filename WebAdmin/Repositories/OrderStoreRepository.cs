using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAdmin.Models;

namespace WebAdmin.Repositories
{
    public class OrderStoreRepository : BaseRepository<OrderStore>
    {
        public OrderStoreRepository(FoodCourtContext dataContext) : base(dataContext)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAdmin.Models;

namespace WebAdmin.Repositories
{
    public class OrderRepository : BaseRepository<Order>
    {
        public OrderRepository(FoodCourtContext dataContext) : base(dataContext)
        {
        }
    }
}

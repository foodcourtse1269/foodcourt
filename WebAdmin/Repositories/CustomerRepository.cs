using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAdmin.Models;

namespace WebAdmin.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>
    {
        public CustomerRepository(FoodCourtContext dataContext) : base(dataContext)
        {
        }
    }
}

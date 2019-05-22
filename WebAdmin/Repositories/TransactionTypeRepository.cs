using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAdmin.Models;

namespace WebAdmin.Repositories
{
    public class TransactionTypeRepository : BaseRepository<TransactionType>
    {
        public TransactionTypeRepository(FoodCourtContext dataContext) : base(dataContext)
        {
        }
    }
}

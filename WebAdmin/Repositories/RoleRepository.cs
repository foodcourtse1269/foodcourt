using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAdmin.Models;

namespace WebAdmin.Repositories
{
    public class RoleRepository : BaseRepository<Role>
    {
        public RoleRepository(FoodCourtContext dataContext) : base(dataContext)
        {
        }
    }
}

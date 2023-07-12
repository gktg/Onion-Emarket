using Onion_Emarket.Application.Repositories;
using Onion_Emarket.Persistence.Contexts;
using Onion_Emarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_Emarket.Persistence.Repositories
{
    public class UserReadRepository : ReadRepository<User>, IUserReadRepository
    {
        public UserReadRepository(Onion_EmarketDbContext context) : base(context)
        {
        }
    }
}

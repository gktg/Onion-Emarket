using Onion_Emarket.Application.Repositories;
using Onion_Emarket.Domain.Entities;
using Onion_Emarket.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_Emarket.Persistence.Repositories
{
    public class CategoryWriteRepository : WriteRepository<Category>, ICategoryWriteRepository
    {
        public CategoryWriteRepository(Onion_EmarketDbContext context) : base(context)
        {
        }
    }
}

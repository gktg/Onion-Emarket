using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Onion_Emarket.Domain.Entities;
using Onion_Emarket.Domain.Entities.Common;

namespace Onion_Emarket.Persistence.Contexts
{
    public class Onion_EmarketDbContext : DbContext
    {
        public Onion_EmarketDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categorys { get; set; }


    }
}

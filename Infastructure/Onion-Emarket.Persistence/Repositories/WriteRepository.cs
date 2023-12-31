﻿using Microsoft.EntityFrameworkCore;
using Onion_Emarket.Application.Repositories;
using Onion_Emarket.Domain.Entities.Common;
using Onion_Emarket.Persistence.Contexts;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Onion_Emarket.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly Onion_EmarketDbContext _context;

        public WriteRepository(Onion_EmarketDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> datas)
        {
            await Table.AddRangeAsync(datas);
            return true;
        }

        public bool Remove(T model)
        {
            EntityEntry<T> entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;

        }
        public bool RemoveRange(List<T> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }
        
        public async Task<bool> RemoveById(string id)
        {
           T model =  await Table.FirstOrDefaultAsync(data => data.ID == Guid.Parse(id));
            return Remove(model);
        
        }

        public bool Update(T model)
        {
            EntityEntry<T> entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;

        }
        
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }


    }
}

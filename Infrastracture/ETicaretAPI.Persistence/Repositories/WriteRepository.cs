using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities.Common;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly ETicaretAPIDbContext _dbContext;

        public WriteRepository(ETicaretAPIDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public DbSet<T> Table => _dbContext.Set<T>();

        public async Task<bool> AddAsync(T Model)
        {
            EntityEntry<T> entityEntry= await Table.AddAsync(Model);
            return entityEntry.State == EntityState.Added;
        }

        public  async Task<bool> AddRangeAsync(List<T> Model)
        {
            await Table.AddRangeAsync(Model);
            return true; 
        }

        public bool Remove(T Model)
        {
            EntityEntry entityEntry= Table.Remove(Model);
            return entityEntry.State == EntityState.Deleted;
                }

        public async Task<bool> RemoveAsync(string Id)
        {
           T Model = await Table.FirstOrDefaultAsync(data=>data.Id == Guid.Parse(Id));
            return Remove(Model);
        }

        public bool RemoveRange(List<T> Datas)
        {
             Table.RemoveRange(Datas);
            return true;
        }

        public async Task<int> SaveAsync() => await _dbContext.SaveChangesAsync();
        
          
        

        public bool Update(T Model)
        {
          EntityEntry entityEntry = Table.Update(Model);
         return entityEntry.State == EntityState.Modified;
        }
    }
}

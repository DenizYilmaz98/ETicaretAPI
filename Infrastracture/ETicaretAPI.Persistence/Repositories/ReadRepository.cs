using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities.Common;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ETicaretAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ETicaretAPIDbContext _dbcontext;

        public ReadRepository(ETicaretAPIDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public DbSet<T> Table => _dbcontext.Set<T>();

        public IQueryable<T> GetAll() => Table;


        public Task<T> GetByIDAsync(string Id)
        => Table.FirstOrDefaultAsync(p => p.Id == Guid.Parse(Id));


        public async Task<T> GetSingletonAsync(Expression<Func<T, bool>> method)
        => await Table.FirstOrDefaultAsync(method);

        public IQueryable<T> GetWhere(Expression<Func<T,bool>> method) => Table.Where(method);
            
    }
}

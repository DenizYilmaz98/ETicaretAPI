using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IWriteRepository<T> :IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T Model);
        Task<bool> AddRangeAsync(List<T> Model);
        bool Remove(T Model);
        bool RemoveRange(List<T> Datas);
        Task<bool> RemoveAsync(string Id);
        bool Update(T Model);
        Task<int> SaveAsync();





    }
}

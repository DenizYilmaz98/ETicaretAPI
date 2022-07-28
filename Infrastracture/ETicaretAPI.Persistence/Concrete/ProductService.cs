using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Concrete
{
    public class ProductService : IProductServices
    {
        public List<Product> GetProducts() => new()
        {
            new(){ Id=Guid.NewGuid(), Name="Prouct 1", Stock= 10, Price=100, },
            new(){ Id=Guid.NewGuid(), Name="Prouct 2", Stock= 20, Price=110, },
            new(){ Id=Guid.NewGuid(), Name="Prouct 3", Stock= 30, Price=120, },
            new(){ Id=Guid.NewGuid(), Name="Prouct 4", Stock= 40, Price=130, },
            new(){ Id=Guid.NewGuid(), Name="Prouct 5", Stock= 50, Price=140, }


        };
            
        

    }
}

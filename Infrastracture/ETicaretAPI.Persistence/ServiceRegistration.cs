using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Persistence.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        //Uygulama çalıştığın IoC container çalışacak ve burdaki fonksiyon sayesine applicationdaki bu referansa karşılık persistence'daki bu servisi ekleyip çalışacaktır.
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductServices, ProductService>();
        }
    }
}

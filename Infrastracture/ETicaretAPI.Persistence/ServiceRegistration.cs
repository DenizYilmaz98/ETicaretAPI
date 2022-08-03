using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Application.Repositories.CustomerRepo;
using ETicaretAPI.Application.Repositories.OrderRepo;
using ETicaretAPI.Application.Repositories.ProductRepo;
using ETicaretAPI.Persistence.Concrete;
using ETicaretAPI.Persistence.Contexts;
using ETicaretAPI.Persistence.Repositories.CustomerRepo;
using ETicaretAPI.Persistence.Repositories.OrderRepo;
using ETicaretAPI.Persistence.Repositories.ProductRepo;
using Microsoft.EntityFrameworkCore;
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
        //Uygulama çalıştığında IoC container çalışacak ve burdaki fonksiyon sayesine applicationdaki bu referansa karşılık persistence'daki bu servisi ekleyip çalışacaktır.
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString),ServiceLifetime.Singleton);
            services.AddSingleton<ICustomerReadRepository,CustomerReadRepository>();
            services.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddSingleton<IOrderReadRepository, OrderReadRepository>();
            services.AddSingleton<IOrderWriteRepository, OrderWriteRepository>();
            services.AddSingleton<IProductReadRepository, ProductReadRepository>();
            services.AddSingleton<IProductWriteRepository, ProductWriteRepository>();



        }
    }
}

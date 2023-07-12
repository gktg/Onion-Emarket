using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Onion_Emarket.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Onion_Emarket.Application.Repositories;
using Onion_Emarket.Persistence.Repositories;
using Onion_Emarket.Application.Collections.Basket;
using Onion_Emarket.Persistence.Collections.Basket;
using MongoDB.Driver;

namespace Onion_Emarket.Persistence
{
    public static class ServiceRegistration
    {

        public static void AddPersistenceServices(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<Onion_EmarketDbContext>(options => options.UseSqlServer("Data Source=GKTG-PC;Initial Catalog=Onion_Emarket;Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework"), ServiceLifetime.Singleton);
            //services.AddDbContext<Onion_EmarketDbContext>(options => options.UseSqlServer("Data Source=104.248.132.212;Initial Catalog=Onion_Emarket;user id=sa;password=1998gktg1998;MultipleActiveResultSets=True;App=EntityFramework"), ServiceLifetime.Singleton);    


            services.AddSingleton<IUserReadRepository,UserReadRepository>();
            services.AddSingleton<IUserWriteRepository,UserWriteRepository>();
                     
            services.AddSingleton<IProductReadRepository, ProductReadRepository>();
            services.AddSingleton<IProductWriteRepository, ProductWriteRepository>();

            services.AddSingleton<ICategoryReadRepository, CategoryReadRepository>();
            services.AddSingleton<ICategoryWriteRepository, CategoryWriteRepository>();
            services.AddSingleton<IBasketCollection, BasketCollection>();

            services.AddSingleton<IMongoClient>(s => new MongoClient(configuration.GetRequiredSection("MongoDbConnectionStringLocal").Value));


        }
    }
}

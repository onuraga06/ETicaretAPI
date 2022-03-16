﻿using Microsoft.EntityFrameworkCore;
using ETicaretAPI.Application.Abstract;
using ETicaretAPI.Persistence.Concrete;
using Microsoft.Extensions.DependencyInjection;


namespace ETicaretAPI.Persistence
{
    public  static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            //services.AddSingleton<IProductService, ProductServices>();
            services.AddDbContext<ETicaretDbContext>(options => options.UseNpgsql(Configurations.ConnectionString));
           
        }
    }
}

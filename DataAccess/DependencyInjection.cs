using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static  class DependencyInjection
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            //Para base de datos 
            services.AddDbContext<MyDbContext>(options =>
            options.UseSqlServer(
                configuration.
                GetConnectionString("MyApiContext")
                ?? throw new InvalidOperationException("Connection string 'MyApiContext' not found.")
                ));

            //services.AddDbContext<MyDbContext>(options => options.UseInMemoryDatabase("MyDB"));

            services.AddScoped<MyDbContext>();  //services.AddScoped<IMyDbContext, MyDbContext>();

            return services;
        }
    }
}

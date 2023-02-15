using Common.Dtos;
using DBContext;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using Services;
using Services.Interface;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class ServiceCollectionExtentions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();           
            services.AddScoped<IDataService<DetailDto>, DetailService>();
            services.AddScoped<IDataService<ChildDto>,ChildService>();          
            services.AddSingleton<IContext, MyDbContext>();
            services.AddAutoMapper(typeof(MappingProfile));
            return services;
        }
    }
}

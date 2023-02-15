using Microsoft.Extensions.DependencyInjection;
using Repositories.Entities;
using Repositories.Interface;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public static class ServicesRepositoriesCollection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IDataRepository<Child>,ChildRepository>();
            services.AddScoped<IDataRepository<Detail>, DetailRepository>();


            return services;

        }
    }
}

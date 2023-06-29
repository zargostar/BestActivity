using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;

namespace Persistence
{
    public static class InfrastrauctureServiceDI
    {
        public static IServiceCollection AddInfrastrauctureService(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<IActivityRepository, ActivityRepository>();
            services.AddDbContext<ActivityDbContext>(p => p.UseSqlServer(configuration["ActivityDb"]));
            return services;
        }
    }
}
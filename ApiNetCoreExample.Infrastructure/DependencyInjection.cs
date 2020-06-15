using ApiNetCoreExample.Application.Interfaces;
using ApiNetCoreExample.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ApiNetCoreExample.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ITaskRepository, TaskRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}

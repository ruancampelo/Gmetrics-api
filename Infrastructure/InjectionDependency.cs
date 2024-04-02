using Domain.Repositories;
using Infrastructure.Database;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class InjectionDependency
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<GmetricsContext>();
            services.AddScoped(typeof(ILogRepository), typeof(LogRepository));
        }

    }
}

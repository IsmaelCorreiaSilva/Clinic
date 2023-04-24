
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Data.IoC.Configuration
{
    public static class DataBaseConfiguration
    {
        public static void AddDataBaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options=>
            {
                options.UseNpgsql(configuration.GetConnectionString("ConnectionString"));
            });
        }
    }
}

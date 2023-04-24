
using Application.Interfaces;
using Application.Services;
using Domain.Interfaces;
using Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Data.IoC.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            //Repositories
            services.AddScoped<IDoctorRepository, DoctorRepository>();

            //Services
            services.AddScoped<IDoctorService, DoctorService>();

        }
    }
}

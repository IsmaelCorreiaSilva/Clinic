
using Application.Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Data.IoC.Configuration
{
    public static class AutoMapperConfiguration
    {

        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(
                typeof(DoctorProfile),
                typeof(SpecialtyProfile)            
           );
        }
    }
}

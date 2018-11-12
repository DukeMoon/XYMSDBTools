using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using XYMS.MySqlEntityFrameworkRepository;

namespace XYMS.Common.DependencyInjection
{
    public static class BaseDIExtension
    {
        public static void UseBaseServices(this IServiceCollection services)
        {
            services.AddDbContext<AuthDBContext>(
                options => options.UseMySQL(ApplicationConfig.DataBaseConfig.AuthConnectionString),
                ServiceLifetime.Transient);
            services.UseAutoMapper();
            services.UseMateralThreeTierArchitecture();
        }
    }
}

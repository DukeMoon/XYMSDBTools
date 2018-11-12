using Materal.TTA.Common;
using Materal.TTA.MySqlRepository;
using Microsoft.Extensions.DependencyInjection;
using XYMS.MySqlEntityFrameworkRepository;

namespace XYMS.Common.DependencyInjection
{
    public static class MateralThreeTierArchitectureDIExtension
    {
        public static void UseMateralThreeTierArchitecture(this IServiceCollection services)
        {
            services.AddTransient(typeof(IEntityFrameworkRepository<,>), typeof(MySqlEntityFrameworkRepositoryImpl<,>));
            services.AddTransient(typeof(IEntityFrameworkUnitOfWork<AuthDBContext>), typeof(MySqlEntityFrameworkUnitOfWorkImpl<AuthDBContext>));
        }
    }
}

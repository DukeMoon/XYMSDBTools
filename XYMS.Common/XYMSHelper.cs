using Microsoft.Extensions.DependencyInjection;
using System;
using XYMS.Common.DependencyInjection;

namespace XYMS.Common
{
    public class XYMSHelper
    {
        public static IServiceCollection Services;
        public static IServiceProvider ServiceProvider;
        /// <summary>
        /// 注册依赖注入
        /// </summary>
        public static void RegisterCustomerService()
        {
            Services = new ServiceCollection();
            Services.UseBaseServices();
        }
        /// <summary>
        /// Build依赖注入
        /// </summary>
        public static void BuildService()
        {
            ServiceProvider = Services.BuildServiceProvider();
        }
    }
}

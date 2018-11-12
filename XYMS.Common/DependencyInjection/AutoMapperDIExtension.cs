using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Reflection;

namespace XYMS.Common.DependencyInjection
{
    public static class AutoMapperDIExtension
    {
        public static void UseAutoMapper(this IServiceCollection services)
        {
            var automapperAssemblies = new List<Assembly>
            {
                Assembly.Load("XYMS.Auth.ServiceImpl"),
                Assembly.Load("XYMS.Characters.ServiceImpl"),
                Assembly.Load("XYMS.World.ServiceImpl")
            };
            services.AddAutoMapper(automapperAssemblies);
        }
    }
}

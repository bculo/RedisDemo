using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Configurations
{
    public static class ServicesExtension
    {
        public static void InstallConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCors();

            var configList = typeof(IInstaller).Assembly.GetExportedTypes()
                .Where(item => typeof(IInstaller).IsAssignableFrom(item) && !item.IsAbstract && !item.IsInterface)
                .Select(Activator.CreateInstance)
                .Cast<IInstaller>()
                .ToList();

            configList?.ForEach(item => item.Configure(services, configuration));
        }
    }
}

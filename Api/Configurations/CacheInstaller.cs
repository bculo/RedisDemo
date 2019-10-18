using Api.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Configurations
{
    public class CacheInstaller : IInstaller
    {
        public void Configure(IServiceCollection services, IConfiguration configuration)
        {
            RedisOptions cache = configuration.GetSection(nameof(RedisOptions)).Get<RedisOptions>();

            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = cache.Connection;
                options.InstanceName = cache.InstanceName;
            });

            services.Configure<RedisOptions>(configuration.GetSection(nameof(RedisOptions)));
        }
    }
}

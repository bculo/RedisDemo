using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Api.Configurations
{
    public class SwaggerInstaller : IInstaller
    {
        public void Configure(IServiceCollection services, IConfiguration configuration)
        {
            
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo { Title = "Redisapitest", Version = "v1" });
            });
            
        }
    }
}

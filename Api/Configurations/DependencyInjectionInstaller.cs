using Api.Interfaces;
using Api.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Configurations
{
    public class DependencyInjectionInstaller : IInstaller
    {
        public void Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IUserService, UserService>();
        }
    }
}

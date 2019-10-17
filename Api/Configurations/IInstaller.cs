using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Configurations
{
    public interface IInstaller
    {
        void Configure(IServiceCollection services, IConfiguration configuration);
    }
}

using Api.Interfaces;
using Api.Services;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Configurations
{
    public class DependencyInjectionInstaller : IInstaller
    {
        public void Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IUserService, UserService>();

            ConfigureAutoMapperSingletion(services);
        }

        private void ConfigureAutoMapperSingletion(IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}

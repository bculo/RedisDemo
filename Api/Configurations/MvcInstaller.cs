using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Configurations
{
    public class MvcInstaller : IInstaller
    {
        public void Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
        }
    }
}

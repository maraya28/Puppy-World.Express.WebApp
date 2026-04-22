using Microsoft.Extensions.DependencyInjection;
using PuppyWorld.Infrastructure.Persistance;
using PuppyWorld.OutboundPorts;

namespace PuppyWorld.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IExampleRepository, ExampleRepository>();
            return services;
        }
    }
}

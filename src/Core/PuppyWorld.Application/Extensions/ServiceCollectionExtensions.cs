using Microsoft.Extensions.DependencyInjection;
using PuppyWorld.InboundPorts;

namespace PuppyWorld.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IExampleApplication, ExampleApplication>();
            return services;
        }
    }
}

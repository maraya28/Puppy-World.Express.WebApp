using Microsoft.Extensions.DependencyInjection;
using PuppyWorld.Application.Modules.Example;
using PuppyWorld.InboundPorts;
using Refit;

namespace PuppyWorld.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IExampleApplication, ExampleApplication>();
            return services;
        }

        public static IServiceCollection AddWebClients(this IServiceCollection services)
        {
            services.AddRefitClient<IPetExampleClient>()
           .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://localhost:7067"));
            return services;
        }
    }
}

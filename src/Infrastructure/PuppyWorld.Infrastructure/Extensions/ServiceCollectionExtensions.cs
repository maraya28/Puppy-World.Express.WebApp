using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using PuppyWorld.Infrastructure.Persistance;
using PuppyWorld.OutboundPorts;

namespace PuppyWorld.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<PuppyWorldDbContext>(dbContext => dbContext.UseInMemoryDatabase("PetExample"));
            services.AddScoped<IExampleRepository, ExampleRepository>();
            return services;
        }
    }
}
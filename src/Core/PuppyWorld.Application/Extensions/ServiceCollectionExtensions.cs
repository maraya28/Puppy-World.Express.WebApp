using Microsoft.Extensions.DependencyInjection;
using PuppyWorld.InboundPorts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuppyWorld.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IExampleApplicationService, ExampleApplicationService>();
            return services;
        }
    }
}

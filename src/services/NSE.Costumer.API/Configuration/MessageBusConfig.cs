using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NSE.Core.Utils;
using NSE.Costumer.API.Services;
using NSE.MessageBus;

namespace NSE.Costumer.API.Configuration
{
    public static class MessageBusConfig
    {
        public static void AddMessageBusConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMessageBus(configuration.GetMessageQueueConnection("MessageBus"))
                .AddHostedService<RegistroClienteIntegrationHandler>();
        }
    }
}

using FluentValidation.Results;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NSE.Core.Mediator;
using NSE.Costumer.API.Application.Commands;
using NSE.Costumer.API.Application.Events;
using NSE.Costumer.API.Data;
using NSE.Costumer.API.Data.Repository;
using NSE.Costumer.API.Models;
using NSE.Costumer.API.Services;

namespace NSE.Costumer.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services) 
        {
            services.AddScoped<IMediatorHandler, MediatorHandler>();
            services.AddScoped<IRequestHandler<RegistrarClienteCommand, ValidationResult>, ClienteCommandHandler>();

            services.AddScoped<INotificationHandler<ClienteRegistradoEvent>, ClienteEventHandler>();

            services.AddScoped<ClientesContext>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ClientesContext>();

            services.AddHostedService<RegistroClienteIntegrationHandler>();
        }
    }
}

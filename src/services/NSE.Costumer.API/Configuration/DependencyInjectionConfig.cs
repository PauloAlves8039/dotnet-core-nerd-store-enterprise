using Microsoft.Extensions.DependencyInjection;
using NSE.Costumer.API.Data;

namespace NSE.Costumer.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services) 
        {
            services.AddScoped<ClientesContext>();
        }
    }
}

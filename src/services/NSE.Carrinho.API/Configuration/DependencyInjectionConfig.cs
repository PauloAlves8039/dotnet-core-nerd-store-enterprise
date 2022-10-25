using Microsoft.Extensions.DependencyInjection;
using NSE.Carrinho.API.Data;

namespace NSE.Carrinho.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services) 
        {
            services.AddScoped<CarrinhoContext>();
        }
    }
}

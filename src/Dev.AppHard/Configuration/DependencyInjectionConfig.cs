using Dev.AppHard.Extensions;
using Dev.Business.Interfaces;
using Dev.Business.Notification;
using Dev.Business.Services;
using Dev.Data.Context;
using Dev.Data.Repository;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;

namespace Dev.AppHard.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<AppDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();

            services.AddScoped<INotificador, Notificador>(); 
            services.AddScoped<IFornecedorService, FornecedorService>(); 
            services.AddScoped<IProdutoService, ProdutoService>(); 

            return services; 
        }
    }
}

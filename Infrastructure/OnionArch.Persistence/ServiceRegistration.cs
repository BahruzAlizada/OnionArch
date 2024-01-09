using Microsoft.Extensions.DependencyInjection;
using OnionArch.Application.Abstractions;
using OnionArch.Persistence.Concrete;
using OnionArch.Persistence.Contexts;

namespace OnionArch.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistencesServices(this IServiceCollection services)
        {
            services.AddDbContext<Context>();


            services.AddScoped<IProductService, ProductService>();
        }
    }
}

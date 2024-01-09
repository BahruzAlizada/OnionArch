using Microsoft.Extensions.DependencyInjection;
using OnionArch.Application.Repositories;
using OnionArch.Persistence.Contexts;
using OnionArch.Persistence.Repositories;

namespace OnionArch.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistencesServices(this IServiceCollection services)
        {
            services.AddDbContext<Context>();


            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();

            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}

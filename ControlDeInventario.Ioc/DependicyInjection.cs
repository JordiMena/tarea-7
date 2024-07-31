using ControlDelInventario.Domain.Repository;
using ControlDelInventario.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ControlDelInventario.IoC
{
    public static class DependencyInjection
    {
        public static void AddProjectDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProductoRepository, ProductoRepository>();
            // Agrega más servicios según sea necesario
        }
    }
}


using CarsProject.Domain.Interfaces;
using CarsProject.Infrastructure.Repositories;
using CarsProject.Infrastructure.Services;

using Microsoft.Extensions.DependencyInjection;

namespace CarsProject.Infrastructure.Extensions
{
    /// <summary>
    /// Clase de extensión para registrar servicios y repositorios en la colección de servicios.
    /// </summary>
    public static class ServiceCollectionExtension
    {
        #region Public Methods

        /// <summary>
        /// Registra servicios y repositorios en la colección de servicios especificada.
        /// </summary>
        /// <param name="services">La colección de servicios IServiceCollection a la que se añadirán los servicios.</param>
        /// <returns>La misma instancia de IServiceCollection después de que los servicios hayan sido añadidos. Esto permite encadenar múltiples llamadas de registro de servicios.</returns>
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            //servicios
            services.AddTransient<ICarBrandService, CarBrandService>();
            //repositorios
            services.AddTransient<ICarBrandRepository, CarBrandRepository>();

            return services;
        }

        #endregion Public Methods
    }
}
using CarsProject.Domain;
using CarsProject.Domain.Interfaces;
using CarsProject.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CarsProject.Infrastructure.Repositories
{
    /// <summary>
    /// Repositorio para las marcas de autos.
    /// </summary>
    public class CarBrandRepository : ICarBrandRepository
    {
        #region Private Fields

        private readonly ProjectDbContext _projectDbContext;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Constructor de la clase CarBrandRepository.
        /// </summary>
        /// <param name="context">Contexto de la base de datos.</param>
        public CarBrandRepository(ProjectDbContext context)
        {
            _projectDbContext = context;
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// Obtiene la lista de vehículos de una marca.
        /// </summary>
        /// <returns>Una tarea que representa la operación asincrónica. El resultado de la tarea contiene una colección de BrandVehicle.</returns>
        public async Task<IEnumerable<BrandVehicle>> GetBrandVehiclesAsyncRepository()
        {
            var listado = await _projectDbContext.BrandVehicle.ToListAsync();
            return listado;
        }

        #endregion Public Methods
    }
}
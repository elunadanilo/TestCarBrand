using CarsProject.Domain;
using CarsProject.Domain.Interfaces;

namespace CarsProject.Infrastructure.Services
{
    /// <summary>
    /// Servicio para las marcas de autos.
    /// </summary>
    public class CarBrandService : ICarBrandService
    {
        #region Private Fields

        private readonly ICarBrandRepository _carBrandRepository;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Constructor de la clase CarBrandService.
        /// </summary>
        /// <param name="carBrandRepository">Repositorio de marcas de autos.</param>
        public CarBrandService(ICarBrandRepository carBrandRepository)
        {
            _carBrandRepository = carBrandRepository;
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// Obtiene la lista de vehículos de una marca.
        /// </summary>
        /// <returns>Una tarea que representa la operación asincrónica. El resultado de la tarea contiene una colección de BrandVehicle.</returns>
        public async Task<IEnumerable<BrandVehicle>> GetBrandVehiclesAsyncService()
        {
            return await _carBrandRepository.GetBrandVehiclesAsyncRepository();
        }

        /// <summary>
        /// Servicio para agregar un registro de BrandVehicle.
        /// </summary>
        /// <returns>Una tarea que representa la operación de agregado asincrónica</returns>
        public async Task AddBrandService(BrandVehicle brand)
        {
            await _carBrandRepository.AddBrandRepository(brand);
        }

        #endregion Public Methods
    }
}
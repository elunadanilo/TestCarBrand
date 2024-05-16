namespace CarsProject.Domain.Interfaces
{
    /// <summary>
    /// Interfaz para el repositorio de marcas de autos.
    /// </summary>
    public interface ICarBrandRepository
    {
        #region Public Methods
        /// <summary>
        /// Obtiene la lista de vehículos de una marca.
        /// </summary>
        /// <returns>Una tarea que representa la operación asincrónica. El resultado de la tarea contiene una colección de BrandVehicle.</returns>
        Task<IEnumerable<BrandVehicle>> GetBrandVehiclesAsyncRepository();

        #endregion Public Methods
    }
}
﻿namespace CarsProject.Domain.Interfaces
{
    /// <summary>
    /// Interfaz para el servicio de marcas de autos.
    /// </summary>
    public interface ICarBrandService
    {
        #region Public Methods

        /// <summary>
        /// Obtiene la lista de vehículos de una marca.
        /// </summary>
        /// <returns>Una tarea que representa la operación asincrónica. El resultado de la tarea contiene una colección de BrandVehicle.</returns>
        Task<IEnumerable<BrandVehicle>> GetBrandVehiclesAsyncService();

        /// <summary>
        /// Servicio para agregar un registro de BrandVehicle.
        /// </summary>
        /// <returns>Una tarea que representa la operación de agregado asincrónica</returns>
        Task AddBrandService(BrandVehicle brand);

        #endregion Public Methods
    }
}
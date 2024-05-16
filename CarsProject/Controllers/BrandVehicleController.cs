using CarsProject.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarsProject.Controllers
{
    /// <summary>
    /// Controlador para manejar las solicitudes relacionadas con los vehículos de marcas.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class BrandVehicleController : ControllerBase
    {
        #region Private Fields

        private readonly ICarBrandService _service;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Constructor de la clase BrandVehicleController.
        /// </summary>
        /// <param name="service">Servicio de marcas de autos.</param>
        public BrandVehicleController(ICarBrandService service)
        {
            _service = service;
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// Obtiene la lista de vehículos de marcas.
        /// </summary>
        /// <returns>Un IActionResult que contiene la lista de vehículos de marcas.</returns>
        [HttpGet(Name = "GetBrands")]
        public async Task<IActionResult> GetBrands()
        {
            var response = await _service.GetBrandVehiclesAsyncService();
            return Ok(response);
        }

        #endregion Public Methods
    }
}
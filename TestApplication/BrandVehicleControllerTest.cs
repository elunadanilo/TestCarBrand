using CarsProject.Controllers;
using CarsProject.Domain;
using CarsProject.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace TestApplication
{
    public class BrandVehicleControllerTest
    {
        #region Public Methods
        /// <summary>
        /// El propósito de esta prueba es verificar la funcionalidad del método GetBrands() en el controlador BrandVehicleController, asegurando que devuelve correctamente una lista de marcas de vehículos.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task GetBrands_ReturnsOkResult_WithListOfBrandVehicles()
        {
            // Arrange
            // Crear un mock de ICarBrandService. Un mock simula el comportamiento de objetos reales en un entorno controlado.
            var mockService = new Mock<ICarBrandService>();
            // Lista esperada de marcas de vehículos para simular una respuesta del servicio.
            var expectedBrands = new List<BrandVehicle>
            {
                new BrandVehicle { Id = 1, NameBrand = "Mazda"},
                new BrandVehicle { Id = 2, NameBrand = "Ford" },
                new BrandVehicle { Id = 3, NameBrand = "BMW" }
            };

            // Configurar el mock para que devuelva la lista esperada cuando se llame al método GetBrandVehiclesService.
            mockService.Setup(service => service.GetBrandVehiclesAsyncService())
                       .ReturnsAsync(expectedBrands);

            // Crear una instancia del controlador, pasando el objeto mock como dependencia.
            var controller = new BrandVehicleController(mockService.Object);

            // Act
            // Llamar al método del controlador para obtener las marcas.
            var actionResult = await controller.GetBrands();

            // Assert
            // Verificar que el resultado es del tipo OkObjectResult, que indica una respuesta HTTP 200.
            var okResult = Assert.IsType<OkObjectResult>(actionResult);

            // Verificar que el valor contenido en el OkObjectResult es una lista de BrandVehicle.
            var resultBrands = Assert.IsType<List<BrandVehicle>>(okResult.Value);

            // Comprobar que el número de elementos en la lista es 3.
            Assert.Equal(3, resultBrands.Count);

            // Comprobar que el primer elemento de la lista tiene el nombre de marca "Mazda".
            Assert.Equal("Mazda", resultBrands[0].NameBrand);
        }

        #endregion Public Methods
    }
}
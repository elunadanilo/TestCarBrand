using CarsProject.Domain;
using CarsProject.Infrastructure.Context;
using CarsProject.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace TestApplication
{
    /// <summary>
    /// Pruebas unitarias para el repositorio CarBrandRepository.
    /// </summary>
    public class CarBrandRepositoryTests
    {
        #region Public Methods

        /// <summary>
        /// Verifica que el método GetBrandVehiclesAsync del repositorio
        /// devuelve correctamente todas las marcas de vehículos.
        /// </summary>
        [Fact]
        public async Task GetBrandVehiclesRepository_ReturnsAllBrandVehicles()
        {
            // Arrange
            var dbContext = GetDbContext();
            var repo = new CarBrandRepository(dbContext);

            // Agregar algunos datos de prueba
            dbContext.BrandVehicle.Add(new BrandVehicle { Id = 1, NameBrand = "Toyota" });
            dbContext.BrandVehicle.Add(new BrandVehicle { Id = 2, NameBrand = "Mazda" });
            await dbContext.SaveChangesAsync();

            // Act
            var result = await repo.GetBrandVehiclesAsyncRepository();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            Assert.Contains(result, bv => bv.NameBrand == "Toyota");
            Assert.Contains(result, bv => bv.NameBrand == "Mazda");
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Configura y devuelve un contexto de base de datos en memoria para pruebas.
        /// </summary>
        /// <returns>Una instancia de ProjectDbContext configurada para usar una base de datos en memoria.</returns>
        private ProjectDbContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<ProjectDbContext>()
                .UseInMemoryDatabase(databaseName: "InMemoryCarBrandDatabase")
                .Options;
            var dbContext = new ProjectDbContext(options);
            return dbContext;
        }

        #endregion Private Methods
    }
}
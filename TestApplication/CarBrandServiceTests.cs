using CarsProject.Domain;
using CarsProject.Domain.Interfaces;
using CarsProject.Infrastructure.Services;
using global::CarsProject.Domain.Interfaces;
using global::CarsProject.Domain;
using global::CarsProject.Infrastructure.Services;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
namespace TestApplication
{
    namespace CarsProject.Tests
    {
        public class CarBrandServiceTests
        {
            [Fact]
            public async Task GetBrandVehiclesService_ReturnsCorrectData()
            {
                // Arrange
                var mockRepository = new Mock<ICarBrandRepository>();
                var expectedBrands = new List<BrandVehicle>
            {
                new BrandVehicle { Id = 1, NameBrand = "Toyota" },
                new BrandVehicle { Id = 2, NameBrand = "Ford" }
            };

                mockRepository.Setup(repo => repo.GetBrandVehiclesAsyncRepository())
                              .ReturnsAsync(expectedBrands);

                var service = new CarBrandService(mockRepository.Object);

                // Act
                var result = await service.GetBrandVehiclesAsyncService();

                // Assert
                Assert.NotNull(result);
                Assert.Equal(expectedBrands.Count, ((List<BrandVehicle>)result).Count);
                Assert.Equal("Toyota", ((List<BrandVehicle>)result)[0].NameBrand);
            }
        }
    }

}

using AutoMapper;
using CarsProject.Domain;
using CarsProject.Domain.DTO;

namespace CarsProject.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        #region Public Constructors

        public AutomapperProfile()
        {
            CreateMap<BrandVehicle, BrandVehicleDto>();
            CreateMap<BrandVehicleDto, BrandVehicle>();
        }

        #endregion Public Constructors
    }
}
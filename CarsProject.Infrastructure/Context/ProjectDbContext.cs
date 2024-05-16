using CarsProject.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarsProject.Infrastructure.Context
{
    /// <summary>
    /// Contexto de base de datos para el proyecto.
    /// </summary>
    public class ProjectDbContext : DbContext
    {
        #region Public Constructors

        /// <summary>
        /// Constructor de la clase ProjectDbContext.
        /// </summary>
        /// <param name="options">Opciones de configuración para el contexto.</param>
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Conjunto de datos para los vehículos de marca.
        /// </summary>
        public DbSet<BrandVehicle> BrandVehicle { get; set; }

        #endregion Public Properties

        #region Protected Methods

        /// <summary>
        /// Configura el modelo mediante el ModelBuilder.
        /// </summary>
        /// <param name="modelBuilder">Constructor del modelo.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BrandVehicle>().HasData(
                new BrandVehicle { Id = 1, NameBrand = "Toyota" },
                new BrandVehicle { Id = 2, NameBrand = "Mazda" },
                new BrandVehicle { Id = 3, NameBrand = "JAC" },
                new BrandVehicle { Id = 4, NameBrand = "Mitsubishi" },
                new BrandVehicle { Id = 5, NameBrand = "Datsun" }
            );
        }

        #endregion Protected Methods
    }
}
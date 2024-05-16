using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CarsProject.Infrastructure.Migrations
{
    public partial class InitialCreating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BrandVehicle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameBrand = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandVehicle", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BrandVehicle",
                columns: new[] { "Id", "NameBrand" },
                values: new object[,]
                {
                    { 1, "Toyota" },
                    { 2, "Mazda" },
                    { 3, "JAC" },
                    { 4, "Mitsubishi" },
                    { 5, "Datsun" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrandVehicle");
        }
    }
}

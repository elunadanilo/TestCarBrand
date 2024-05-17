using CarsProject.Infrastructure.Context;
using CarsProject.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(Program));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Configuring Entity Framework to use PostgreSQL with Npgsql as database provider
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<ProjectDbContext>(opt =>
{
    opt.UseNpgsql(connectionString);
});
builder.Services.AddServices();

var app = builder.Build();

var mapper = app.Services.GetRequiredService<IMapper>();
mapper.ConfigurationProvider.AssertConfigurationIsValid();

// Performing database migrations at application startup
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetService<ProjectDbContext>();
    context.Database.Migrate();
}

app.UseSwagger();

app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
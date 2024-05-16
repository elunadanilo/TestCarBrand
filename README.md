# CarsProject

Este proyecto es una aplicación backend desarrollada en C# utilizando ASP.NET Core y Entity Framework Core. El objetivo de este proyecto es demostrar habilidades en el desarrollo de aplicaciones backend, la configuración de entornos con Docker Compose y la implementación de pruebas unitarias con XUnit.

## Características

- **Conexión a la Base de Datos:** Configuración de `DbContext` para conectarse a una base de datos PostgreSQL utilizando Entity Framework.
- **Migraciones y Data Seed:** Creación de una migración que genera una tabla llamada `MarcasAutos` y carga datos de prueba.
- **API REST:** Implementación de un controlador para obtener todas las marcas de autos desde la base de datos.
- **Pruebas Unitarias:** Implementación de pruebas unitarias utilizando XUnit y Moq para verificar el funcionamiento del controlador y el repositorio.
- **Docker Compose:** Configuración de un archivo `docker-compose.yml` que configura dos servicios: PostgreSQL y la API REST.

## Prerrequisitos

- .NET SDK 6.0
- Docker y Docker Compose

## Instalación

1. Clona este repositorio:
    ```bash
    git clone https://github.com/elunadanilo/TestCarBrand.git
    cd CarsProject
    ```

2. Construye y ejecuta los contenedores Docker:
    ```bash
    docker-compose up --build
    ```

## Estructura del Proyecto
CarsProject.Domain: Contiene las entidades del dominio.
CarsProject.Infrastructure: Contiene la configuración del contexto de base de datos y los repositorios.
CarsProject: Contiene el controlador y la configuración de la API.
TestApplication: Contiene las pruebas unitarias.

## Dependencias
Este proyecto utiliza las siguientes librerías:

coverlet.collector
coverlet.msbuild
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.InMemory
Microsoft.EntityFrameworkCore.Tools
Microsoft.Extensions.Hosting.Abstractions
Microsoft.NET.Test.Sdk
Microsoft.VisualStudio.Azure.Containers.Tools.Targets
Moq
Npgsql.EntityFrameworkCore.PostgreSQL

## Uso

La aplicación expone un endpoint para obtener todas las marcas de autos. Al ejecutar el comando compose, se debera abrir una pantalla similar a:

![image](https://github.com/elunadanilo/TestCarBrand/assets/60908456/a9e555ce-cd58-46cb-a2f6-0e40f32b337a)

Asimismo la cobertura de las pruebas unitarias actualmente es del 100%

![image](https://github.com/elunadanilo/TestCarBrand/assets/60908456/fd9f4033-d66f-46fb-909e-a532f5d7fec1)


## Ejecucion de reporteria

dotnet test --collect:"XPlat Code Coverage" --settings coverlet.runsettings

El archivo generado en este paso debe ser copiado al directorio raiz para posteriormente generar el reporte web

Generacion del reporte Previo a generar el reporte reportgenerator -reports:"{path_to_your_project}\coverage.opencover.xml" -targetdir:"coveragereport" -reporttypes:Html

Contribuciones
Las contribuciones son bienvenidas. Si deseas contribuir a este proyecto, por favor, abre un issue o envía un pull request.

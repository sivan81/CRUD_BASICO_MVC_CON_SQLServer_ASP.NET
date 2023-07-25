# CRUD BÁSICO MVC CON_SQLServer_ASP.NET

#### Prueba básica de una aplicación Web ASP.NET Core MVC.
- El lenguaje de programación utilizado es C#.
- Base de datos en SQL Server.
- Scaffold DbContext.
- Entity Framework es lo que se utiliza para las vistas en web y ver los procesos.

#### Como ejecutarlo.
- Los datos que he utilizado para crear la base de datos son los siguientes:
   

        CREATE DATABASE MVCCRUD
        USE MVCCRUD
        
        CREATE TABLE Usuarios(
        Id int identity(1,1) primary key,
        Nombre varchar(50),
        Fecha date,
        Clave varchar(50),
        Ciudad varchar(50)
        )
        
        select * from Usuarios

- La línea Scaffold-DbContext que he introducido es la siguiente:


    Scaffold-DbContext "server=DESKTOP-QHVV51P\SQLEXPRESS; database=MVCCRUD; integrated security=true; TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

En la parte del server he metido los datos del servidor que tengo creado en local, pero una línea genérica sería así:
    

    Scaffold-DbContext "server=localhost; database=MVCCRUD; integrated security=true; TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

#### ¿Qué se puede hacer en la aplicación web?
- Create
- Read
- Update
- Delete

## Repositorio de solo lectura

Este repositorio es de solo lectura. No se aceptarán modificaciones directas en el repositorio original. Si deseas contribuir con mejoras o correcciones, por favor, crea una bifurcación (fork) del repositorio y trabaja en tu propia copia. Luego, puedes enviar una solicitud de extracción (pull request) para que se revisen tus cambios. Agradecemos tu interés en el proyecto y tus posibles contribuciones.

using System;
using System.Collections.Generic;

namespace MVC_CRUD_SQLServer_ASPNET.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Clave { get; set; }

    public string? Ciudad { get; set; } // Añado esta línea para Ciudad
}

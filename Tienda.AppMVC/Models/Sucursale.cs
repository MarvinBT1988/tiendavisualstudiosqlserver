using System;
using System.Collections.Generic;

namespace Tienda.AppMVC.Models;

public partial class Sucursale
{
    public int SucursalId { get; set; }

    public string? NombreSucursal { get; set; }

    public string? Ciudad { get; set; }

    public string? TelefonoContacto { get; set; }
}

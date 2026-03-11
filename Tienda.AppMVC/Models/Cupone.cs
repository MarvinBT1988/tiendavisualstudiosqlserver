using System;
using System.Collections.Generic;

namespace Tienda.AppMVC.Models;

public partial class Cupone
{
    public int CuponId { get; set; }

    public string? CodigoCupon { get; set; }

    public int? PorcentajeDescuento { get; set; }

    public DateTime? FechaExpiracion { get; set; }
}

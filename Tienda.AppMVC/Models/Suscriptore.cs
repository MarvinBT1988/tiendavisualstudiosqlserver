using System;
using System.Collections.Generic;

namespace Tienda.AppMVC.Models;

public partial class Suscriptore
{
    public int SuscriptorId { get; set; }

    public string Email { get; set; } = null!;

    public bool? Activo { get; set; }

    public DateOnly? FechaSuscripcion { get; set; }
}

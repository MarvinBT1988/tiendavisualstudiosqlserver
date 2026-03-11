using System;
using System.Collections.Generic;

namespace Tienda.AppMVC.Models;

public partial class LogsActividad
{
    public int LogId { get; set; }

    public string? Mensaje { get; set; }

    public string? Nivel { get; set; }

    public DateTime? FechaHora { get; set; }
}

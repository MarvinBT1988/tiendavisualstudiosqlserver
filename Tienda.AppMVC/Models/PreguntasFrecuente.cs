using System;
using System.Collections.Generic;

namespace Tienda.AppMVC.Models;

public partial class PreguntasFrecuente
{
    public int FaqId { get; set; }

    public string Pregunta { get; set; } = null!;

    public string Respuesta { get; set; } = null!;

    public int? OrdenVisualizacion { get; set; }
}

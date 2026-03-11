using System;
using System.Collections.Generic;

namespace Tienda.AppMVC.Models;

public partial class Configuracione
{
    public int ConfigId { get; set; }

    public string? Clave { get; set; }

    public string? Valor { get; set; }

    public string? Descripcion { get; set; }
}

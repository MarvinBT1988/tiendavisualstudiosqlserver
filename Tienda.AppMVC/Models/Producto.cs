using System;
using System.Collections.Generic;

namespace Tienda.AppMVC.Models;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal Precio { get; set; }

    public int Stock { get; set; }

    public int? CategoriaId { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public virtual Categoria? Categoria { get; set; }
}

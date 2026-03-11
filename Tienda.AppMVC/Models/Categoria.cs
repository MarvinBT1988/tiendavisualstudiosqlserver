using System;
using System.Collections.Generic;

namespace Tienda.AppMVC.Models;

public partial class Categoria
{
    public int CategoriaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

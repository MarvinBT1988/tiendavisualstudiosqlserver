using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tienda.AppMVC.Models;

public partial class Categoria
{
    public int CategoriaId { get; set; }
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 50 caracteres.")]  
    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Comentarios { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

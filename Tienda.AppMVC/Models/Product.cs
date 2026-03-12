using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tienda.AppMVC.Models;

public partial class Product
{
    
    public int ProductoId { get; set; }

    public string Nombre { get; set; } = null!;

    [Required(ErrorMessage = "El precio es obligatorio.")]
    [Range(0.01, 99999999.99, ErrorMessage = "El precio debe ser mayor a cero y no exceder los 8 dígitos enteros.")]
    [RegularExpression(@"^\d{1,8}(\.\d{1,2})?$", ErrorMessage = "El formato debe ser de hasta 8 enteros y máximo 2 decimales.")]
    [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = false)]
    public decimal Precio { get; set; }

    public int Stock { get; set; }

    public int? CategoriaId { get; set; }

    public DateTime? Fecha { get; set; }

    public virtual Categoria? Categoria { get; set; }
}

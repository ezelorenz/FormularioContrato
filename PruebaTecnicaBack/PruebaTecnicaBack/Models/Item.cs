using System;
using System.Collections.Generic;

namespace PruebaTecnicaBack.Models;

public partial class Item
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public decimal? Precio { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}

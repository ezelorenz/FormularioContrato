namespace PruebaTecnicaBack.DTO
{
    public class PedidoDTO
    {
        //CantidadEgresados => Contrato.CantidadEgresados
        public int? CantidadEgresados { get; set; }

        //Articulo => Item.Nombre
        public string? Articulo { get; set; }
        //PrecioUnitario => Item.Precio
        public double? PrecioUnitario { get; set; }

        public double? TotalArticulo => CantidadEgresados * PrecioUnitario;
    }
}

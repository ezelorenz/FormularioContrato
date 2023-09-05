using PruebaTecnicaBack.Models;

namespace PruebaTecnicaBack.DTO
{
    public class ContratoDTO
    {
        public int Id { get; set; }

        public string? CourseCode { get; set; }

        public string? FechaAlta { get; set; }
        public string? ColegioNivel { get; set; }

        public string? ColegioNombre { get; set; }

        public string? ColegioCurso { get; set; }

        public string? ColegioLocalidad { get; set; }

        public virtual ICollection<PedidoDTO> Pedidos { get; set; } = new List<PedidoDTO>();

        public int? CantidadEgresados { get; set; }
        public decimal? Total { get; set; }

        public string? FechaEntrega { get; set; }

    }
}

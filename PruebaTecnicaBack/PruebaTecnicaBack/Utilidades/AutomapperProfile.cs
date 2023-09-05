using AutoMapper;
using PruebaTecnicaBack.DTO;
using PruebaTecnicaBack.Models;

namespace PruebaTecnicaBack.Utilidades
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Contract, ContratoDTO>()
                .ForMember(d => d.FechaAlta,
                    opt => opt.MapFrom(o => o.FechaAlta.ToString("dd/MM/yyyy")))
                .ForMember(d => d.FechaEntrega,
                    opt => opt.MapFrom(o => o.FechaEntrega.ToString("dd/MM/yyyy")));

            CreateMap<Pedido, PedidoDTO>()
                .ForMember(d => d.CantidadEgresados, o => o.MapFrom(src => src.Contract.CantidadEgresados))
                .ForMember(d => d.Articulo, o => o.MapFrom(src => src.Item.Nombre))
                .ForMember(d => d.PrecioUnitario, o => o.MapFrom(src => src.Item.Precio));

        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaBack.DTO;
using PruebaTecnicaBack.Repository.Interfaz;
using System.Diagnostics.Contracts;

namespace PruebaTecnicaBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IContractRepository _pedidoRepository;

        private readonly IMapper _mapper;

        public PedidoController(IContractRepository pedidoRepository, IMapper mapper)
        {
            _mapper = mapper;
            _pedidoRepository = pedidoRepository;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ContratoDTO>>ObtenerPorId(int id)
        {
            var contrato = await _pedidoRepository.ObtenerPorId(id);
            if (contrato == null)
                return NotFound();

            var contratoDto = _mapper.Map<ContratoDTO>(contrato);
            return Ok(contratoDto);
        }
    }
}

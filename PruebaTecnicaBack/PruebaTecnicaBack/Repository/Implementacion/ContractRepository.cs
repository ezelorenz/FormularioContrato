using Microsoft.EntityFrameworkCore;
using PruebaTecnicaBack.Models;
using PruebaTecnicaBack.Repository.Interfaz;

namespace PruebaTecnicaBack.Repository.Implementacion
{
    public class ContractRepository : IContractRepository
    {
        private readonly PruebatecnicaContext _context;
        public ContractRepository(PruebatecnicaContext context)
        {
            _context = context;
        }
        public async Task<Contract> ObtenerPorId(int id)
        {
            var query = await _context.Contracts
                        .Include(p => p.Pedidos)
                            .ThenInclude(i => i.Item).FirstOrDefaultAsync(c => c.Id == id);

            return query;
        }
    }
}

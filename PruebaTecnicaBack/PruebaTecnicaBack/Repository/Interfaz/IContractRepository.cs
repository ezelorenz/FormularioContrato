using PruebaTecnicaBack.Models;

namespace PruebaTecnicaBack.Repository.Interfaz
{
    public interface IContractRepository
    {
        public Task<Contract> ObtenerPorId(int id);
    }
}

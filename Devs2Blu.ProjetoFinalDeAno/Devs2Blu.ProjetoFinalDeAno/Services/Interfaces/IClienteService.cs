using Devs2Blu.ProjetoFinalDeAno.Models.Entities;

namespace Devs2Blu.ProjetoFinalDeAno.Services.Interfaces
{
    public interface IClienteService
    {
        Task<int> Delete(Cliente cliente);
        Task<Cliente> FindById(int id);
        Task<IEnumerable<Cliente>> GetAllClientes(Cliente cliente);
        Task<int> Save(Cliente cliente);
    }
}

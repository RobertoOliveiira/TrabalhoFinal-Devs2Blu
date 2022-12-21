using Devs2Blu.ProjetoFinalDeAno.Models.Entities;
using Devs2Blu.ProjetoFinalDeAno.Repository;
using Devs2Blu.ProjetoFinalDeAno.Services.Interfaces;

namespace Devs2Blu.ProjetoFinalDeAno.Services.Implements
{
    public class ClienteService : IClienteService
    {
        private readonly ClienteRepository _repository;

        public ClienteService(ClienteRepository repository)
        {
            _repository = repository;
        }
        public async Task<int> Delete(Cliente cliente)
        {
            return await _repository.DeleteCliente(cliente);
        }

        public async Task<Cliente> FindById(int id)
        {
            return await _repository.FindByIdCliente(id);
        }

        public async Task<IEnumerable<Cliente>> GetAllClientes(Cliente cliente)
        {
            return await _repository.GetAll();
        }

        public async Task<int> Save(Cliente cliente)
        {
            return await _repository.SaveCliente(cliente);
        }
    }
}

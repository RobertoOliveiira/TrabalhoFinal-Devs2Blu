using Devs2Blu.ProjetoFinalDeAno.Models.Entities;
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
        public Task<int> Delete(Cliente cliente)
        {
            return await _repository.DeleteCliente(cliente);
        }

        public Task<Cliente> FindById(int id)
        {
            return await _repository.FindByIdCliente(id);
        }

        public Task<IEnumerable<Cliente>> GetAllClientes(Cliente cliente)
        {
            return await _repository.GetAll();
        }

        public Task<int> Save(Cliente cliente)
        {
            return await _repository.SaveCliente(cliente);
        }
    }
}

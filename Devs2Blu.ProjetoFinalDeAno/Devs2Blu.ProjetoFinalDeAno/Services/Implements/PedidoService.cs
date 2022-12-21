using Devs2Blu.ProjetoFinalDeAno.Models.Entities;
using Devs2Blu.ProjetoFinalDeAno.Services.Interfaces;
using Devs2Blu.ProjetoFinalDeAno.Repository;

namespace Devs2Blu.ProjetoFinalDeAno.Services.Implements
{
    public class PedidoService : IPedidoService
    {
        private readonly PedidoRepository _repository;

        public PedidoService(PedidoRepository repository)
        {
            _repository = repository;
        }
        public async Task<int> Delete(Pedido pedido)
        {
            return await _repository.DeletePedido(pedido);
        }

        public async Task<Pedido> FindById(int id)
        {
            return await _repository.FindByIdPedido(id);
        }

        public async Task<Pedido> FindByIdCliente(int idCliente)
        {
            return await _repository.FindByIdCliente(idCliente);
        }

        public async Task<Pedido> FindByIdPizza(int idPizza)
        {
            return await _repository.FindByIdPizza(idPizza);
        }

        public async Task<IEnumerable<Pedido>> GetAllPedidos()
        {
            return await _repository.GetAll();
        }

        public async Task<int> Save(Pedido pedido)
        {
            return await _repository.SavePedido(pedido);
        }
    }
}

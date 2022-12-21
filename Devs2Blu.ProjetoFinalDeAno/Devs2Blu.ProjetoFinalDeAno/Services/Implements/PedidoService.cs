using Devs2Blu.ProjetoFinalDeAno.Models.Entities;
using Devs2Blu.ProjetoFinalDeAno.Services.Interfaces;

namespace Devs2Blu.ProjetoFinalDeAno.Services.Implements
{
    public class PedidoService : IPedidoService
    {
        private readonly PedidoRepository _repository;

        public PedidoService(PedidoRepository repository)
        {
            _repository = repository;
        }
        public Task<int> Delete(Pedido pedido)
        {
            return await _repository.DeletePedido(pedido);
        }

        public Task<Pedido> FindById(int id)
        {
            return await _repository.FindByIdPedido(id);
        }

        public Task<Pedido> FindByIdCliente(int idCliente)
        {
            return await _repository.FindByIdCliente(idCliente);
        }

        public Task<Pedido> FindByIdPizza(int idPizza)
        {
            return await _repository.FindByIdPizza(idPizza);
        }

        public Task<IEnumerable<Pedido>> GetAllPedidos()
        {
            return await _repository.GetAll();
        }

        public Task<int> Save(Pedido pedido)
        {
            return await _repository.SavePedido(pedido);
        }
    }
}

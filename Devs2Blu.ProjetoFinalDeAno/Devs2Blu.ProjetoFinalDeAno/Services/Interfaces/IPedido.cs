using Devs2Blu.ProjetoFinalDeAno.Models.Entities;

namespace Devs2Blu.ProjetoFinalDeAno.Services.Interfaces
{
    public interface IPedido
    {
        Task<int> Delete(Pedido pedido);
        Task<Pedido> FindById(int id);
        Task<Pedido> FindByIdCliente(int idCliente);
        Task<Pedido> FindByIdPizza(int idPizza);
        Task<IEnumerable<Pedido>> GetAllPedidos();
        Task<int> Save(Pedido pedido);
    }
}

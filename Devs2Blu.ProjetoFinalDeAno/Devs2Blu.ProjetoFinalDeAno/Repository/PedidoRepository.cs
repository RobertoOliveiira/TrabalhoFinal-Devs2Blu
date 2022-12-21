using Devs2Blu.ProjetoFinalDeAno.Models.Entities;
using Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetoFinalDeAno.Repository
{
    public class PedidoRepository
    {
        private readonly ContextoDatabase _context;

        public PedidoRepository(ContextoDatabase context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Pedido>> GetAll()
        {
            return await _context.Pedido.ToListAsync();
        }

        public async Task<int> SavePedido(Pedido categoria)
        {
            _context.Add(categoria);
            return await _context.SaveChangesAsync();
        }

        internal async Task<int> DeletePedido(Pedido categoria)
        {
            _context.Pedido.Remove(categoria);
            return await _context.SaveChangesAsync();
        }

        internal async Task<Pedido> FindByIdPedido(int id)
        {
            return await _context.Pedido.FindAsync(id);
        }
        internal async Task<Pedido> FindByIdCliente(int idCliente)
        {
            return await _context.Pedido.FindAsync(idCliente);
        }
        internal async Task<Pedido> FindByIdPizza(int idPizza)
        {
            return await _context.Pedido.FindAsync(idPizza);
        }
    }
}

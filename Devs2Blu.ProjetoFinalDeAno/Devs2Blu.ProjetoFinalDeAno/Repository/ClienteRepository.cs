using Devs2Blu.ProjetoFinalDeAno.Models.Entities;
using Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetoFinalDeAno.Repository
{
    public class ClienteRepository
    {
        private readonly ContextoDatabase _context;

        public ClienteRepository(ContextoDatabase context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> GetAll()
        {
            return await _context.Cliente.ToListAsync();
        }

        public async Task<int> SaveCliente(Cliente categoria)
        {
            _context.Add(categoria);
            return await _context.SaveChangesAsync();
        }

        internal async Task<int> DeleteCliente(Cliente categoria)
        {
            _context.Cliente.Remove(categoria);
            return await _context.SaveChangesAsync();
        }

        internal async Task<Cliente> FindByIdCliente(int id)
        {
            return await _context.Cliente.FindAsync(id);
        }
    }
}

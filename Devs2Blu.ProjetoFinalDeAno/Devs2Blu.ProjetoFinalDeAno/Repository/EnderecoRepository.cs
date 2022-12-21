using Devs2Blu.ProjetoFinalDeAno.Models.Entities;
using Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetoFinalDeAno.Repository
{
    public class EnderecoRepository
    {
        private readonly ContextoDatabase _context;

        public EnderecoRepository(ContextoDatabase context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Endereco>> GetAll()
        {
            return await _context.Endereco.ToListAsync();
        }

        public async Task<int> SaveEndereco(Endereco categoria)
        {
            _context.Add(categoria);
            return await _context.SaveChangesAsync();
        }

        internal async Task<int> DeleteEndereco(Endereco categoria)
        {
            _context.Endereco.Remove(categoria);
            return await _context.SaveChangesAsync();
        }

        internal async Task<Endereco> FindByIdEndereco(int id)
        {
            return await _context.Endereco.FindAsync(id);
        }
    }
}

using Devs2Blu.ProjetoFinalDeAno.Models.Entities;
using Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetoFinalDeAno.Repository
{
    public class PizzaRepository
    {
        private readonly ContextoDatabase _context;

        public PizzaRepository(ContextoDatabase context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Pizza>> GetAll()
        {
            return await _context.Pizza.ToListAsync();
        }

        public async Task<int> SavePizza(Pizza categoria)
        {
            _context.Add(categoria);
            return await _context.SaveChangesAsync();
        }

        internal async Task<int> DeletePizza(Pizza categoria)
        {
            _context.Pizza.Remove(categoria);
            return await _context.SaveChangesAsync();
        }

        internal async Task<Pizza> FindByIdPizza(int id)
        {
            return await _context.Pizza.FindAsync(id);
        }
    }
}

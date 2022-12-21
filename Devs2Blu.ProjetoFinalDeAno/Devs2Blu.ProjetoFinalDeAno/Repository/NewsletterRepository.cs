using Devs2Blu.ProjetoFinalDeAno.Models.Entities;
using Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetoFinalDeAno.Repository
{
    public class NewsletterRepository
    {
        private readonly ContextoDatabase _context;

        public NewsletterRepository(ContextoDatabase context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Newsletter>> GetAll()
        {
            return await _context.Newsletter.ToListAsync();
        }

        public async Task<int> SaveNewsletter(Newsletter categoria)
        {
            _context.Add(categoria);
            return await _context.SaveChangesAsync();
        }

        internal async Task<int> DeleteNewsletter(Newsletter categoria)
        {
            _context.Newsletter.Remove(categoria);
            return await _context.SaveChangesAsync();
        }

        internal async Task<Newsletter> FindByIdNewsletter(int id)
        {
            return await _context.Newsletter.FindAsync(id);
        }
        internal async Task<Newsletter> FindByEmail(string email)
        {
            return await _context.Newsletter.FindAsync(email);
        }
    }
}

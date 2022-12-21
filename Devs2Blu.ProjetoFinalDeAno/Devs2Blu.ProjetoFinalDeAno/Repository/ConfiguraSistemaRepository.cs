using Devs2Blu.ProjetoFinalDeAno.Models.Entities;
using Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetoFinalDeAno.Repository
{
    public class ConfiguraSistemaRepository
    {
        private readonly ContextoDatabase _context;

        public ConfiguraSistemaRepository(ContextoDatabase context)
        {
            _context = context;
        }

        public async Task<int> SaveConfiguracaoSistema(ConfiguracaoSistema categoria)
        {
            _context.Add(categoria);
            return await _context.SaveChangesAsync();
        }

        internal async Task<int> DeleteConfiguracaoSistema(ConfiguracaoSistema categoria)
        {
            _context.ConfiguracaoSistema.Remove(categoria);
            return await _context.SaveChangesAsync();
        }

        internal async Task<ConfiguracaoSistema> GetConfiguracaoSistema(int id)
        {
            return await _context.ConfiguracaoSistema.FindAsync(id);
        }
    }
}

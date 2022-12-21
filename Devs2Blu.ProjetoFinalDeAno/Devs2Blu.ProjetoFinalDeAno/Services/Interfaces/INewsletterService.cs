using Devs2Blu.ProjetoFinalDeAno.Models.Entities;

namespace Devs2Blu.ProjetoFinalDeAno.Services.Interfaces
{
    public interface INewsletterService
    {
        Task<int> Delete(Newsletter newsletter);
        Task<Newsletter> FindById(int id);
        Task<Newsletter> FindByEmail(string email);
        Task<IEnumerable<Newsletter>> GetAllNewsletters();
        Task<int> Save(Newsletter newsletter);
    }
}

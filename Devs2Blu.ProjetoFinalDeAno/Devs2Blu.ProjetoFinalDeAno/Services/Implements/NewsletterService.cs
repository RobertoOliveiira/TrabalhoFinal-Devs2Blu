using Devs2Blu.ProjetoFinalDeAno.Models.Entities;
using Devs2Blu.ProjetoFinalDeAno.Services.Interfaces;
using Devs2Blu.ProjetoFinalDeAno.Repository;

namespace Devs2Blu.ProjetoFinalDeAno.Services.Implements
{
    public class NewsletterService : INewsletterService
    {
        private readonly NewsletterRepository _repository;

        public NewsletterService(NewsletterRepository repository)
        {
            _repository = repository;
        }
        public async Task<int> Delete(Newsletter newsletter)
        {
            return await _repository.DeleteNewsletter(newsletter);
        }

        public async Task<Newsletter> FindByEmail(string email)
        {
            return await _repository.FindByEmail(email);
        }

        public async Task<Newsletter> FindById(int id)
        {
            return await _repository.FindByIdNewsletter(id);
        }

        public async Task<IEnumerable<Newsletter>> GetAllNewsletters()
        {
            return await _repository.GetAll();
        }

        public async Task<int> Save(Newsletter newsletter)
        {
            return await _repository.SaveNewsletter(newsletter);
        }
    }
}

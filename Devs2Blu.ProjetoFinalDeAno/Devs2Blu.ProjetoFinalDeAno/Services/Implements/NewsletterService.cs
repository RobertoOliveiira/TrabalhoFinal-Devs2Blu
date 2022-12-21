using Devs2Blu.ProjetoFinalDeAno.Models.Entities;
using Devs2Blu.ProjetoFinalDeAno.Services.Interfaces;

namespace Devs2Blu.ProjetoFinalDeAno.Services.Implements
{
    public class NewsletterService : INewsletterService
    {
        private readonly NewsletterRepository _repository;

        public NewsletterService(NewsletterRepository repository)
        {
            _repository = repository;
        }
        public Task<int> Delete(Newsletter newsletter)
        {
            return await _repository.DeleteCategoria(categoria);
        }

        public Task<Newsletter> FindByEmail(string email)
        {
            return await _repository.FindByEmail(email);
        }

        public Task<Newsletter> FindById(int id)
        {
            return await _repository.FindByIdNewsletter(id);
        }

        public Task<IEnumerable<Newsletter>> GetAllNewsletters()
        {
            return await _repository.GetAll();
        }

        public Task<int> Save(Newsletter newsletter)
        {
            return await _repository.SaveNewsletter(newsletter);
        }
    }
}

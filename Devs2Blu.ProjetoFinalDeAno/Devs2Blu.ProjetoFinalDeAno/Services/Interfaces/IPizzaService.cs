using Devs2Blu.ProjetoFinalDeAno.Models.Entities;

namespace Devs2Blu.ProjetoFinalDeAno.Services.Interfaces
{
    public interface IPizzaService
    {
        Task<int> Delete(Pizza pizza);
        Task<Pizza> FindById(int id);
        Task<IEnumerable<Pizza>> GetAllPizzas();
        Task<int> Save(Pizza pizza);
    }
}

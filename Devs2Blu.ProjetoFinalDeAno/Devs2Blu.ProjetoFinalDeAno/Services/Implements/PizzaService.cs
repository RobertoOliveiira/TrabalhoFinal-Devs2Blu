using Devs2Blu.ProjetoFinalDeAno.Models.Entities;
using Devs2Blu.ProjetoFinalDeAno.Services.Interfaces;
using Devs2Blu.ProjetoFinalDeAno.Repository;

namespace Devs2Blu.ProjetoFinalDeAno.Services.Implements
{
    public class PizzaService : IPizzaService
    {
        private readonly PizzaRepository _repository;

        public PizzaService(PizzaRepository repository)
        {
            _repository = repository;
        }
        public async Task<int> Delete(Pizza pizza)
        {
            return await _repository.DeletePizza(pizza);
        }

        public async Task<Pizza> FindById(int id)
        {
            return await _repository.FindByIdPizza(id);
        }

        public async Task<IEnumerable<Pizza>> GetAllPizzas()
        {
            return await _repository.GetAll();
        }

        public async Task<int> Save(Pizza pizza)
        {
            return await _repository.SavePizza(pizza);
        }
    }
}

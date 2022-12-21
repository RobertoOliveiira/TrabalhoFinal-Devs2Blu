using Devs2Blu.ProjetoFinalDeAno.Models.Entities;
using Devs2Blu.ProjetoFinalDeAno.Services.Interfaces;

namespace Devs2Blu.ProjetoFinalDeAno.Services.Implements
{
    public class PizzaService : IPizzaService
    {
        private readonly PizzaRepository _repository;

        public PizzaService(PizzaRepository repository)
        {
            _repository = repository;
        }
        public Task<int> Delete(Pizza pizza)
        {
            return await _repository.DeletePizza(pizza);
        }

        public Task<Pizza> FindById(int id)
        {
            return await _repository.FindByIdPizza(id);
        }

        public Task<IEnumerable<Pizza>> GetAllPizzas()
        {
            return await _repository.GetAll();
        }

        public Task<int> Save(Pizza pizza)
        {
            return await _repository.SavePizza(pizza);
        }
    }
}

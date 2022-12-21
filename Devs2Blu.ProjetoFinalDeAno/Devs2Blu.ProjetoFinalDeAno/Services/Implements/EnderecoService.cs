using Devs2Blu.ProjetoFinalDeAno.Models.Entities;
using Devs2Blu.ProjetoFinalDeAno.Services.Interfaces;

namespace Devs2Blu.ProjetoFinalDeAno.Services.Implements
{
    public class EnderecoService : IEnderecoService

    {
        private readonly EnderecoRepository _repository;

        public EnderecoService(EnderecoRepository repository)
        {
            _repository = repository;
        }
        public Task<int> Delete(Endereco endereco)
        {
            return await _repository.DeleteEndereco(endereco);
        }

        public Task<Endereco> FindById(int id)
        {
            return await _repository.FindByIdEndereco(id);
        }

        public Task<IEnumerable<Endereco>> GetAllEnderecos()
        {
            return await _repository.GetAll();
        }

        public Task<int> Save(Endereco endereco)
        {
            return await _repository.SaveEndereco(endereco);
        }
    }
}

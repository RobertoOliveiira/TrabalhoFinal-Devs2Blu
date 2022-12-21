using Devs2Blu.ProjetoFinalDeAno.Models.Entities;
using Devs2Blu.ProjetoFinalDeAno.Services.Interfaces;
using Devs2Blu.ProjetoFinalDeAno.Repository;

namespace Devs2Blu.ProjetoFinalDeAno.Services.Implements
{
    public class EnderecoService : IEnderecoService

    {
        private readonly EnderecoRepository _repository;

        public EnderecoService(EnderecoRepository repository)
        {
            _repository = repository;
        }
        public async Task<int> Delete(Endereco endereco)
        {
            return await _repository.DeleteEndereco(endereco);
        }

        public async Task<Endereco> FindById(int id)
        {
            return await _repository.FindByIdEndereco(id);
        }

        public async Task<IEnumerable<Endereco>> GetAllEnderecos()
        {
            return await _repository.GetAll();
        }

        public async Task<int> Save(Endereco endereco)
        {
            return await _repository.SaveEndereco(endereco);
        }
    }
}

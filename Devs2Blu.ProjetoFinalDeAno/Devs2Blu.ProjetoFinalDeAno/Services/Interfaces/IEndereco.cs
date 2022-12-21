using Devs2Blu.ProjetoFinalDeAno.Models.Entities;

namespace Devs2Blu.ProjetoFinalDeAno.Services.Interfaces
{
    public interface IEndereco
    {
        Task<int> Delete(Endereco endereco);
        Task<Endereco> FindById(int id);
        Task<IEnumerable<Endereco>> GetAllEnderecos();
        Task<int> Save(Endereco endereco);
    }
}

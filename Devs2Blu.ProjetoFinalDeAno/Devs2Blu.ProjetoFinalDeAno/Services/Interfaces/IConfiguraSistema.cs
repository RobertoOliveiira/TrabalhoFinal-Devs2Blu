using Devs2Blu.ProjetoFinalDeAno.Models.Entities;

namespace Devs2Blu.ProjetoFinalDeAno.Services.Interfaces
{
    public interface IConfiguraSistema
    {
        Task<int> Delete(ConfiguracaoSistema config);
        Task<ConfiguracaoSistema> GetConfiguraSistema(int id);
        Task<int> Save(ConfiguracaoSistema config);
    }
}

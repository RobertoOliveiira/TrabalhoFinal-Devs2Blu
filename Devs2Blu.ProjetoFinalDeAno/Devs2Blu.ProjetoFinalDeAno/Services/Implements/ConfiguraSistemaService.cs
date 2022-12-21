using Devs2Blu.ProjetoFinalDeAno.Models.Entities;
using Devs2Blu.ProjetoFinalDeAno.Services.Interfaces;
using Devs2Blu.ProjetoFinalDeAno.Repository;

namespace Devs2Blu.ProjetoFinalDeAno.Services.Implements
{
    public class ConfiguraSistemaService : IConfiguraSistema
    {
        private readonly ConfiguraSistemaRepository _repository;

        public ConfiguraSistemaService(ConfiguraSistemaRepository repository)
        {
            _repository = repository;
        }
        public async Task<int> Delete(ConfiguracaoSistema config)
        {
            return await _repository.DeleteConfiguracaoSistema(config);
        }

        public async Task<ConfiguracaoSistema> GetConfiguraSistema(int id)
        {
            return await _repository.GetConfiguracaoSistema(id);
        }

        public async Task<int> Save(ConfiguracaoSistema config)
        {
            return await _repository.SaveConfiguracaoSistema(config);
        }
    }
}

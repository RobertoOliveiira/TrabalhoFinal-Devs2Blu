using Devs2Blu.ProjetoFinalDeAno.Models.Entities;
using Devs2Blu.ProjetoFinalDeAno.Services.Interfaces;

namespace Devs2Blu.ProjetoFinalDeAno.Services.Implements
{
    public class ConfiguraSistemaService : IConfiguraSistema
    {
        private readonly ConfiguraSistemaRepository _repository;

        public ConfiguraSistemaService(ConfiguraSistemaRepository repository)
        {
            _repository = repository;
        }
        public Task<int> Delete(ConfiguracaoSistema config)
        {
            return await _repository.DeleteConfiguracao(config);
        }

        public Task<ConfiguracaoSistema> GetConfiguraSistema(int id)
        {
            return await _repository.GetConfiguraSistema(id);
        }

        public Task<int> Save(ConfiguracaoSistema config)
        {
            return await _repository.SaveConfiguracaoSistema(config);
        }
    }
}

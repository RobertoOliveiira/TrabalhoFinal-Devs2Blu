using Devs2Blu.ProjetoFinalDeAno.Models.Entities;

namespace Devs2Blu.ProjetoFinalDeAno.Models.DTO
{
    public class EnderecoViewModel
    {
        public int id { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string cep { get; set; }

        public Endereco ToEntity()
        {
            return new Endereco
            {
                Id = id,
                Cidade = cidade,
                Bairro = bairro,
                Logradouro = logradouro,
                Numero = numero,
                CEP = cep
            };
        }
    }
}

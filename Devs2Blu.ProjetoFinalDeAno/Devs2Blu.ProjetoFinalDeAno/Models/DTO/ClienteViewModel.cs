using Devs2Blu.ProjetoFinalDeAno.Models.Entities;

namespace Devs2Blu.ProjetoFinalDeAno.Models.DTO
{
    public class ClienteViewModel
    {
        public int id { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public DateTime created_Time { get; set; }
        public int idEndereco { get; set; }

        public Cliente ToEntity()
        {
            return new Cliente
            {   
                Id = id,
                Login = login,
                Senha = senha,
                Nome = nome,
                Telefone = telefone,
                Created_Time = created_Time,
                IdEndereco = idEndereco
            };
        }
    }
}

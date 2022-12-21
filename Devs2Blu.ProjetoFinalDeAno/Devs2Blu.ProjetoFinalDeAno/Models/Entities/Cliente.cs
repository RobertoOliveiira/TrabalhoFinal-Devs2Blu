using System.Globalization;

namespace Devs2Blu.ProjetoFinalDeAno.Models.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime Created_Time { get; set; }
        public int IdEndereco { get; set; }
        public virtual Endereco? Endereco { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Devs2Blu.ProjetoFinalDeAno.Models.Entities
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("id")]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Column("loging")]
        [Display(Name = "Loging")]
        public string Login { get; set; }

        [Column("senha")]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Column("nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("telefone")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Column("dataRegistro")]
        [Display(Name = "Data do Registro")]
        public DateTime CreatedTime { get; set; }

        [Column("idEndereco")]
        [Display(Name = "ID Endereço")]
        public int IdEndereco { get; set; }
        public virtual Endereco? Endereco { get; set; }
    }
}

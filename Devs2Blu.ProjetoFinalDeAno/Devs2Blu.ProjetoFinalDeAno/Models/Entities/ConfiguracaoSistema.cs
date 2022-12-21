using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.ProjetoFinalDeAno.Models.Entities
{
    [Table("configuracaoSistema")]
    public class ConfiguracaoSistema
    {
        [Column("id")]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Column("nomeSite")]
        [Display(Name = "Nome do Site")]
        public string NomeSite { get; set; }

        [Column("contato")]
        [Display(Name = "Contato")]
        public string Contato { get; set; }

        [Column("endereco")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
    }
}

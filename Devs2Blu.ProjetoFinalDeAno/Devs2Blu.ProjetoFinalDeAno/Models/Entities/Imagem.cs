using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Devs2Blu.ProjetoFinalDeAno.Models.Entities
{
    [Table("imagens")]
    public class Imagem
    {
        [Column("id")]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Column("enderecoImagem")]
        [Display(Name = "Endereço Imagem")]
        public string EnderecoImagem { get; set; }

        [Column("idPizza")]
        [Display(Name = "ID Pizza")]
        public int IdPizza { get; set; }

        public virtual Pizza? Pizza { get; set; }

    }
}

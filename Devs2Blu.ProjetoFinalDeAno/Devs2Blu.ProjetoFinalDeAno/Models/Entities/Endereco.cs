using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.ProjetoFinalDeAno.Models.Entities
{
    [Table("endereco")]
    public class Endereco
    {
        [Column("id")]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Column("cidade")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Column("bairro")]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Column("logradouro")]
        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }

        [Column("numero")]
        [Display(Name = "Número")]
        public int Numero { get; set; }

        [Column("cep")]
        [Display(Name = "CEP")]
        public string CEP { get; set; }

    }
}

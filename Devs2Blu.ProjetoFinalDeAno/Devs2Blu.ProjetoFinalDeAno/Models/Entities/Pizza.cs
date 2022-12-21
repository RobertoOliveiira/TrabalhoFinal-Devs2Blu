using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Devs2Blu.ProjetoFinalDeAno.Models.Entities
{
    [Table("pizzas")]
    public class Pizza
    {
        [Column("id")]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Column("tamanho")]
        [Display(Name = "Tamanho")]
        public string Tamanho { get; set; }

        [Column("sabores")]
        [Display(Name = "Sabores")]
        public string Sabores { get; set; }
    }
}

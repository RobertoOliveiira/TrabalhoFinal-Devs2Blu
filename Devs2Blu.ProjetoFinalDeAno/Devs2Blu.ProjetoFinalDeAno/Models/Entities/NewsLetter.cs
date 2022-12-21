using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Devs2Blu.ProjetoFinalDeAno.Models.Entities
{
    [Table("newsletter")]
    public class NewsLetter
    {
        [Column("id")]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Column("nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("email")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Column("status")]
        [Display(Name = "Status")]
        public bool status { get; set; }
    }
}

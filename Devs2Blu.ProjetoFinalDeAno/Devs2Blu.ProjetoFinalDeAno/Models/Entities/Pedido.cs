using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.ProjetoFinalDeAno.Models.Entities
{
    [Table("pedidos")]
    public class Pedido
    {
        [Column("id")]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Column("idCliente")]
        [Display(Name = "ID Cliente")]
        public int IdCliente { get; set; }

        [Column("idPizza")]
        [Display(Name = "ID Pizza")]
        public int IdPizza { get; set; }

        [Column("dataPedido")]
        [Display(Name = "Data do Pedido")]
        public DateTime CreatedTime { get; set; }

        [Column("status")]
        [Display(Name = "Status do Pedido")]
        public string Status { get; set; }

        public virtual Pizza? Pizza { get; set; }
        public virtual Cliente? Cliente { get; set; }
        
    }
}

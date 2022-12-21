namespace Devs2Blu.ProjetoFinalDeAno.Models.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public virtual ICollection<Pizza>? Pizzas { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public DateTime Created_time { get; set; }
        public string Status { get; set; }
    }
}

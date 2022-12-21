namespace Devs2Blu.ProjetoFinalDeAno.Models.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdPizza { get; set; }
        public virtual Pizza? Pizza { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public DateTime Created_time { get; set; }
        public string Status { get; set; }
    }
}

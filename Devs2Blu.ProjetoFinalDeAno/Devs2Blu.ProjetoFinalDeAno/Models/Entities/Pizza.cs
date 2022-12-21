namespace Devs2Blu.ProjetoFinalDeAno.Models.Entities
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Tamanho { get; set; }
        public string Sabores { get; set; }
        public Pedido Pedido { get; set; }
        public int IdPedido { get; set; }
    }
    
}

namespace Devs2Blu.ProjetoFinalDeAno.Models.Entities
{
    public class Imagem
    {
        public int Id { get; set; }
        public string EnderecoImagem { get; set; }
        public int IdPizza { get; set; }
        public virtual Pizza? Pizza { get; set; }

    }
}

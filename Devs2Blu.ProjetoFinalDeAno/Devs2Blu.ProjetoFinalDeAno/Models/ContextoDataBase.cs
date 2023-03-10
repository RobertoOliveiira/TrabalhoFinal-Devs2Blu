using Devs2Blu.ProjetoFinalDeAno.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models
{
    public class ContextoDatabase : DbContext
    {
        public ContextoDatabase(DbContextOptions<ContextoDatabase> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapeamento de Relacionamento
            modelBuilder.Entity<Cliente>()
                .HasOne(p => p.Endereco);

            modelBuilder.Entity<Pedido>()
                .HasOne(pedido => pedido.Cliente)
                .WithMany(cliente => cliente.Pedidos)
                .HasForeignKey(pedido => pedido.IdCliente);
            modelBuilder.Entity<Pedido>()
                .HasMany(pedido => pedido.Pizzas)
                .WithOne(pizza => pizza.Pedido)
                .HasForeignKey(pedido => pedido.IdPedido);

            // Seed
           /* modelBuilder.Entity<Categoria>()
                .HasData(
                new { Id = 1, Nome = "Alimentos Não Perecíveis" },
                new { Id = 2, Nome = "Laticínios" },
                new { Id = 3, Nome = "Limpeza" },
                new { Id = 4, Nome = "Bebidas Não Alcoólicas" }
                );

            modelBuilder.Entity<Produto>()
                .HasData(
                new { Id = 1, Nome = "Arroz Tio Urbano", Preco = 10.00, Quantidade = 5, CategoriaId = 1 },
                new { Id = 2, Nome = "Feijão Tio Urbano", Preco = 10.00, Quantidade = 5, CategoriaId = 1 },
                new { Id = 3, Nome = "Queijo", Preco = 20.00, Quantidade = 5, CategoriaId = 2 },
                new { Id = 4, Nome = "Iogurte", Preco = 20.00, Quantidade = 5, CategoriaId = 2 },
                new { Id = 5, Nome = "Sabão Líquido", Preco = 30.00, Quantidade = 5, CategoriaId = 3 },
                new { Id = 6, Nome = "Multiuso", Preco = 30.00, Quantidade = 5, CategoriaId = 3 },
                new { Id = 7, Nome = "Suco de Laranja 1L", Preco = 40.00, Quantidade = 5, CategoriaId = 4 },
                new { Id = 8, Nome = "Coca-cola 2L", Preco = 40.00, Quantidade = 5, CategoriaId = 4 }
                );*/

            base.OnModelCreating(modelBuilder);
        }

        #region DbSets
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ConfiguracaoSistema> ConfiguracaoSistema { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Newsletter> Newsletter { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Pizza> Pizza { get; set; }

        #endregion
    }
}

using Microsoft.EntityFrameworkCore;

namespace ExemploController.Data
{
    public class ExemploContext : DbContext
    {
        public ExemploContext(DbContextOptions<ExemploContext> options) : base(options)
        {
        }
        public DbSet<Models.Produto> Produtos { get; set; }
        public DbSet<Models.Cliente> Clientes { get; set; }
        public DbSet<Models.Venda> Venda { get; set; }

    }
}

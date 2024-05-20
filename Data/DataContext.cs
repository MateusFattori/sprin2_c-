using nextia_sprint2.Models;
using Microsoft.EntityFrameworkCore;


namespace nextia_sprint2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Cliente> MVC_Clientes { get; set; }

        public DbSet<Produto> MVC_Produtos { get; set; }

        public DbSet<Promocao> MVC_Promocoes { get; set; }
    }
    
}

using Microsoft.EntityFrameworkCore;

namespace PC3.Models
{
    public class BuscarContext : DbContext
    {
        public DbSet <Producto> Productos {get;set; }
        public DbSet <Categoria> Categorias {get;set; }

        public BuscarContext(DbContextOptions dco) : base(dco) {}
    }
}
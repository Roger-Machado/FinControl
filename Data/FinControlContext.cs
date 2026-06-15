using Microsoft.EntityFrameworkCore;
using FinControl.Models;

namespace FinControl.Data
{
    public class FinControlContext : DbContext
    {
        public FinControlContext(DbContextOptions<FinControlContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Receita> Receitas { get; set; }

        public DbSet<Despesa> Despesas { get; set; }

        public DbSet<Cartao> Cartoes { get; set; }

        public DbSet<Meta> Metas { get; set; }
    }
}
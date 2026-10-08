using Microsoft.EntityFrameworkCore;
using PucPocV1.Models;

namespace PucPocV1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        // REPRESENTA AS TABELAS/ENTIDADES QUE O FRAMEWORK VAI CRIAR E GERENCIAR
        public DbSet<Usuario> Usuarios { get; set; } = null!;
    }

    
}

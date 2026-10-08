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

        public DbSet<NivelAcesso> NiveisAcesso { get; set; } = null!;

        // CONFIGURANDO NIVEIS DE ACESSO, INSERINDO DADOS NA TABEL DE NIVEL DE ACESSO
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ADD DADOS INICIAIS (MENTOR, MENTORADO E ADMINISTRADOR
            // CONFIGURANDO A ENTIDADE NivelAcesso
            modelBuilder.Entity<NivelAcesso>().HasData(
                new NivelAcesso { ID = 1, Descricao = "Mentorado" },
                new NivelAcesso { ID = 2, Descricao = "Mentor" },
                new NivelAcesso { ID = 3, Descricao = "Administrador" });
        }
    }

    
}

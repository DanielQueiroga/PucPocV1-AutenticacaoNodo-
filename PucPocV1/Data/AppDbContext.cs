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

        public DbSet<Mentor> Mentores { get; set; } = null!;

        public DbSet<Mentorado> Mentorados { get; set; } = null!;

        public DbSet<AreaConhecimento> AreasConhecimento { get; set; } = null!;

        public DbSet<Tecnologia> Tecnologias { get; set; } = null!;

        public DbSet<MentorAreaConhecimento> MentorAreasConhecimento { get; set; } = null!;

        public DbSet<MentorTecnologia> MentorTecnologias { get; set; } = null!;

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // AREA DE CONHECIMENTOS INICIAIS
            modelBuilder.Entity<AreaConhecimento>().HasData(
                new AreaConhecimento { ID = 1, Nome = "Desenvolvimento Web" },
                new AreaConhecimento { ID = 2, Nome = "Banco de Dados" },
                new AreaConhecimento { ID = 3, Nome = "Desenvolvimento Mobile" },
                new AreaConhecimento { ID = 4, Nome = "Inteligência Artificial" },
                new AreaConhecimento { ID = 5, Nome = "Segurança da Informação" }
                );

            // TECNOLOGIAS INICIAIS

            modelBuilder.Entity<Tecnologia>().HasData(
                new Tecnologia { ID = 1, Nome = "C#" },
                new Tecnologia { ID = 2, Nome = "Java" },
                new Tecnologia { ID = 3, Nome = "JavaScript" },
                new Tecnologia { ID = 4, Nome = "Python" },
                new Tecnologia { ID = 5, Nome = "SQL Server" },
                new Tecnologia { ID = 6, Nome = "ASP.NET Core" },
                new Tecnologia { ID = 7, Nome = "React" }
                );
        }


    }

    
}

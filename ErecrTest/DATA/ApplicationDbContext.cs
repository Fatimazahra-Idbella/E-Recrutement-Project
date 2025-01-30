using ErecrTest.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

namespace ErecrTest.DATA
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Recruteur> Recruteurs { get; set; }
        public DbSet<Offre> Offres { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recruteur>()
                .HasData(
                new Recruteur
                {
                    Id = 1,
                    Nom = "venus",
                    Tel = "123456789",
                    Email = "fatiezzahra@gmail.com",
                },
                new Recruteur
                {
                    Id = 2,
                    Nom = "Mr Somebody",
                    Tel = "987654321",
                    Email = "mrsomebody@gmail.com",
                });
            modelBuilder.Entity<Offre>()
                .HasData(
            new Offre { Id = 1 , TypeContrat = "CDI", Secteur = "IT", Profil = "Engineer", Poste = "Software Developer", Remuneration = 50000 },
            new Offre {  Id = 2 , TypeContrat = "CDD", Secteur = "Finance", Profil = "Master", Poste = "Financial Analyst", Remuneration = 40000 },
            new Offre { Id = 3 ,  TypeContrat = "CDI", Secteur = "Marketing", Profil = "Licence", Poste = "Marketing Manager", Remuneration = 45000 },
            new Offre { Id = 4 ,  TypeContrat = "CDD", Secteur = "HR", Profil = "Master", Poste = "HR Specialist", Remuneration = 42000 },
            new Offre { Id = 5 , TypeContrat = "CDI", Secteur = "Engineering", Profil = "Engineer", Poste = "Mechanical Engineer", Remuneration = 55000 }
            );
  


        }
        public DbSet<ErecrTest.Models.Candidat> Candidat { get; set; } = default!;
        public IEnumerable<object> Candidatures { get; internal set; }
    }
}







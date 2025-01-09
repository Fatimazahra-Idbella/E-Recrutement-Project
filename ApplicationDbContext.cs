using ErecrTest.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

namespace ErecrTest.DATA
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<Offre> Offres { get; set; }
        public DbSet<Recruteur> Recruteurs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recruteur>()
                .HasData(
                new Recruteur
                {
                    Id = 1,
                    Email = "recruteur1@example.com",
                    Nom = "Recruteur 1",
                    Tel = "123456789"
                },
                new Recruteur
                {
                    Id = 2,
                    Email = "recruteur2@example.com",
                    Nom = "Recruteur 2",
                    Tel = "987654321"
                });

            modelBuilder.Entity<Offre>()
                .HasData(
                new Offre
                {
                    Id = 1,
                    RecruteurId = 1,
                    TypeContrat = "CDI",
                    Secteur = "Informatique",
                    Profil = "Développeur",
                    Poste = "Développeur Fullstack",
                    Remuneration = 40000
                },
                new Offre
                {
                    Id = 2,
                    RecruteurId = 2,
                    TypeContrat = "CDD",
                    Secteur = "Informatique",
                    Profil = "Développeur",
                    Poste = "Développeur Frontend",
                    Remuneration = 30000
                });

            modelBuilder.Entity<Offre>()
                .HasOne(o => o.Recruteur)
                .WithMany(r => r.Offres)
                .HasForeignKey(o => o.RecruteurId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

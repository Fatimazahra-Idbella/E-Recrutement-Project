using ErecrTest.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
namespace ErecrTest.DATA
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Recruteur> Recruteurs { get; set; }
        public DbSet<Offre> Offres { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
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
            
  


        }
        public DbSet<ErecrTest.Models.Candidat> Candidat { get; set; } = default!;
        public IEnumerable<object> Candidatures { get; internal set; }
    }
}







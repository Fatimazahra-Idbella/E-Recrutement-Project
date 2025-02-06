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
        public DbSet<Candidature> Candidatures { get; set; }
        public DbSet<Candidat> Candidats { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One-to-Many relationship between Offer and Recruiter
            modelBuilder.Entity<Offre>()
                .HasOne(o => o.Recruteur)
                .WithMany(r => r.Offres)
                .HasForeignKey(o => o.RecruteurId)
                .OnDelete(DeleteBehavior.Cascade);

            // One-to-Many relationship between Application and Candidate
            modelBuilder.Entity<Candidature>()
                .HasOne(p => p.Candidat)
                .WithMany(c => c.Candidatures)
                .HasForeignKey(p => p.CandidatId)
                .OnDelete(DeleteBehavior.Restrict);

            // One-to-Many relationship between Application and Offer
            modelBuilder.Entity<Candidature>()
                .HasOne(p => p.Offre)
                .WithMany(o => o.Candidatures)
                .HasForeignKey(p => p.OffreId)
                .OnDelete(DeleteBehavior.Cascade);

            // Index to optimize search queries
            modelBuilder.Entity<Candidat>()
                .HasIndex(c => c.Nom);
            base.OnModelCreating(modelBuilder);

            // Seed data for offers
            modelBuilder.Entity<Offre>().HasData(
                new Offre { OffreId = 1, RecruteurId = 1, Poste = "GIS Data Analyst", Profil = "Engineer", Remuneration = 20500, Secteur = "Public", TypeContrat = "Permanent" },
                new Offre { OffreId = 2, RecruteurId = 2, Poste = "Software Engineer", Profil = "Engineer + 3 years of experience", Remuneration = 21500, Secteur = "Private", TypeContrat = "Permanent" },
                new Offre { OffreId = 3, RecruteurId = 8, Poste = "Machine Learning Engineer", Profil = "Engineer", Remuneration = 22000, Secteur = "Private", TypeContrat = "Permanent" },
                new Offre { OffreId = 4, RecruteurId = 3, Poste = "Civil Engineer", Profil = "Engineer", Remuneration = 10500, Secteur = "Private", TypeContrat = "Permanent" },
                new Offre { OffreId = 5, RecruteurId = 4, Poste = "Electrical Engineer", Profil = "Engineer", Remuneration = 15500, Secteur = "Private", TypeContrat = "Permanent" },
                new Offre { OffreId = 6, RecruteurId = 1, Poste = "Geomatician Surveyor", Profil = "Master in GIS", Remuneration = 10000, Secteur = "Public", TypeContrat = "Permanent" },
                new Offre { OffreId = 7, RecruteurId = 5, Poste = "Social Media Manager", Profil = "Bachelor + 3 years of experience", Remuneration = 8000, Secteur = "Private", TypeContrat = "Permanent" },
                new Offre { OffreId = 8, RecruteurId = 6, Poste = "Highschool English Teacher", Profil = "Bachelor in English", Remuneration = 6000, Secteur = "Private", TypeContrat = "Permanent" },
                new Offre { OffreId = 9, RecruteurId = 7, Poste = "Web Designer", Profil = "Bachelor in Web Design", Remuneration = 8000, Secteur = "Private", TypeContrat = "Temporary" }
            );

            // Seed data for recruiters
            modelBuilder.Entity<Recruteur>().HasData(
                new Recruteur { RecruteurId = 1, Email = "khalid.elidrissi.auc@gmail.com", Nom = "Khalid El Idrissi", Tel = "0788912500" },
                new Recruteur { RecruteurId = 2, Email = "sara.bensaid.maroctelecom@gmail.com", Nom = "Sara Bensaid", Tel = "0633597601" },
                new Recruteur { RecruteurId = 8, Email = "rachid.alaoui.um6p@gmail.com", Nom = "Rachid Alaoui", Tel = "0781659872" },
                new Recruteur { RecruteurId = 3, Email = "hassan.amrani.tgcc@gmail.com", Nom = "Hassan Amrani", Tel = "0635954768" },
                new Recruteur { RecruteurId = 4, Email = "nadia.tazi.onee@gmail.com", Nom = "Nadia Tazi", Tel = "0622062209" },
                new Recruteur { RecruteurId = 5, Email = "mehdi.benjelloun.sopriam@gmail.com", Nom = "Mehdi Benjelloun", Tel = "0694587512" },
                new Recruteur { RecruteurId = 6, Email = "amina.ouhibi.lyautey@gmail.com", Nom = "Amina Ouhibi", Tel = "0621548781" },
                new Recruteur { RecruteurId = 7, Email = "youssef.elfassi.digismart@gmail.com", Nom = "Youssef Elfassi", Tel = "0643957159" }
            );

            // Seed data for candidates
            modelBuilder.Entity<Candidat>().HasData(
                new Candidat { CandidatId = 1, Nom = "Ahmed", Prenom = "Benhami", Age = 25, Titre = "Software Engineer", Diplome = "Engineering degree in Computer Science", AnneeExperience = 4, CV = "ahmed_benhami_cv.pdf" },
                new Candidat { CandidatId = 2, Nom = "Leila", Prenom = "Mouhssine", Age = 28, Titre = "Surveyor", Diplome = "Master in GIS", AnneeExperience = 5, CV = "leila_mouhssine_cv.pdf" },
                new Candidat { CandidatId = 3, Nom = "Omar", Prenom = "Berrada", Age = 32, Titre = "Civil Engineer", Diplome = "Engineering degree in Civil Engineering", AnneeExperience = 8, CV = "omar_berrada_cv.pdf" },
                new Candidat { CandidatId = 4, Nom = "Fatima", Prenom = "Zahra", Age = 24, Titre = "Graphic Designer", Diplome = "Bachelor in Web Design", AnneeExperience = 3, CV = "fatima_zahra_cv.pdf" },
                new Candidat { CandidatId = 5, Nom = "Mariam", Prenom = "Alaoui", Age = 26, Titre = "Graphic Designer", Diplome = "Bachelor in Web Design", AnneeExperience = 5, CV = "mariam_alaoui_cv.pdf" }
            );

            // Seed data for applications
            modelBuilder.Entity<Candidature>().HasData(
                new Candidature { CandidatureId = 1, CandidatId = 1, OffreId = 2, DatePostulation = new DateTime(2025, 1, 15), State = "Pending" },
                new Candidature { CandidatureId = 2, CandidatId = 2, OffreId = 6, DatePostulation = new DateTime(2025, 1, 20), State = "Pending" },
                new Candidature { CandidatureId = 3, CandidatId = 3, OffreId = 4, DatePostulation = new DateTime(2025, 1, 18), State = "Accepted" },
                new Candidature { CandidatureId = 4, CandidatId = 4, OffreId = 9, DatePostulation = new DateTime(2025, 1, 22), State = "Rejected" },
                new Candidature { CandidatureId = 5, CandidatId = 5, OffreId = 9, DatePostulation = new DateTime(2025, 1, 21), State = "Accepted" }
            );




        }
        public DbSet<ErecrTest.Models.Candidat> Candidat { get; set; } = default!;
        
    }
}







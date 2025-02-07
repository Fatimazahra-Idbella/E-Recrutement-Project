﻿// <auto-generated />
using System;
using ErecrTest.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ErecrTest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250207160558_addDataOffre")]
    partial class addDataOffre
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ErecrTest.Models.Candidat", b =>
                {
                    b.Property<int>("CandidatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CandidatId"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("AnneeExperience")
                        .HasColumnType("int");

                    b.Property<string>("CV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diplome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CandidatId");

                    b.HasIndex("Nom");

                    b.ToTable("Candidat");

                    b.HasData(
                        new
                        {
                            CandidatId = 1,
                            Age = 25,
                            AnneeExperience = 4,
                            CV = "ahmed_benhami_cv.pdf",
                            Diplome = "Engineering degree in Computer Science",
                            Nom = "Ahmed",
                            Prenom = "Benhami",
                            Titre = "Software Engineer"
                        },
                        new
                        {
                            CandidatId = 2,
                            Age = 28,
                            AnneeExperience = 5,
                            CV = "leila_mouhssine_cv.pdf",
                            Diplome = "Master in GIS",
                            Nom = "Leila",
                            Prenom = "Mouhssine",
                            Titre = "Surveyor"
                        },
                        new
                        {
                            CandidatId = 3,
                            Age = 32,
                            AnneeExperience = 8,
                            CV = "omar_berrada_cv.pdf",
                            Diplome = "Engineering degree in Civil Engineering",
                            Nom = "Omar",
                            Prenom = "Berrada",
                            Titre = "Civil Engineer"
                        },
                        new
                        {
                            CandidatId = 4,
                            Age = 24,
                            AnneeExperience = 3,
                            CV = "fatima_zahra_cv.pdf",
                            Diplome = "Bachelor in Web Design",
                            Nom = "Fatima",
                            Prenom = "Zahra",
                            Titre = "Graphic Designer"
                        },
                        new
                        {
                            CandidatId = 5,
                            Age = 26,
                            AnneeExperience = 5,
                            CV = "mariam_alaoui_cv.pdf",
                            Diplome = "Bachelor in Web Design",
                            Nom = "Mariam",
                            Prenom = "Alaoui",
                            Titre = "Graphic Designer"
                        });
                });

            modelBuilder.Entity("ErecrTest.Models.Candidature", b =>
                {
                    b.Property<int>("CandidatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CandidatureId"));

                    b.Property<int>("CandidatId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePostulation")
                        .HasColumnType("datetime2");

                    b.Property<int>("OffreId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CandidatureId");

                    b.HasIndex("CandidatId");

                    b.HasIndex("OffreId");

                    b.ToTable("Candidatures");

                    b.HasData(
                        new
                        {
                            CandidatureId = 1,
                            CandidatId = 1,
                            DatePostulation = new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OffreId = 2,
                            State = "Pending"
                        },
                        new
                        {
                            CandidatureId = 2,
                            CandidatId = 2,
                            DatePostulation = new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OffreId = 6,
                            State = "Pending"
                        },
                        new
                        {
                            CandidatureId = 3,
                            CandidatId = 3,
                            DatePostulation = new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OffreId = 4,
                            State = "Accepted"
                        },
                        new
                        {
                            CandidatureId = 4,
                            CandidatId = 4,
                            DatePostulation = new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OffreId = 9,
                            State = "Rejected"
                        },
                        new
                        {
                            CandidatureId = 5,
                            CandidatId = 5,
                            DatePostulation = new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OffreId = 9,
                            State = "Accepted"
                        });
                });

            modelBuilder.Entity("ErecrTest.Models.Offre", b =>
                {
                    b.Property<int>("OffreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OffreId"));

                    b.Property<string>("Poste")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecruteurId")
                        .HasColumnType("int");

                    b.Property<decimal>("Remuneration")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Secteur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeContrat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OffreId");

                    b.HasIndex("RecruteurId");

                    b.ToTable("Offres");

                    b.HasData(
                        new
                        {
                            OffreId = 1,
                            Poste = "GIS Data Analyst",
                            Profil = "Engineer",
                            RecruteurId = 1,
                            Remuneration = 20500m,
                            Secteur = "Public",
                            TypeContrat = "Permanent"
                        },
                        new
                        {
                            OffreId = 2,
                            Poste = "Software Engineer",
                            Profil = "Engineer + 3 years of experience",
                            RecruteurId = 2,
                            Remuneration = 21500m,
                            Secteur = "Private",
                            TypeContrat = "Permanent"
                        },
                        new
                        {
                            OffreId = 3,
                            Poste = "Machine Learning Engineer",
                            Profil = "Engineer",
                            RecruteurId = 8,
                            Remuneration = 22000m,
                            Secteur = "Private",
                            TypeContrat = "Permanent"
                        },
                        new
                        {
                            OffreId = 4,
                            Poste = "Civil Engineer",
                            Profil = "Engineer",
                            RecruteurId = 3,
                            Remuneration = 10500m,
                            Secteur = "Private",
                            TypeContrat = "Permanent"
                        },
                        new
                        {
                            OffreId = 5,
                            Poste = "Electrical Engineer",
                            Profil = "Engineer",
                            RecruteurId = 4,
                            Remuneration = 15500m,
                            Secteur = "Private",
                            TypeContrat = "Permanent"
                        },
                        new
                        {
                            OffreId = 6,
                            Poste = "Geomatician Surveyor",
                            Profil = "Master in GIS",
                            RecruteurId = 1,
                            Remuneration = 10000m,
                            Secteur = "Public",
                            TypeContrat = "Permanent"
                        },
                        new
                        {
                            OffreId = 7,
                            Poste = "Social Media Manager",
                            Profil = "Bachelor + 3 years of experience",
                            RecruteurId = 5,
                            Remuneration = 8000m,
                            Secteur = "Private",
                            TypeContrat = "Permanent"
                        },
                        new
                        {
                            OffreId = 8,
                            Poste = "Highschool English Teacher",
                            Profil = "Bachelor in English",
                            RecruteurId = 6,
                            Remuneration = 6000m,
                            Secteur = "Private",
                            TypeContrat = "Permanent"
                        },
                        new
                        {
                            OffreId = 9,
                            Poste = "Web Designer",
                            Profil = "Bachelor in Web Design",
                            RecruteurId = 7,
                            Remuneration = 8000m,
                            Secteur = "Private",
                            TypeContrat = "Temporary"
                        });
                });

            modelBuilder.Entity("ErecrTest.Models.Recruteur", b =>
                {
                    b.Property<int>("RecruteurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecruteurId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecruteurId");

                    b.ToTable("Recruteurs");

                    b.HasData(
                        new
                        {
                            RecruteurId = 1,
                            Email = "khalid.elidrissi.auc@gmail.com",
                            Nom = "Khalid El Idrissi",
                            Tel = "0788912500"
                        },
                        new
                        {
                            RecruteurId = 2,
                            Email = "sara.bensaid.maroctelecom@gmail.com",
                            Nom = "Sara Bensaid",
                            Tel = "0633597601"
                        },
                        new
                        {
                            RecruteurId = 8,
                            Email = "rachid.alaoui.um6p@gmail.com",
                            Nom = "Rachid Alaoui",
                            Tel = "0781659872"
                        },
                        new
                        {
                            RecruteurId = 3,
                            Email = "hassan.amrani.tgcc@gmail.com",
                            Nom = "Hassan Amrani",
                            Tel = "0635954768"
                        },
                        new
                        {
                            RecruteurId = 4,
                            Email = "nadia.tazi.onee@gmail.com",
                            Nom = "Nadia Tazi",
                            Tel = "0622062209"
                        },
                        new
                        {
                            RecruteurId = 5,
                            Email = "mehdi.benjelloun.sopriam@gmail.com",
                            Nom = "Mehdi Benjelloun",
                            Tel = "0694587512"
                        },
                        new
                        {
                            RecruteurId = 6,
                            Email = "amina.ouhibi.lyautey@gmail.com",
                            Nom = "Amina Ouhibi",
                            Tel = "0621548781"
                        },
                        new
                        {
                            RecruteurId = 7,
                            Email = "youssef.elfassi.digismart@gmail.com",
                            Nom = "Youssef Elfassi",
                            Tel = "0643957159"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ErecrTest.Models.Candidature", b =>
                {
                    b.HasOne("ErecrTest.Models.Candidat", "Candidat")
                        .WithMany("Candidatures")
                        .HasForeignKey("CandidatId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ErecrTest.Models.Offre", "Offre")
                        .WithMany("Candidatures")
                        .HasForeignKey("OffreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidat");

                    b.Navigation("Offre");
                });

            modelBuilder.Entity("ErecrTest.Models.Offre", b =>
                {
                    b.HasOne("ErecrTest.Models.Recruteur", "Recruteur")
                        .WithMany("Offres")
                        .HasForeignKey("RecruteurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recruteur");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ErecrTest.Models.Candidat", b =>
                {
                    b.Navigation("Candidatures");
                });

            modelBuilder.Entity("ErecrTest.Models.Offre", b =>
                {
                    b.Navigation("Candidatures");
                });

            modelBuilder.Entity("ErecrTest.Models.Recruteur", b =>
                {
                    b.Navigation("Offres");
                });
#pragma warning restore 612, 618
        }
    }
}

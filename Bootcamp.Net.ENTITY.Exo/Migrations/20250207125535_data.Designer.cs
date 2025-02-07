﻿// <auto-generated />
using Bootcamp.Net.ENTITY.Exo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bootcamp.Net.ENTITY.Exo.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250207125535_data")]
    partial class data
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bootcamp.Net.ENTITY.Exo.Entities.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ActeurPrincipal")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("AnneeSortie")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Realisateur")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Titre")
                        .IsUnique();

                    b.ToTable("Films", t =>
                        {
                            t.HasCheckConstraint("AnneeSortie", "AnneeSortie > 1975");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActeurPrincipal = "Mark Hammil",
                            AnneeSortie = 1977,
                            Genre = "Science-Fiction",
                            Realisateur = "Georges Lucas",
                            Titre = "Star Wars : Un nouvel espoir"
                        },
                        new
                        {
                            Id = 2,
                            ActeurPrincipal = "Mark Hammil",
                            AnneeSortie = 1980,
                            Genre = "Science-Fiction",
                            Realisateur = "Georges Lucas",
                            Titre = "Star Wars : L'empire contre-attaque"
                        },
                        new
                        {
                            Id = 3,
                            ActeurPrincipal = "Mark Hammil",
                            AnneeSortie = 1983,
                            Genre = "Science-Fiction",
                            Realisateur = "Georges Lucas",
                            Titre = "Star Wars : Le retour du Jedi"
                        },
                        new
                        {
                            Id = 4,
                            ActeurPrincipal = "Charlie Hunnam",
                            AnneeSortie = 2005,
                            Genre = "Société",
                            Realisateur = "Lexi Alexander",
                            Titre = "Hooligans"
                        },
                        new
                        {
                            Id = 5,
                            ActeurPrincipal = "Elijah Wood",
                            AnneeSortie = 2001,
                            Genre = "Heroic-Fantasy",
                            Realisateur = "Peter Jackson",
                            Titre = "LOTR - La communauté de l'anneau"
                        },
                        new
                        {
                            Id = 6,
                            ActeurPrincipal = "Elijah Wood",
                            AnneeSortie = 2002,
                            Genre = "Heroic-Fantasy",
                            Realisateur = "Peter Jackson",
                            Titre = "LOTR - Les deux tours"
                        },
                        new
                        {
                            Id = 7,
                            ActeurPrincipal = "Elijah Wood",
                            AnneeSortie = 2003,
                            Genre = "Heroic-Fantasy",
                            Realisateur = "Peter Jackson",
                            Titre = "LOTR - Le retour du roi"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Bootcamp.Net.ENTITY.Exo.Entities;

namespace Bootcamp.Net.ENTITY.Exo.Data.Config
{
    public class DataSet : IEntityTypeConfiguration<Film>
    {
        //apres la mise en place il est possible de faire une sorte de mockup de donnée pour travailler avec des data de base.
        //elle se place toujours dans le configure de votre methode de configuration d'entity,
        //j'entend par la, que ces données peuvent très bien se trouver dans le fichier FilmConfiguration de la premiere partie...
        //ici nous avons donc, une liste de données...., hasdata etant utilisé de base pour préremplir des données lors de la création de la db
        //add-migration et update-database sont toujours d'acutalité
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.HasData(
                new Film
                {
                    Id = 1,
                    Titre = "Star Wars : Un nouvel espoir",
                    AnneeSortie = 1977, //n'oublier pas la contrainte de CK > 1975
                    ActeurPrincipal = "Mark Hammil",
                    Genre = "Science-Fiction",
                    Realisateur = "Georges Lucas"
                },
                new Film
                {
                    Id = 2,
                    Titre = "Star Wars : L'empire contre-attaque",
                    AnneeSortie = 1980,
                    ActeurPrincipal = "Mark Hammil",
                    Genre = "Science-Fiction",
                    Realisateur = "Georges Lucas"
                },
                new Film
                {
                    Id = 3,
                    Titre = "Star Wars : Le retour du Jedi",
                    AnneeSortie = 1983,
                    ActeurPrincipal = "Mark Hammil",
                    Genre = "Science-Fiction",
                    Realisateur = "Georges Lucas"
                },
                new Film
                {
                    Id = 4,
                    Titre = "Hooligans",
                    AnneeSortie = 2005,
                    ActeurPrincipal = "Charlie Hunnam",
                    Genre = "Société",
                    Realisateur = "Lexi Alexander"
                },
                new Film
                {
                    Id = 5,
                    Titre = "LOTR - La communauté de l'anneau",
                    AnneeSortie = 2001,
                    ActeurPrincipal = "Elijah Wood",
                    Genre = "Heroic-Fantasy",
                    Realisateur = "Peter Jackson"
                },
                new Film
                {
                    Id = 6,
                    Titre = "LOTR - Les deux tours",
                    AnneeSortie = 2002,
                    ActeurPrincipal = "Elijah Wood",
                    Genre = "Heroic-Fantasy",
                    Realisateur = "Peter Jackson"
                },
                new Film
                {
                    Id = 7,
                    Titre = "LOTR - Le retour du roi",
                    AnneeSortie = 2003,
                    ActeurPrincipal = "Elijah Wood",
                    Genre = "Heroic-Fantasy",
                    Realisateur = "Peter Jackson"
                }
            );
        }
    }
}

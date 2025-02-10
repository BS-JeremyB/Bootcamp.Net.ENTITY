using Bootcamp.Net.ENTITY.Exo.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Net.ENTITY.Exo.Data.DataSet
{
    public class FilmData : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.HasData(
                new Film
                {
                    Id = 1,
                    Titre = "Star Wars : Un nouvel espoir",
                    AnneeSortie = 1977,
                    Genre = "Science-Fiction",
                    RealisateurId = 10
                },
                new Film
                {
                    Id = 2,
                    Titre = "Star Wars : L'empire contre-attaque",
                    AnneeSortie = 1980,
                    Genre = "Science-Fiction",
                    RealisateurId = 10
                },
                new Film
                {
                    Id = 3,
                    Titre = "Star Wars : Le retour du Jedi",
                    AnneeSortie = 1983,
                    Genre = "Science-Fiction",
                    RealisateurId = 10
                },
                new Film
                {
                    Id = 4,
                    Titre = "Hooligans",
                    AnneeSortie = 2005,
                    Genre = "Société",
                    RealisateurId = 8
                },
                new Film
                {
                    Id = 5,
                    Titre = "LOTR - La communauté de l'anneau",
                    AnneeSortie = 2001,
                    Genre = "Heroic-Fantasy",
                    RealisateurId = 9
                },
                new Film
                {
                    Id = 6,
                    Titre = "LOTR - Les deux tours",
                    AnneeSortie = 2002,
                    Genre = "Heroic-Fantasy",
                    RealisateurId = 9
                },
                new Film
                {
                    Id = 7,
                    Titre = "LOTR - Le retour du roi",
                    AnneeSortie = 2003,
                    Genre = "Heroic-Fantasy",
                    RealisateurId = 9
                });
        }
    }
}

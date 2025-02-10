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
    public class PersonneData : IEntityTypeConfiguration<Personne>
    {
        public void Configure(EntityTypeBuilder<Personne> builder)
        {
            builder.HasData
            (
                new Personne
                {
                    Id = 1,
                    Prenom = "Elijah",
                    Nom = "Wood"
                },
                new Personne
                {
                    Id = 2,
                    Prenom = "Charlie",
                    Nom = "Hunnam"
                },
                new Personne
                {
                    Id = 3,
                    Prenom = "Harisson",
                    Nom = "Ford"
                },
                new Personne
                {
                    Id = 4,
                    Prenom = "Mark",
                    Nom = "Hammil"
                },
                new Personne
                {
                    Id = 5,
                    Prenom = "Carrie",
                    Nom = "Fisher"
                },
                new Personne
                {
                    Id = 6,
                    Prenom = "Vigo",
                    Nom = "Mortensen"
                },
                new Personne
                {
                    Id = 7,
                    Prenom = "Orlando",
                    Nom = "Bloom"
                },
                new Personne
                {
                    Id = 8,
                    Prenom = "Lexi",
                    Nom = "Alexander"
                },
                new Personne
                {
                    Id = 9,
                    Prenom = "Peter",
                    Nom = "Jackson"
                },
                new Personne
                {
                    Id = 10,
                    Prenom = "Georges",
                    Nom = "Lucas"
                }
            );
        }
    }
}

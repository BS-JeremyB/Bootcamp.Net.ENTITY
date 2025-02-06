using Bootcamp.Net.ENTITY.Exo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Net.ENTITY.Exo.Data.Config
{
    public class FilmConfig : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            // PK et Identity
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Id).ValueGeneratedOnAdd();


            // Titre : Contraintes requis, taille et unique
            builder.Property(f => f.Titre)
                .IsRequired()
                .HasMaxLength(100);
            builder.HasIndex(f => f.Titre).IsUnique();

            // Realisateur : Contraintes requis, taille
            builder.Property(f => f.Realisateur)
                .IsRequired()
                .HasMaxLength(100);

            // AnneeSortie : Contraintes requis
            builder.Property(f => f.AnneeSortie)
                .IsRequired();

            // ActeurPrincipal : Contraintes requis, taille
            builder.Property(f => f.ActeurPrincipal)
                .IsRequired()
                .HasMaxLength(100);

            // Genre : Contraintes requis, taille
            builder.Property(f => f.Genre)
                .IsRequired()
                .HasMaxLength(100);

            // AnneeSortie : Contraintes de check
            builder.ToTable(f => f.HasCheckConstraint("AnneeSortie", "AnneeSortie > 1975"));


        }
    }
}

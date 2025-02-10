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
    public class FilmPersonneConfig : IEntityTypeConfiguration<FilmPersonne>
    {
        public void Configure(EntityTypeBuilder<FilmPersonne> builder)
        {
            builder.HasKey(fp => new { fp.FilmId, fp.PersonneId });


            builder.HasOne(fp => fp.Personne)
                   .WithMany(p => p.Roles)
                   .HasForeignKey(fp => fp.PersonneId)
                   .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(fp => fp.Film)
                   .WithMany(f => f.Acteurs)
                   .HasForeignKey(fp => fp.FilmId)
                   .OnDelete(DeleteBehavior.Restrict);
                    
        }
    }
}

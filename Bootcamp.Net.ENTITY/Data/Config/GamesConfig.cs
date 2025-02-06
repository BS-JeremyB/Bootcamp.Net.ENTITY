using Bootcamp.Net.ENTITY.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Net.ENTITY.Data.Config
{
    public class GamesConfig : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {

   

            builder.ToTable(g => g.HasCheckConstraint("PEGI", "PEGI IN (3,7,12,16,18)"));
            builder.ToTable(g => g.HasCheckConstraint("Price", "Price > 0"));
            builder.ToTable(g => g.HasCheckConstraint("ReleaseDate", "ReleaseDate > '1958-10-18'"));
            builder.HasIndex(g => g.Title).IsUnique();


            
        }
    }
}

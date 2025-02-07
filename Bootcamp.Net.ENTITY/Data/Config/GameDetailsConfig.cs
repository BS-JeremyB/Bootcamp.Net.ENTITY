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
    public class GameDetailsConfig : IEntityTypeConfiguration<GameDetails>
    {
        public void Configure(EntityTypeBuilder<GameDetails> builder)
        {

            builder.HasOne<Game>()
                   .WithOne()
                   .HasForeignKey<GameDetails>("GameId")
                   .OnDelete(DeleteBehavior.NoAction);

            builder.Property<int>("GameId").HasColumnName("GameId");
        }
    }
}

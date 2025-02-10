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
    public class GamePlatformConfig : IEntityTypeConfiguration<GamePlatform>
    {
        public void Configure(EntityTypeBuilder<GamePlatform> builder)
        {
            builder.HasKey(gp => new { gp.PlatformId, gp.GameId });

            builder.HasOne(gp => gp.Game)
                   .WithMany(g => g.Platforms)
                   .HasForeignKey(gp => gp.GameId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(gp => gp.Platform)
                   .WithMany(p => p.GamesPlateform)
                   .HasForeignKey(gp => gp.PlatformId)
                   .OnDelete(DeleteBehavior.Restrict);


        }
    }
}

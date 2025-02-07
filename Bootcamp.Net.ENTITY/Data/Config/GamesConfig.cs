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

       //     builder.HasData(
       //    new Game { Id = 7, Title = "The Legend of Zelda", ReleaseDate = DateTime.Parse("1986-02-21"), Description = "Premier jeu de la série Zelda.", Price = 49.99m, IsNew = false, PEGI = 7 },
       //    new Game { Id = 8, Title = "Super Mario Bros.", ReleaseDate = DateTime.Parse("1985-09-13"), Description = "Jeu de plateforme révolutionnaire.", Price = 39.99m, IsNew = false, PEGI = 3 },
       //    new Game { Id = 9, Title = "The Witcher 3", ReleaseDate = DateTime.Parse("2015-05-19"), Description = "RPG en monde ouvert.", Price = 59.99m, IsNew = false, PEGI = 18 },
       //    new Game { Id = 10, Title = "Cyberpunk 2077", ReleaseDate = DateTime.Parse("2020-12-10"), Description = "RPG futuriste immersif.", Price = 59.99m, IsNew = true, PEGI = 18 },
       //    new Game { Id = 11, Title = "Grand Theft Auto V", ReleaseDate = DateTime.Parse("2013-09-17"), Description = "Jeu en monde ouvert.", Price = 59.99m, IsNew = false, PEGI = 18 },
       //    new Game { Id = 12, Title = "Skyrim", ReleaseDate = DateTime.Parse("2011-11-11"), Description = "RPG en monde ouvert légendaire.", Price = 49.99m, IsNew = false, PEGI = 16 },
       //    new Game { Id = 13, Title = "Assassin's Creed II", ReleaseDate = DateTime.Parse("2009-11-17"), Description = "Aventures historiques en Italie.", Price = 39.99m, IsNew = false, PEGI = 18 },
       //    new Game { Id = 14, Title = "Far Cry 3", ReleaseDate = DateTime.Parse("2012-11-29"), Description = "FPS en monde ouvert.", Price = 44.99m, IsNew = false, PEGI = 18 },
       //    new Game { Id = 15, Title = "Red Dead Redemption 2", ReleaseDate = DateTime.Parse("2018-10-26"), Description = "Aventures western réalistes.", Price = 69.99m, IsNew = false, PEGI = 18 },
       //    new Game { Id = 16, Title = "Metroid Prime", ReleaseDate = DateTime.Parse("2002-11-17"), Description = "Action et exploration en 3D.", Price = 29.99m, IsNew = false, PEGI = 12 },
       //    new Game { Id = 17, Title = "Rust", ReleaseDate = DateTime.Parse("2013-12-11"), Description = "Jeu de survie", Price = 39.99m, IsNew = true, PEGI = 16 }
       //);



        }
    }
}

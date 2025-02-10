using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bootcamp.Net.ENTITY.Exo.Entities;

namespace Bootcamp.Net.ENTITY.Exo.Data.DataSet
{
    public class FilmPersonneData : IEntityTypeConfiguration<FilmPersonne>
    {

        public void Configure(EntityTypeBuilder<FilmPersonne> builder)
        {
            builder.HasData
            (
                new FilmPersonne { FilmId = 1, PersonneId = 3 },
                new FilmPersonne { FilmId = 1, PersonneId = 4 },
                new FilmPersonne { FilmId = 1, PersonneId = 5 },
                new FilmPersonne { FilmId = 2, PersonneId = 3 },
                new FilmPersonne { FilmId = 2, PersonneId = 4 },
                new FilmPersonne { FilmId = 2, PersonneId = 5 },
                new FilmPersonne { FilmId = 3, PersonneId = 3 },
                new FilmPersonne { FilmId = 3, PersonneId = 4 },
                new FilmPersonne { FilmId = 3, PersonneId = 5 },
                new FilmPersonne { FilmId = 4, PersonneId = 1 },
                new FilmPersonne { FilmId = 4, PersonneId = 2 },
                new FilmPersonne { FilmId = 5, PersonneId = 1 },
                new FilmPersonne { FilmId = 5, PersonneId = 6 },
                new FilmPersonne { FilmId = 5, PersonneId = 7 },
                new FilmPersonne { FilmId = 6, PersonneId = 1 },
                new FilmPersonne { FilmId = 6, PersonneId = 6 },
                new FilmPersonne { FilmId = 6, PersonneId = 7 },
                new FilmPersonne { FilmId = 7, PersonneId = 1 },
                new FilmPersonne { FilmId = 7, PersonneId = 6 },
                new FilmPersonne { FilmId = 7, PersonneId = 7 }
            );
        }
    }
}

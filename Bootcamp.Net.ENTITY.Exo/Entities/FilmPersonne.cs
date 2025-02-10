using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Net.ENTITY.Exo.Entities
{
    public class FilmPersonne
    {
        public int PersonneId { get; set; }
        public Personne Personne { get; set; }

        public int FilmId { get; set; }
        public Film Film { get; set; }
    }
}

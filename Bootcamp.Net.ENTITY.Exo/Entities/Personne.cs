using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Net.ENTITY.Exo.Entities
{
    public class Personne
    {

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public List<Film> FilmReal { get; set; }

        public List<FilmPersonne> Roles { get; set; }
    }
}

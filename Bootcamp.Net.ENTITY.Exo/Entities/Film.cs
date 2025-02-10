using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Net.ENTITY.Exo.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public int AnneeSortie { get; set; }
        public string Genre { get; set; }
        public int RealisateurId { get; set; }
        public Personne Realisateur { get; set; }
        public List<FilmPersonne> Acteurs { get; set; }

    }
}

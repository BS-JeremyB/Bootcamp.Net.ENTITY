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
        public string Realisateur { get; set; }
        public string ActeurPrincipal { get; set; }
        public string Genre { get; set; }

        public override string ToString()
        {
            return $"Le film {Titre} Réalise en {AnneeSortie} par {Realisateur} est un film de type {Genre} avec comme casting principal {ActeurPrincipal}";
        }
    }
}

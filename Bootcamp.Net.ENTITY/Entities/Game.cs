using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Net.ENTITY.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public bool IsNew { get; set; }
        public int PEGI { get; set; }



        // Ajout studio ici
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Net.ENTITY.Entities
{
    public class GameDetails
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int FileSize { get; set; }

        public Game Game { get; set; }
    }
}

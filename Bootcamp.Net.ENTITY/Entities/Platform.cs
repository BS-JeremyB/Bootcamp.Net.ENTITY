using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Net.ENTITY.Entities
{
    public class Platform
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<GamePlatform> GamesPlateform { get; set; }
    }
}

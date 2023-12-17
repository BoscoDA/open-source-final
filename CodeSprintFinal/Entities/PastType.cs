using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSprintFinal.Entities
{
    internal class PastType
    {
        public Generation Generation { get; set; }
        public List<PokemonType> Types { get; set; }
    }
}

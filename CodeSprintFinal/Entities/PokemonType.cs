using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CodeSprintFinal.Entities
{
    internal class PokemonType
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }
        [JsonProperty("type")]
        public Type Type { get; set; }
    }
}

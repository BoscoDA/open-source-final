using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CodeSprintFinal.Entities
{
    internal class PastAbility
    {
        [JsonProperty("abilities")]
        public List<Abilities> Abilities { get; set; }
        [JsonProperty("generation")]
        public Generation Generation { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CodeSprintFinal.Entities
{
    internal class Abilities
    {
        [JsonProperty("ability")]
        public Ability Ability { get; set; }
        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }
        [JsonProperty("slot")]
        public int Slot { get; set; }
    }
}

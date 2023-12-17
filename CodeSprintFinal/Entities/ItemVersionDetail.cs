using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CodeSprintFinal.Entities
{
    internal class ItemVersionDetail
    {
        [JsonProperty("rarity")]
        public int Rarity { get; set; }
        [JsonProperty("version")]
        public Version Version { get; set; }
    }
}

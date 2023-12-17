using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CodeSprintFinal.Entities
{
    internal class FullStat
    {
        [JsonProperty("base_stat")]
        public int BaseStat { get; set; }
        [JsonProperty("effort")]
        public int Effort { get; set; }
        [JsonProperty("stat")]
        public Stat StatName { get; set; }
    }
}

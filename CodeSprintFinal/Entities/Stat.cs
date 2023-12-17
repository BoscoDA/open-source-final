using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSprintFinal.Entities
{
    internal class Stat
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

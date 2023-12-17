using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CodeSprintFinal.Entities
{
    internal class HeldItem
    {
        [JsonProperty("item")]
        public Item Item { get; set; }
        [JsonProperty("version_details")]
        public List<ItemVersionDetail> VersionDetails { get; set; }
    }
}

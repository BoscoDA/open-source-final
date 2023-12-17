using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CodeSprintFinal.Entities
{
    internal class VersionGroupDetail
    {
        [JsonProperty("level_learned_at")]
        public int LevelLearned { get; set; }
        [JsonProperty("move_learn_method")]
        public MoveLearnedMethod MoveLearnedMethod { get; set; }
        [JsonProperty("version_group")]
        public Version Version { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CodeSprintFinal.Entities
{
    internal class Pokemon
    {
        [JsonProperty("abilities")]
        public List<Abilities> Abilities { get; set; }

        [JsonProperty("base_experience")]
        public decimal BaseExperience { get; set; }

        [JsonProperty("forms")]
        public List<Form> Forms { get; set; }

        [JsonProperty("game_indices")]
        public List<GameIndex> GameIndices { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
        [JsonProperty("held_items")]
        public List<HeldItem> HeldItems { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }
        [JsonProperty("moves")]
        public List<MoveEntry> Moves { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("order")]
        public int Order { get; set; }
        [JsonProperty("past_abilities")]
        public List<PastAbility> PastAbilities { get; set; }
        [JsonProperty("past_types")]
        public List<PastType> PastTypes { get; set; }
        [JsonProperty("species")]
        public Species Species { get; set; }
        [JsonProperty("stats")]
        public List<FullStat> Stats { get; set; }
        [JsonProperty("types")]
        public List<PokemonType> Types { get; set; }
        [JsonProperty("weight")]
        public int Weight { get; set; }

    }
}

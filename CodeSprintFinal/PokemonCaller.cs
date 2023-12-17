using CodeSprintFinal.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeSprintFinal
{
    internal class PokemonCaller
    {
        static readonly HttpClient client = new HttpClient();

        public PokemonCaller() { }

        public async Task<Pokemon> GetPokemon(string name)
        {
            string url = $"https://pokeapi.co/api/v2/pokemon/{name}";

            var response = await client.GetAsync(url);

            var json = await response.Content.ReadAsStringAsync();

            var output = JsonConvert.DeserializeObject<Pokemon>(json);

            return output;
        }
        

        
    }
}

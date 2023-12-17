using CodeSprintFinal.Entities;
using Newtonsoft.Json;
using System;

namespace CodeSprintFinal
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            PokemonCaller pkmnCaller = new PokemonCaller();

            Console.Write("Enter a pokemone name: ");
            string pokemonName = Console.ReadLine().Trim().ToLower();

            try
            {
                var output = pkmnCaller.GetPokemon(pokemonName);
                Console.WriteLine("Created Pokemon Object: " + output.Result.Name);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Request failed!");
            }
            
            Console.ReadKey();
        }
    }
}
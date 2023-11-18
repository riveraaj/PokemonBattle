using PokemonBattle.Models;
using System.Collections.Generic;
using System.Linq;

namespace PokemonBattle.Repositories
{
    internal class PokemonRepository
    {
        private readonly PokemonEntities _pokemonEntities;

        public PokemonRepository(PokemonEntities pokemonEntities) {
            _pokemonEntities = pokemonEntities;
        }

        public ICollection<Pokemon> GetAll() => _pokemonEntities.Pokemons.ToList();
    }
}
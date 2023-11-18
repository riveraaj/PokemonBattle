using PokemonBattle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
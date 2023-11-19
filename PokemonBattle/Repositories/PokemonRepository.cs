using PokemonBattle.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace PokemonBattle.Repositories {
    internal class PokemonRepository {

        //Instance
        private readonly PokemonEntities _pokemonEntities;

        //Init Intance
        public PokemonRepository(PokemonEntities pokemonEntities) => this._pokemonEntities = pokemonEntities;

        //Get List of all Pokemon in the Pokemon BD
        public async Task<ICollection<Pokemon>> GetAllAsync() => await _pokemonEntities.Pokemons.ToListAsync();
    }
}
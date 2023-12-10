using PokemonBattle.Models;
using System.Linq;

namespace PokemonBattle.Repositories {
    internal class ArenasRepository {

        //Instance
        private readonly PokemonEntities _pokemonEntities;

        //Init Intance
        public ArenasRepository(PokemonEntities pokemonEntities) => this._pokemonEntities = pokemonEntities;

        //Get sand based on ID
        public Arena GetArenaByID(int ID) => _pokemonEntities.Arenas.FirstOrDefault(x => x.ArenaID == ID);
    }
}
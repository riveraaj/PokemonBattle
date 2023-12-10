using PokemonBattle.Models;
using System.Linq;

namespace PokemonBattle.Repositories {
    internal class MovementRepository {

        //Instance
        private readonly PokemonEntities _pokemonEntities;

        //Init Intance
        public MovementRepository(PokemonEntities pokemonEntities) => this._pokemonEntities = pokemonEntities;

        //Get a move by name
        public Movement GetMovementByName(string movementName) => _pokemonEntities.Movements.FirstOrDefault(x => x.MovementName == movementName);
    }
}
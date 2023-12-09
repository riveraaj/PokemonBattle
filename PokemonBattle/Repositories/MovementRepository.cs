using PokemonBattle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Repositories {
    internal class MovementRepository {

        //Instance
        private readonly PokemonEntities _pokemonEntities;

        //Init Intance
        public MovementRepository(PokemonEntities pokemonEntities) => this._pokemonEntities = pokemonEntities;

        public Movement GetMovementByName(string movementName) => _pokemonEntities.Movements.FirstOrDefault(x => x.MovementName == movementName);
    }
}
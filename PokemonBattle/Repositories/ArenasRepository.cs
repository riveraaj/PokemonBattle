using PokemonBattle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Repositories {
    internal class ArenasRepository {

        //Instance
        private readonly PokemonEntities _pokemonEntities;

        //Init Intance
        public ArenasRepository(PokemonEntities pokemonEntities) => this._pokemonEntities = pokemonEntities;

        public Arena GetArenaByID(int ID) => _pokemonEntities.Arenas.FirstOrDefault(x => x.ArenaID == ID);

    }
}
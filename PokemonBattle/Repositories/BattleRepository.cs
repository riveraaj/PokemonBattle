using PokemonBattle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Repositories {
    internal class BattleRepository {

        //Instance
        private readonly PokemonEntities _pokemonEntities;

        //Init Intance
        public BattleRepository(PokemonEntities pokemonEntities) => this._pokemonEntities = pokemonEntities;

        public void InsertBattle(Battle oBattle) => _pokemonEntities.Battles.Add(oBattle);

        public void SaveChanges() => _pokemonEntities.SaveChanges();


    }
}
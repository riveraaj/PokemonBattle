using PokemonBattle.Models;

namespace PokemonBattle.Repositories {
    internal class BattleRepository {

        //Instance
        private readonly PokemonEntities _pokemonEntities;

        //Init Intance
        public BattleRepository(PokemonEntities pokemonEntities) => this._pokemonEntities = pokemonEntities;

        //Do the insert into the database
        public void InsertBattle(Battle oBattle) => _pokemonEntities.Battles.Add(oBattle);

        //Save Changes
        public void SaveChanges() => _pokemonEntities.SaveChanges();
    }
}
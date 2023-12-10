using PokemonBattle.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PokemonBattle.Repositories {
    internal class PlayerRepository {
        //Instance
        private readonly PokemonEntities _pokemonEntities;

        //Init Intance
        public PlayerRepository(PokemonEntities pokemonEntities) => this._pokemonEntities = pokemonEntities;

        //Get x number of last players inserted in the database
        public ICollection<Player> GetLastPlayersInsert(int number) => _pokemonEntities.Players.Include(x => x.Team).OrderByDescending(x => x.PlayerID).Take(number).ToList();

        //Do the insert into the database
        public void InsertPlayer(Player oPlayer) => _pokemonEntities.Players.Add(oPlayer);

        //Save Changes
        public void SaveChanges() => _pokemonEntities.SaveChanges();
    }
}
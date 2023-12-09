using PokemonBattle.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Repositories
{
    internal class PlayerRepository {
        //Instance
        private readonly PokemonEntities _pokemonEntities;

        //Init Intance
        public PlayerRepository(PokemonEntities pokemonEntities) => this._pokemonEntities = pokemonEntities;

        public ICollection<Player> GetLastPlayersInsert(int number) => _pokemonEntities.Players.Include(x => x.Team).OrderByDescending(x => x.PlayerID).Take(number).ToList();

        public void InsertPlayer(Player oPlayer) => _pokemonEntities.Players.Add(oPlayer);

        public void SaveChanges() => _pokemonEntities.SaveChanges();
    }
}

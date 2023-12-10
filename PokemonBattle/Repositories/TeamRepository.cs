using PokemonBattle.Models;
using System.Linq;

namespace PokemonBattle.Repositories {
    internal class TeamRepository {
        //Instance
        private readonly PokemonEntities _pokemonEntities;

        //Init Intance
        public TeamRepository(PokemonEntities pokemonEntities) => this._pokemonEntities = pokemonEntities;

        //Get the last record from the database
        public Team GetLastTeamInsert() => _pokemonEntities.Teams.OrderByDescending(x => x.TeamID).FirstOrDefault();

        //Make the insertion into the database
        public void InsertTeam(Team oTeam) => _pokemonEntities.Teams.Add(oTeam);

        //Save Changes
        public void SaveChanges() => _pokemonEntities.SaveChanges();
    }
}
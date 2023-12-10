using PokemonBattle.Models;
using System.Linq;

namespace PokemonBattle.Repositories {
    internal class TournamentRepository {

        //Instance
        private readonly PokemonEntities _pokemonEntities;

        //Init Intance
        public TournamentRepository(PokemonEntities pokemonEntities) => this._pokemonEntities = pokemonEntities;

        //Get the last tournament that was saved
        public Tournament GetLastTournamentInsert() => _pokemonEntities.Tournaments.OrderByDescending(x => x.TournamentID).FirstOrDefault();

        //Make the insertion into the database
        public void InsertTournament(Tournament oTournament) => _pokemonEntities.Tournaments.Add(oTournament);

        //Save Changes
        public void SaveChanges() => _pokemonEntities.SaveChanges();
    }
}
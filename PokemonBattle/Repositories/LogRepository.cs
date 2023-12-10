using PokemonBattle.Models;
using System.Linq;

namespace PokemonBattle.Repositories
{
    internal class LogRepository {
        //Instance
        private readonly PokemonEntities _pokemonEntities;

        //Init Intance
        public LogRepository(PokemonEntities pokemonEntities) => this._pokemonEntities = pokemonEntities;

        //Get the last record from the database
        public Log GetLastLogInsert() => _pokemonEntities.Logs.OrderByDescending(x => x.LogID).FirstOrDefault();

        //Do the insert into the database
        public void InsertLog(Log oLog) => _pokemonEntities.Logs.Add(oLog);

        //Save Changes
        public void SaveChanges() => _pokemonEntities.SaveChanges();
    }
}
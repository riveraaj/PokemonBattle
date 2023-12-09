using PokemonBattle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Repositories
{
    internal class LogRepository {
        //Instance
        private readonly PokemonEntities _pokemonEntities;

        //Init Intance
        public LogRepository(PokemonEntities pokemonEntities) => this._pokemonEntities = pokemonEntities;

        public Log GetLastLogInsert() => _pokemonEntities.Logs.OrderByDescending(x => x.LogID).FirstOrDefault();

        public void InsertLog(Log oLog) => _pokemonEntities.Logs.Add(oLog);

        public void SaveChanges() => _pokemonEntities.SaveChanges();
    }
}

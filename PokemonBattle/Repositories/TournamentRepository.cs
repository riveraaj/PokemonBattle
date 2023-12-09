using PokemonBattle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Repositories {
    internal class TournamentRepository {

        //Instance
        private readonly PokemonEntities _pokemonEntities;

        //Init Intance
        public TournamentRepository(PokemonEntities pokemonEntities) => this._pokemonEntities = pokemonEntities;

        public Tournament GetLastTournamentInsert() => _pokemonEntities.Tournaments.OrderByDescending(x => x.TournamentID).FirstOrDefault();

        public void InsertTournament(Tournament oTournament) => _pokemonEntities.Tournaments.Add(oTournament);

        public void SaveChanges() => _pokemonEntities.SaveChanges();


    }
}
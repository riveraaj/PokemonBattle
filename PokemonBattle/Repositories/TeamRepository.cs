using PokemonBattle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Repositories {
    internal class TeamRepository {
        //Instance
        private readonly PokemonEntities _pokemonEntities;

        //Init Intance
        public TeamRepository(PokemonEntities pokemonEntities) => this._pokemonEntities = pokemonEntities;

        public Team GetLastTeamInsert() => _pokemonEntities.Teams.OrderByDescending(x => x.TeamID).FirstOrDefault();

        public void InsertTeam(Team oTeam) => _pokemonEntities.Teams.Add(oTeam);

        public void SaveChanges() => _pokemonEntities.SaveChanges();
    }
}

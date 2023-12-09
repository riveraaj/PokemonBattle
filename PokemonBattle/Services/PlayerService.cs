using PokemonBattle.Models;
using System;
using System.Linq;

namespace PokemonBattle.Services {
    internal class PlayerService {

        //Intance
        private readonly TournamentManager _tournamentServices;

        //Init Intance
        public PlayerService() => this._tournamentServices = TournamentManager.GetInstance;

        public void CreatePlayer(string playerName) {
            Player oPlayer = new Player {
                PlayerName = playerName,
                IsInQuarter = (_tournamentServices.TournamentSize == 8),
                IsInSemi = (_tournamentServices.TournamentSize == 4)
            };
            _tournamentServices.AuxPlayersList.Add(oPlayer);
            Console.WriteLine(_tournamentServices.AuxPlayersList);
        }

        public void CreatePlayer(string playerName, Team oTeam){
            Player oPlayer = new Player {
                PlayerName = playerName,
                Team = oTeam,       
                IsInQuarter = (_tournamentServices.TournamentSize == 8),
                IsInSemi = (_tournamentServices.TournamentSize == 4)
            };
            _tournamentServices.AuxPlayersList.Add(oPlayer);
        }

        public void UpdatePlayerTeam(string playerName, Team oTeam) {
           var playerToUpdate =  _tournamentServices.AuxPlayersList.FirstOrDefault(x => x.PlayerName == playerName);
            if (playerToUpdate != null) playerToUpdate.Team = oTeam;
            else Console.WriteLine($"{playerName} Not Found.");
        }    
    }
}
using PokemonBattle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Services {
    internal class PlayerService {

        private readonly TournamentManager _tournamentServices;
        public PlayerService() => _tournamentServices = TournamentManager.GetInstance;

        public void CreatePlayer(string playerName) {
            Player oPlayer = new Player();
            oPlayer.playerName = playerName;
            _tournamentServices.PlayersList.Add(oPlayer);
            Console.WriteLine(_tournamentServices.PlayersList);
        }

        public void CreatePlayer(string playerName, Team oTeam){
            Player oPlayer = new Player();
            oPlayer.playerName = playerName;
            oPlayer.Team = oTeam;
            _tournamentServices.PlayersList.Add(oPlayer);
        }

        public void UpdatePlayerTeam(string playerName, Team oTeam) {
           var playerToUpdate =  _tournamentServices.PlayersList.FirstOrDefault(x => x.playerName == playerName);
            if (playerToUpdate != null) playerToUpdate.Team = oTeam;
            else Console.WriteLine($"{playerName} Not Found.");
        }
        
    }
}
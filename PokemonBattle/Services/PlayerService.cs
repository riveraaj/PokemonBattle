using PokemonBattle.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonBattle.Services {
    internal class PlayerService {

        //Intance
        private readonly TournamentManager _tournamentManager;

        //Init Intance
        public PlayerService() => this._tournamentManager = TournamentManager.GetInstance;

        //Create a player without a team
        public void CreatePlayer(string playerName) {
            Player oPlayer = new Player {
                PlayerName = playerName,
                IsInQuarter = (_tournamentManager.TournamentSize == 8),
                IsInSemi = (_tournamentManager.TournamentSize == 4)
            };
            _tournamentManager.AuxPlayersList.Add(oPlayer);
            Console.WriteLine(_tournamentManager.AuxPlayersList);
        }

        //Create a player with a team
        public void CreatePlayer(string playerName, Team oTeam){
            Player oPlayer = new Player {
                PlayerName = playerName,
                Team = oTeam,       
                IsInQuarter = (_tournamentManager.TournamentSize == 8),
                IsInSemi = (_tournamentManager.TournamentSize == 4)
            };
            _tournamentManager.AuxPlayersList.Add(oPlayer);
        }

        //Updating the player's equipment
        public void UpdatePlayerTeam(string playerName, Team oTeam) {
           var playerToUpdate = _tournamentManager.AuxPlayersList.FirstOrDefault(x => x.PlayerName == playerName);
            if (playerToUpdate != null) playerToUpdate.Team = oTeam;
            else Console.WriteLine($"{playerName} Not Found.");
        }

        //Get the tournamet manager player list
        public List<Player> GetPlayerList() => _tournamentManager.AuxPlayersList;

        //Gets a player by name and verifies if he has a team
        public bool GetAPlayerNameAndVerifyHaveAnTeam(){
            bool allPlayersHaveAnTeam = true;
            int playersWithoutTeamCount = 0;

            //Returns true if only one player with equipment is missing
            foreach (var player in _tournamentManager.AuxPlayersList) {
                if (player.Team == null) {
                    playersWithoutTeamCount++;
                    if (playersWithoutTeamCount > 1) {
                        allPlayersHaveAnTeam = false;
                        break;
                    }
                }
            }
            return allPlayersHaveAnTeam;
        }
    }
}
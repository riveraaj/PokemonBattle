using PokemonBattle.Models;
using System.Collections.Generic;

namespace PokemonBattle.Services {
    internal class PlayersService {

        //Instance
        private readonly TournamentManager _tournamentManager;

        public PlayersService() => this._tournamentManager = TournamentManager.GetInstance;

        public List<Player> GetPlayerList() => _tournamentManager.PlayersList;

        public bool GetAPlayerNameAndVerifyHaveAnTeam() {

            bool allPlayersHaveAnTeam = true;
            int playersWithoutTeamCount = 0;

            //Returns true if only one player with equipment is missing
            foreach (var player in _tournamentManager.PlayersList) {
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
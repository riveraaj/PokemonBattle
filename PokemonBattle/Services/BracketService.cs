using PokemonBattle.Models;
using System.Collections.Generic;
using System.Linq;

namespace PokemonBattle.Services {
    internal class BracketService{

        private TournamentManager _tournamentManager;

        public BracketService() => _tournamentManager = TournamentManager.GetInstance;

        public List<Player> GetPlayerList() => _tournamentManager.PlayersList;

        public int GetSizeTournament() => _tournamentManager.TournamentSize;

        public Player GetWinner() => _tournamentManager.Winner;

        public Player GetPlayerByPositionOnList(int position) => _tournamentManager.PlayersList[position];

        public (string playerOneName, string playerTwoName, bool inFinals) GetNextBattle() {
            int howManyInFinals = GetPlayerList().Where(x => x.IsInFinal).Count();
            bool inFinals = false;
            string playerOneName, playerTwoName;

            if (howManyInFinals == 2){
                var playersForBattle = GetPlayerList().Where(x => x.IsInFinal).Take(2).ToList();
                playerOneName = playersForBattle[0].PlayerName;
                playerTwoName = playersForBattle[1].PlayerName;
                inFinals = true;
            } else {
                var playersForBattle = GetPlayerList().Where(x => !x.IsInFinal && !x.IsEliminated).Take(2).ToList();
                playerOneName = playersForBattle[0].PlayerName;
                playerTwoName = playersForBattle[1].PlayerName;
            }

            return (playerOneName, playerTwoName, inFinals);
        }
    }
}
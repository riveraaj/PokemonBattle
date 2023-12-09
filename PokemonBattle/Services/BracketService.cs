using PokemonBattle.Models;
using System.Collections.Generic;
using System.Linq;

namespace PokemonBattle.Services {
    internal class BracketService{

        private TournamentManager _tournamentManager;

        public BracketService() => _tournamentManager = TournamentManager.GetInstance;

        public List<Player> GetPlayerList() => _tournamentManager.PlayersList;

        public int GetSizeTournament() => _tournamentManager.TournamentSize;

        public void CleanTorunamentManager() => _tournamentManager.Reset();

        public Player GetWinner() => _tournamentManager.Winner;

        public Player GetPlayerByPositionOnList(int position) => _tournamentManager.PlayersList[position];

        public (string playerOneName, string playerTwoName) GetNextBattle() {
            int howManyInFinals = GetPlayerList().Where(x => x.IsInFinal).Count();
            int howManyInSemiFinals = GetPlayerList().Where(x => x.IsInSemi).Count();
            int howManyInQuarters = GetPlayerList().Where(x => x.IsInQuarter).Count();
            string playerOneName, playerTwoName;

            if (howManyInFinals == 2){
                var playersForBattle = GetPlayerList().Where(x => x.IsInFinal).Take(2).ToList();
                playerOneName = playersForBattle[0].PlayerName;
                playerTwoName = playersForBattle[1].PlayerName;
            } else if (howManyInSemiFinals == 4) {
                var playersForBattle = GetPlayerList().Where(x => !x.IsEliminated && x.IsInSemi && !x.IsInFinal).Take(2).ToList();
                playerOneName = playersForBattle[0].PlayerName;
                playerTwoName = playersForBattle[1].PlayerName;
            } else if (howManyInQuarters == 8) {
                var playersForBattle = GetPlayerList().Where(x => !x.IsEliminated && x.IsInQuarter && !x.IsInFinal && !x.IsInSemi).Take(2).ToList();
                playerOneName = playersForBattle[0].PlayerName;
                playerTwoName = playersForBattle[1].PlayerName;
            } else {
                var playersForBattle = GetPlayerList().Where(x => !x.IsInFinal && !x.IsEliminated && !x.IsInSemi && !x.IsInQuarter).Take(2).ToList();
                playerOneName = playersForBattle[0].PlayerName;
                playerTwoName = playersForBattle[1].PlayerName;
            }

            return (playerOneName, playerTwoName);
        }
    }
}
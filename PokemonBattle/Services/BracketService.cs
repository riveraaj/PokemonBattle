using PokemonBattle.Models;
using System.Collections.Generic;
using System.Linq;

namespace PokemonBattle.Services {
    internal class BracketService{

        //Instance
        private readonly TournamentManager _tournamentManager;

        //Init Instance
        public BracketService() => _tournamentManager = TournamentManager.GetInstance;


        //Gets the list of players of the Torunament Manager
        public List<Player> GetPlayerList() => _tournamentManager.PlayersList;

        //Get the size of the Tournament Manager tournament
        public int GetSizeTournament() => _tournamentManager.TournamentSize;

        //Clears all variables in Tournament Manager
        public void CleanTorunamentManager() => _tournamentManager.Reset();

        //The winner of the tournament obtains
        public Player GetWinner() => _tournamentManager.Winner;

        //Gets a player based on Tournament Manager roster position
        public Player GetPlayerByPositionOnList(int position) => _tournamentManager.PlayersList[position];

        //Help get the names of the next players to face
        public (string playerOneName, string playerTwoName) GetNextBattle() {
            //The number of players is obtained depending on the round they are in.
            int howManyInFinals = GetPlayerList().Where(x => x.IsInFinal).Count();
            int howManyInSemiFinals = GetPlayerList().Where(x => x.IsInSemi).Count();
            int howManyInQuarters = GetPlayerList().Where(x => x.IsInQuarter).Count();

            string playerOneName, playerTwoName;

            //It is validated if the conditions are met to know which round the
            //players are going through and thus designate the players to battle.
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

            //Return the two names of the players to battle
            return (playerOneName, playerTwoName);
        }
    }
}
using PokemonBattle.Models;
using System.Collections.Generic;

namespace PokemonBattle.Services {
    internal class BracketService{

        private TournamentManager _tournamentManager;

        public BracketService() => _tournamentManager = TournamentManager.GetInstance;

        public List<Player> GetPlayerList() => _tournamentManager.PlayersList;

        public int GetSizeTournament() => _tournamentManager.TournamentSize;

        public Player GetWinner() => _tournamentManager.Winner;

        public Player GetPlayerByPositionOnList(int position) => _tournamentManager.PlayersList[position];
    }
}
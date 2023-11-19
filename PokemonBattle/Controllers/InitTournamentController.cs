using PokemonBattle.Services;
using System.Collections.Generic;

namespace PokemonBattle.Controllers {
    internal class InitTournamentController {

        //Instances
        private readonly TournamentManager _tournamentManager;
        private readonly PlayerService _playerService;
        private readonly BotService _botService;

        public InitTournamentController() {
            //Init Intances
            this._tournamentManager = TournamentManager.GetInstance;
            this._playerService = new PlayerService();
            this._botService = new BotService();
        }

        //Save Tournament Size in Singleton Tournament Manager
        public void SaveTournamentSize(int size) => _tournamentManager.TournamentSize = size;

        //Generate Bots with Bot Service Class based on the Size of the Tournament and the Numbers of Players
        public void GenerateBots(int size, int numberOfPlayers) {
            int numberOfBots = size - numberOfPlayers;
            for (int i = 0; i < numberOfBots; i++) {
                _botService.CreateBot();
            }
        }

        //Generate Players with the Player Service Class based on the List Size
        public void GeneratePlayers(List<string> playerNames) => playerNames.ForEach(x => _playerService.CreatePlayer(x));
    }
}
using PokemonBattle.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonBattle.Controllers
{
    internal class InitTournamentController {

        private TournamentManager _tournamentServices;
        private PlayerService _playerService;
        private BotService _botService;

        public InitTournamentController() => InitInstance();

        private void InitInstance() {
            _tournamentServices = TournamentManager.GetInstance;
            _playerService = new PlayerService();
            _botService = new BotService();
        }

        public void SaveTournamentSize(int size) => _tournamentServices.TournamentSize = size;

        public void GenerateBots(int size, int numberOfPlayers) {
            int numberOfBots = size - numberOfPlayers;
            for (int i = 0; i < numberOfBots; i++) {
                _botService.CreateBot();
            }
        }

        public void GeneratePlayers(List<string> playerNames) => playerNames.ForEach(x => _playerService.CreatePlayer(x));
    }
}
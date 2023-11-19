using PokemonBattle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Services {
    internal class BotService {

        private PlayerService _playerService;
        private Random _random;

        public BotService() {
            _playerService = new PlayerService();
            _random = new Random();
        }
        
        public void CreateBot(){
            _playerService.CreatePlayer("BOT", GenerateTeamBot());
        }
        private Team GenerateTeamBot() {
            Team oTeam = new Team();
            List<int> idsChosen = new List<int>();

            while (idsChosen.Count < 6) {
                int pokemonID = GetRandomNumber();
                if (!idsChosen.Contains(pokemonID)) idsChosen.Add(pokemonID);
            }

            oTeam.pokemonOneID = idsChosen[0];
            oTeam.pokemonTwoID = idsChosen[1];
            oTeam.pokemonThreeID = idsChosen[2];
            oTeam.pokemonFourID = idsChosen[3];
            oTeam.pokemonFiveID = idsChosen[4];
            oTeam.pokemonSixID = idsChosen[5];
            return oTeam;
        }

        private int GetRandomNumber() => _random.Next(387, 493 + 1);
    }
}
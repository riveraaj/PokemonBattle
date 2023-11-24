using PokemonBattle.Models;
using System;
using System.Collections.Generic;

namespace PokemonBattle.Services {
    internal class BotService {

        //Instances
        private readonly PlayerService _playerService;
        private readonly Random _random;

        public BotService() {
            //Init Intances
            this._playerService = new PlayerService();
            this._random = new Random();
        }
        
        //Create a Bot Player
        public void CreateBot(int ID){
            _playerService.CreatePlayer($"BOT{ID}", GenerateTeamBot());
        }


        //Generate a Team for a Player Bot
        private Team GenerateTeamBot() {
            Team oTeam = new Team();
            List<int> idsChosen = new List<int>();

            //Check if a list of int contains 6 different numbers
            while (idsChosen.Count < 6) {
                int pokemonID = GetRandomNumber();
                if (!idsChosen.Contains(pokemonID)) idsChosen.Add(pokemonID);
            }

            //Saves random Pokemon for a Team Player Bot
            oTeam.PokemonOneID = idsChosen[0];
            oTeam.PokemonTwoID = idsChosen[1];
            oTeam.PokemonThreeID = idsChosen[2];
            oTeam.PokemonFourID = idsChosen[3];
            oTeam.PokemonFiveID = idsChosen[4];
            oTeam.PokemonSixID = idsChosen[5];
            return oTeam;
        }

        //Generate a random number between 347 and 493
        private int GetRandomNumber() => _random.Next(387, 493 + 1);
    }
}
using PokemonBattle.Models;
using PokemonBattle.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonBattle.Services {
    internal class BattleService {
        //Instances
        private readonly Random _random;
        private readonly LogRepository _logRepository;
        private readonly TeamRepository _teamRepository;
        private readonly ArenasRepository _arenasRepository;
        private readonly BattleRepository _battleRepository;
        private readonly PlayerRepository _playerRepository;
        private readonly TournamentManager _tournamentManager;
        private readonly MovementRepository _movementRepository;
        private readonly TournamentRepository _tournamentRepository;

        //Init Instances
        public BattleService() {
            this._random = new Random();
            this._tournamentManager = TournamentManager.GetInstance;
            this._logRepository = new LogRepository(new PokemonEntities());
            this._teamRepository = new TeamRepository(new PokemonEntities());
            this._arenasRepository = new ArenasRepository(new PokemonEntities());
            this._battleRepository = new BattleRepository(new PokemonEntities());
            this._playerRepository = new PlayerRepository(new PokemonEntities());
            this._movementRepository = new MovementRepository(new PokemonEntities());
            this._tournamentRepository = new TournamentRepository(new PokemonEntities()); 
        }

        //Gets the list of players based on name
        public List<Player> GetPlayersByName(string nameOne, string nameTwo) => _tournamentManager.PlayersList.Where(x => x.PlayerName == nameOne || x.PlayerName == nameTwo).ToList();

        //Get a pokemon based on its ID
        public Pokemon GetPomemonByID(int ID) => _tournamentManager.PokemonsList.FirstOrDefault(x => x.PokemonID == ID);

        //Gets a random arena
        public Arena GetRandomArena() => _arenasRepository.GetArenaByID(GetRandomNumber(1, 18));

        //Gets a move based on its name
        public Movement GetMovement(string name) => _movementRepository.GetMovementByName(name);

        //Create a Battle
        public void CreateBattle(List<Player> playerList, int arenaID, bool isPlayerOneWinner, int countPokemonWinner) {

            //Gets the winning player of the battle
            Player playerWinner = (isPlayerOneWinner) ? playerList[0] : playerList[1];

            //Create a log for the battle
            Log oLog = new Log {
                LogDescription = $"The winner of this battle is {playerWinner.PlayerName} with {countPokemonWinner} live pokemon."
            };

            //Save that log
            SaveLog(oLog);

            //Get the previously saved log
            Log auxLog = _logRepository.GetLastLogInsert();

            //Create a Battle
            Battle oBattle = new Battle {
                ArenaID = arenaID,
                PlayerOneID = playerList[1].PlayerID,
                PlayerTwoID = playerList[0].PlayerID,
                WinnerID = playerWinner.PlayerID,
                LogID = auxLog.LogID
            };

            //Save the battle to a temporary list
            _tournamentManager.BattleList.Add(oBattle);
        }

        //Save a Tournament and a Tournament Winner 
        public void SaveTournament(Player Winner) {
            Tournament oTournament = new Tournament  {
                WinnerID = Winner.PlayerID
            };
            _tournamentManager.Winner = Winner;
            _tournamentRepository.InsertTournament(oTournament);
            _tournamentRepository.SaveChanges();
        }

        //Save battles from a temporary list
        public void SaveBattles(Player Winner) {
            //Save a Tournament
            SaveTournament(Winner);
            //Gets the Tournament that was just created
            var auxTournament = _tournamentRepository.GetLastTournamentInsert();

            //Scroll through the temporary list of battles to save them
            foreach (var battle in _tournamentManager.BattleList) {
                battle.TournamentID = auxTournament.TournamentID;
                _battleRepository.InsertBattle(battle);
                _battleRepository.SaveChanges();
            }
        }

        //Save a player
        public void SavePlayer(Player oPlayer) {
            _playerRepository.InsertPlayer(oPlayer);
            _playerRepository.SaveChanges();
        }

        //Save the player's equipment
        public void SaveTeam(Team oTeam) {
            _teamRepository.InsertTeam(oTeam);
            _teamRepository.SaveChanges();
        }

        //Save the log
        private void SaveLog(Log oLog) {
            _logRepository.InsertLog(oLog);
            _logRepository.SaveChanges();
        }

        //Generate a random number between X and Y
        public int GetRandomNumber(int numberOne, int numberTwo) => _random.Next(numberOne, numberTwo + 1);
    }
}
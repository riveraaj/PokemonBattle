using PokemonBattle.Models;
using PokemonBattle.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonBattle.Services {
    internal class BattleService {

        private readonly TournamentManager _tournamentManager;
        private readonly ArenasRepository _arenasRepository;
        private readonly BattleRepository _battleRepository;
        private readonly TeamRepository _teamRepository;
        private readonly MovementRepository _movementRepository;
        private readonly PlayerRepository _playerRepository;
        private readonly LogRepository _logRepository;
        private readonly TournamentRepository _tournamentRepository;
        private readonly Random _random;

        public BattleService() {
            this._tournamentManager = TournamentManager.GetInstance;
            this._arenasRepository = new ArenasRepository(new PokemonEntities());
            this._movementRepository = new MovementRepository(new PokemonEntities());
            this._battleRepository = new BattleRepository(new PokemonEntities());
            this._teamRepository = new TeamRepository(new PokemonEntities());
            this._playerRepository = new PlayerRepository(new PokemonEntities());
            this._logRepository = new LogRepository(new PokemonEntities());
            this._tournamentRepository = new TournamentRepository(new PokemonEntities());
            this._random = new Random();
        }

        public List<Player> GetPlayersByName(string nameOne, string nameTwo) => _tournamentManager.PlayersList.Where(x => x.PlayerName == nameOne || x.PlayerName == nameTwo).ToList();

        public Pokemon GetPomemonByID(int ID) => _tournamentManager.PokemonsList.FirstOrDefault(x => x.PokemonID == ID);

        public Arena GetRandomArena() => _arenasRepository.GetArenaByID(GetRandomNumber(1, 18));

        public Movement GetMovement(string name) => _movementRepository.GetMovementByName(name);

        public void CreateBattle(List<Player> playerList, int arenaID, bool isPlayerOneWinner, int countPokemonWinner) {

            Player playerWinner = (isPlayerOneWinner) ? playerList[0] : playerList[1];


            Log oLog = new Log {
                LogDescription = $"The winner of this battle is {playerWinner.PlayerName} with {countPokemonWinner} live pokemon."
            };

            SaveLog(oLog);

            Log auxLog = _logRepository.GetLastLogInsert();

            Battle oBattle = new Battle {
                ArenaID = arenaID,
                PlayerOneID = playerList[1].PlayerID,
                PlayerTwoID = playerList[0].PlayerID,
                WinnerID = playerWinner.PlayerID,
                LogID = auxLog.LogID
            };

            _tournamentManager.BattleList.Add(oBattle);
        }

        public void SaveTournament(Player Winner) {
            Tournament oTournament = new Tournament  {
                WinnerID = Winner.PlayerID
            };
            _tournamentManager.Winner = Winner;
            _tournamentRepository.InsertTournament(oTournament);
            _tournamentRepository.SaveChanges();
        }

        public void SaveBattles(Player Winner) {
            SaveTournament(Winner);
            var auxTournament = _tournamentRepository.GetLastTournamentInsert();

            foreach(var battle in _tournamentManager.BattleList) {
                battle.TournamentID = auxTournament.TournamentID;
                _battleRepository.InsertBattle(battle);
                _battleRepository.SaveChanges();
            }
        }

        public void SavePlayer(Player oPlayer) {
            _playerRepository.InsertPlayer(oPlayer);
            _playerRepository.SaveChanges();
        }

        public void SaveTeam(Team oTeam) {
            _teamRepository.InsertTeam(oTeam);
            _teamRepository.SaveChanges();
        }

        private void SaveLog(Log oLog) {
            _logRepository.InsertLog(oLog);
            _logRepository.SaveChanges();
        }

        //Generate a random number between X and Y
        public int GetRandomNumber(int numberOne, int numberTwo) => _random.Next(numberOne, numberTwo + 1);
    }
}
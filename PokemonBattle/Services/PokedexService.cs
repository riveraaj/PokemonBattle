using PokemonBattle.Models;
using PokemonBattle.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace PokemonBattle.Services {
    internal class PokedexService {

        //Instance
        private readonly TournamentManager _tournamentManager;
        private readonly TeamRepository _teamRepository;
        private readonly PlayerRepository _playerRepository;

        // Define a dictionary to map type names to resource names
        private readonly Dictionary<string, string> typeResourceMap = new Dictionary<string, string> {
            { "Fairy", "Fairy" }, { "Steel", "Steel" }, { "Dark", "Dark" },
            { "Dragon", "Dragon" }, { "Ghost", "Ghost" }, { "Rock", "Rock" }, 
            { "Bug", "Bug" }, { "Psychc", "Psychc" },  { "Flying", "Flying" },
            { "Ground", "Ground" }, { "Poison", "Poison" }, { "Fight", "Fight" },
            { "Ice", "Ice" }, { "Grass", "Grass" }, { "Electr", "Electr" }, 
            { "Water", "Water" }, { "Fire", "Fire" }, { "Normal", "Normal" }
        };

        public PokedexService() {
            this._tournamentManager = TournamentManager.GetInstance;
            this._teamRepository = new TeamRepository(new PokemonEntities());
            this._playerRepository = new PlayerRepository(new PokemonEntities());
        }

        public Pokemon GetPokemonByPositionOnList(int pokemonPosition) => _tournamentManager.PokemonsList[pokemonPosition];

        public Player GetPlayerByNameOnList(string playerName) => _tournamentManager.AuxPlayersList.FirstOrDefault(x => x.PlayerName == playerName);

        public void SaveTeamPlayer(Team oTeam, string playerName) {
            Player oPlayer = GetPlayerByNameOnList(playerName);
            oPlayer.Team = oTeam;
        }

        public void SaveTeamAndTeam()
        {
            foreach (var player in _tournamentManager.AuxPlayersList)
            {
                Team oTeam = new Team
                {
                    PokemonOneID = player.Team.PokemonOneID,
                    PokemonTwoID = player.Team.PokemonTwoID,
                    PokemonThreeID = player.Team.PokemonThreeID,
                    PokemonFourID = player.Team.PokemonFourID,
                    PokemonFiveID = player.Team.PokemonFiveID,
                    PokemonSixID = player.Team.PokemonSixID
                };

                // Insertar el equipo
                _teamRepository.InsertTeam(oTeam);
                _teamRepository.SaveChanges();

                // Obtener el último equipo insertado
                var lastTeam = _teamRepository.GetLastTeamInsert();

                Player oPlayer = new Player
                {
                    PlayerName = player.PlayerName,
                    TeamID = lastTeam.TeamID
                };

                // Insertar el jugador
                _playerRepository.InsertPlayer(oPlayer);
                _playerRepository.SaveChanges();
            }

            // Obtener los últimos seis jugadores insertados
            foreach (var player in _playerRepository.GetLastPlayersInsert(_tournamentManager.TournamentSize))  {
                player.IsInQuarter = (_tournamentManager.TournamentSize == 8);
                player.IsInSemi = (_tournamentManager.TournamentSize == 4);
                _tournamentManager.PlayersList.Add(player);
            }
        }

        public string GetTypeElementName(int pokemonPosition, int numberType){
            string typeElementName;
            Pokemon oPokemon = GetPokemonByPositionOnList(pokemonPosition);
            if (numberType == 1) typeElementName = oPokemon.TypeElementOne.TypeElementName;
            else typeElementName = oPokemon.TypeElementTwo.TypeElementName;
            if (typeResourceMap.TryGetValue(typeElementName, out string resourceName))
                return resourceName;
            return "";
        }
    }
}
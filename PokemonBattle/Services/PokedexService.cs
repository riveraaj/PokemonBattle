using PokemonBattle.Models;
using System.Collections.Generic;
using System.Linq;

namespace PokemonBattle.Services {
    internal class PokedexService {

        //Instance
        private TournamentManager _tournamentManager;

        // Define a dictionary to map type names to resource names
        private readonly Dictionary<string, string> typeResourceMap = new Dictionary<string, string> {
            { "Fairy", "Fairy" }, { "Steel", "Steel" }, { "Dark", "Dark" },
            { "Dragon", "Dragon" }, { "Ghost", "Ghost" }, { "Rock", "Rock" }, 
            { "Bug", "Bug" }, { "Psychc", "Psychc" },  { "Flying", "Flying" },
            { "Ground", "Ground" }, { "Poison", "Poison" }, { "Fight", "Fight" },
            { "Ice", "Ice" }, { "Grass", "Grass" }, { "Electr", "Electr" }, 
            { "Water", "Water" }, { "Fire", "Fire" }, { "Normal", "Normal" }
        };

        public PokedexService() => _tournamentManager = TournamentManager.GetInstance;

        public Pokemon GetPokemonByPositionOnList(int pokemonPosition) => _tournamentManager.PokemonsList[pokemonPosition];

        public Player GetPlayerByNameOnList(string playerName) => _tournamentManager.PlayersList.FirstOrDefault(x => x.PlayerName == playerName);

        public void SaveTeamPlayer(Team oTeam, string playerName) {
            Player oPlayer = GetPlayerByNameOnList(playerName);
            oPlayer.Team = oTeam;
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
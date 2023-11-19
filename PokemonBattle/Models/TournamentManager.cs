using PokemonBattle.Models;
using PokemonBattle.Repositories;
using System.Collections.Generic;

namespace PokemonBattle.Services {
    public class TournamentManager {

        private static TournamentManager _instance;

        private PokemonRepository _pokemon;
        public int TournamentSize {  get; set; }
        public List<Player> PlayersList { get; set; }
        public List<Pokemon> PokemonsList { get; set; }

        private TournamentManager() => InitInstance(); 

        public static TournamentManager GetInstance {
            get {
                if (_instance == null) _instance = new TournamentManager();
                return _instance;
            }
        }

        public void InitInstance() {
            _pokemon = new PokemonRepository(new PokemonEntities());
            this.PlayersList = new List<Player>();
            this.PokemonsList = (List<Pokemon>)_pokemon.GetAll();
        }

        public void Reset() {
            this.TournamentSize = 0;
            this.PlayersList.Clear();
        }
    }
}
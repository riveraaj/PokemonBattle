using PokemonBattle.Models;
using PokemonBattle.Repositories;
using System.Collections.Generic;

namespace PokemonBattle.Services {
    public class TournamentManager {

        //Instances
        private static TournamentManager _instance;
        private PokemonRepository _pokemon;

        public async void InitInstances() {
            this._pokemon = new PokemonRepository(new PokemonEntities());
            this.PlayersList = new List<Player>();
            this.AuxPlayersList = new List<Player>();
            this.BattleList = new List<Battle>();
            this.PokemonsList = (List<Pokemon>) await _pokemon.GetAllAsync();          
    }
        
        //Encapsulation
        public int TournamentSize { get; set; }
        public  List<Player> AuxPlayersList { get; set; }
        public List<Player> PlayersList { get; set; }
        public List<Battle> BattleList { get; set; }
        public List<Pokemon> PokemonsList { get; set; }
        public Player Winner { get; set; }

        //Checks if a Tournament Manager instance exists, if it does not exist, creates a new one and returns the Tournament Manager instance.
        public static TournamentManager GetInstance {
            get {
                if (_instance == null) _instance = new TournamentManager();
                return _instance;
            }
        }

        //Reset some objects
        public void Reset() {
            this.TournamentSize = 0;
            this.PlayersList.Clear();
            this.BattleList.Clear();
            this.AuxPlayersList.Clear();
            Winner = null;
        }
    }
}
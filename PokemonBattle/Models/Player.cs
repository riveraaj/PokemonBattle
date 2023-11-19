using System.Collections.Generic;

namespace PokemonBattle.Models{
    public partial class Player {
        public Player() {
            this.BattlesPlayerOne = new HashSet<Battle>();
            this.BattlesPlayerTwo = new HashSet<Battle>();
            this.BattlesPlayerWinner = new HashSet<Battle>();
            this.Tournaments = new HashSet<Tournament>();
        }
        
        //Table Properties
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public int TeamID { get; set; }
    
        //References ForeignKey
        public virtual ICollection<Battle> BattlesPlayerOne { get; set; }
        public virtual ICollection<Battle> BattlesPlayerTwo { get; set; }
        public virtual ICollection<Battle> BattlesPlayerWinner { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<Tournament> Tournaments{ get; set; }
    }
}
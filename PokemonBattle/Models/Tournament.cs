using System.Collections.Generic;

namespace PokemonBattle.Models { 
    public partial class Tournament {
        public Tournament() => this.BattlesTournament = new HashSet<Battle>();
        
        //Table Properties
        public int tournamentID { get; set; }
        public int winnerID { get; set; }
    

        //References ForeignKey
        public virtual ICollection<Battle> BattlesTournament { get; set; }
        public virtual Player PlayerTournament { get; set; }
    }
}
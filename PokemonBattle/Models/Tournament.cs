using System.Collections.Generic;

namespace PokemonBattle.Models { 
    public partial class Tournament {
        public Tournament() => this.Battles = new HashSet<Battle>();
        
        //Table Properties
        public int TournamentID { get; set; }
        public int WinnerID { get; set; }
    

        //References ForeignKey
        public virtual ICollection<Battle> Battles { get; set; }
        public virtual Player Winner { get; set; }
    }
}
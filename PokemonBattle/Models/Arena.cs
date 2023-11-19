using System.Collections.Generic;

namespace PokemonBattle.Models {
    public partial class Arena {
        public Arena() =>  this.BattlesArena = new HashSet<Battle>();
       
        //Table Properties
        public int ArenaID { get; set; }
        public int TypeElementID { get; set; }
    
        //References ForeignKey
        public virtual TypeElement TypeElementArena { get; set; }
        public virtual ICollection<Battle> BattlesArena { get; set; }
    }
}
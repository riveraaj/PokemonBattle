using System.Collections.Generic;

namespace PokemonBattle.Models {
    public partial class Arena {
        public Arena() =>  this.Battles = new HashSet<Battle>();
       
        //Table Properties
        public int ArenaID { get; set; }
        public int TypeElementID { get; set; }
    
        //References ForeignKey
        public virtual TypeElement TypeElement{ get; set; }
        public virtual ICollection<Battle> Battles { get; set; }
    }
}
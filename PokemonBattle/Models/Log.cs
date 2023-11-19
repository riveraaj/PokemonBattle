using System.Collections.Generic;

namespace PokemonBattle.Models {
    public partial class Log {
       
        public Log() => this.Battles = new HashSet<Battle>();
  
        //Table Properties
        public int LogID { get; set; }
        public string LogDescription { get; set; }
    
        //References ForeignKey
        public virtual ICollection<Battle> Battles { get; set; }
    }
}
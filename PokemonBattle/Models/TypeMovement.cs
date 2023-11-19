using System.Collections.Generic;

namespace PokemonBattle.Models {  
    public partial class TypeMovement {
        public TypeMovement() => this.MovementsTypeMovement = new HashSet<Movement>();

        //Table Properties
        public int TypeMovementID { get; set; }
        public string TypeMovementName { get; set; }

        //References ForeignKey
        public virtual ICollection<Movement> MovementsTypeMovement { get; set; }
    }
}
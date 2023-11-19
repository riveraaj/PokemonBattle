using System.Collections.Generic;

namespace PokemonBattle.Models {
    public partial class Movement {
        public Movement() {
            this.PokemonsOneMovement = new HashSet<Pokemon>();
            this.PokemonsTwoMovement = new HashSet<Pokemon>();
            this.PokemonsThreeMovement = new HashSet<Pokemon>();
            this.PokemonsFourMovement = new HashSet<Pokemon>();
        }
    
        //Table Properties
        public int MovementID { get; set; }
        public string MovementName { get; set; }
        public int MovementPower { get; set; }
        public int TypeMovementID { get; set; }

        //Refereces ForeingKey
        public virtual TypeMovement TypeMovement { get; set; }
        public virtual ICollection<Pokemon> PokemonsOneMovement { get; set; }
        public virtual ICollection<Pokemon> PokemonsTwoMovement { get; set; }
        public virtual ICollection<Pokemon> PokemonsThreeMovement { get; set; }
        public virtual ICollection<Pokemon> PokemonsFourMovement { get; set; }
    }
}
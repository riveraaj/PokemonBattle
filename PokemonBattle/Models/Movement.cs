using System.Collections.Generic;

namespace PokemonBattle.Models {
    public partial class Movement {
        public Movement() {
            this.PokemonsOne = new HashSet<Pokemon>();
            this.PokemonsTwo = new HashSet<Pokemon>();
            this.PokemonsThree = new HashSet<Pokemon>();
            this.PokemonsFour = new HashSet<Pokemon>();
        }
    
        //Table Properties
        public int MovementID { get; set; }
        public string MovementName { get; set; }
        public int MovementPower { get; set; }
        public int TypeMovementID { get; set; }

        //Refereces ForeingKey
        public virtual TypeMovement TypeMovement { get; set; }
        public virtual ICollection<Pokemon> PokemonsOne { get; set; }
        public virtual ICollection<Pokemon> PokemonsTwo { get; set; }
        public virtual ICollection<Pokemon> PokemonsThree { get; set; }
        public virtual ICollection<Pokemon> PokemonsFour { get; set; }
    }
}
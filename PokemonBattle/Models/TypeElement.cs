using System.Collections.Generic;

namespace PokemonBattle.Models {
    public partial class TypeElement {
        public TypeElement() {
            this.Arenas = new HashSet<Arena>();
            this.PokemonsOne = new HashSet<Pokemon>();
            this.PokemonsTwo = new HashSet<Pokemon>();
        }

        //Table Properties
        public int TypeElementID { get; set; }
        public string TypeElementName { get; set; }

        //Reference ForeignKey
        public virtual ICollection<Arena> Arenas { get; set; }
        public virtual ICollection<Pokemon> PokemonsOne{ get; set; }
        public virtual ICollection<Pokemon> PokemonsTwo { get; set; }
    }
}
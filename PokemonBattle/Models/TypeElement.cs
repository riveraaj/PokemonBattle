using System.Collections.Generic;

namespace PokemonBattle.Models {
    public partial class TypeElement {
        public TypeElement() {
            this.ArenasTypeElement = new HashSet<Arena>();
            this.PokemonsOneTypeElement = new HashSet<Pokemon>();
            this.PokemonsTwoTypeElement = new HashSet<Pokemon>();
        }

        //Table Properties
        public int TypeElementID { get; set; }
        public string TypeElementName { get; set; }

        //Reference ForeignKey
        public virtual ICollection<Arena> ArenasTypeElement { get; set; }
        public virtual ICollection<Pokemon> PokemonsOneTypeElement { get; set; }
        public virtual ICollection<Pokemon> PokemonsTwoTypeElement { get; set; }
    }
}
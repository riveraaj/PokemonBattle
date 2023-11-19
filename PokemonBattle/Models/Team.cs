using System.Collections.Generic;

namespace PokemonBattle.Models {   
    public partial class Team {
        public Team() => this.PlayersTeam = new HashSet<Player>();
        
        //Table Properties
        public int TeamID { get; set; }
        public int PokemonOneID { get; set; }
        public int PokemonTwoID { get; set; }
        public int PokemonThreeID { get; set; }
        public int PokemonFourID { get; set; }
        public int PokemonFiveID { get; set; }
        public int PokemonSixID { get; set; }
    
        //References ForeignKey
        public virtual ICollection<Player> PlayersTeam { get; set; }
        public virtual Pokemon PokemonOneTeam { get; set; }
        public virtual Pokemon PokemonTwoTeam { get; set; }
        public virtual Pokemon PokemonThreeTeam { get; set; }
        public virtual Pokemon PokemonFourTeam { get; set; }
        public virtual Pokemon PokemonFiveTeam { get; set; }
        public virtual Pokemon PokemonSixTeam { get; set; }
    }
}
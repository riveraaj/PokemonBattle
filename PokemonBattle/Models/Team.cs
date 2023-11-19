using System.Collections.Generic;

namespace PokemonBattle.Models {   
    public partial class Team {
        public Team() => this.Players = new HashSet<Player>();

        //Table Properties
        public int TeamID { get; set; }
        public int PokemonOneID { get; set; }
        public int PokemonTwoID { get; set; }
        public int PokemonThreeID { get; set; }
        public int PokemonFourID { get; set; }
        public int PokemonFiveID { get; set; }
        public int PokemonSixID { get; set; }
    
        //References ForeignKey
        public virtual ICollection<Player> Players { get; set; }
        public virtual Pokemon PokemonOne { get; set; }
        public virtual Pokemon PokemonTwo { get; set; }
        public virtual Pokemon PokemonThree { get; set; }
        public virtual Pokemon PokemonFour { get; set; }
        public virtual Pokemon PokemonFive { get; set; }
        public virtual Pokemon PokemonSix { get; set; }
    }
}
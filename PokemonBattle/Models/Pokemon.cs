using System;
using System.Collections.Generic;

namespace PokemonBattle.Models { 
    public partial class Pokemon {
        public Pokemon() {
            this.TeamsPokemonOne = new HashSet<Team>();
            this.TeamsPokemonTwo = new HashSet<Team>();
            this.TeamsPokemonThree = new HashSet<Team>();
            this.TeamsPokemonFour = new HashSet<Team>();
            this.TeamsPokemonFive = new HashSet<Team>();
            this.TeamsPokemonSix = new HashSet<Team>();
        }
        
        //Table Properties
        public int PokemonID { get; set; }
        public string PokemonName { get; set; }
        public string PokemonDescription { get; set; }
        public int TypeElementOneID { get; set; }
        public Nullable<int> TypeElementTwoID { get; set; }
        public int MovementOneID { get; set; }
        public int MovementTwoID { get; set; }
        public int MovementThreeID { get; set; }
        public int MovementFourID { get; set; }

        //References ForeignKey
        public virtual Movement MovementOne { get; set; }
        public virtual Movement MovementTwo { get; set; }
        public virtual Movement MovementThree { get; set; }
        public virtual Movement MovementFour { get; set; }
        public virtual TypeElement TypeElementOne { get; set; }
        public virtual TypeElement TypeElementTwo { get; set; }
        public virtual ICollection<Team> TeamsPokemonOne { get; set; }
        public virtual ICollection<Team> TeamsPokemonTwo { get; set; }
        public virtual ICollection<Team> TeamsPokemonThree { get; set; }
        public virtual ICollection<Team> TeamsPokemonFour { get; set; }
        public virtual ICollection<Team> TeamsPokemonFive { get; set; }
        public virtual ICollection<Team> TeamsPokemonSix { get; set; }
    }
}
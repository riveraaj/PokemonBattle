namespace PokemonBattle.Models {  
    public partial class Battle {

        //Table Properties
        public int BattleID { get; set; }
        public int TournamentID { get; set; }
        public int ArenaID { get; set; }
        public int PlayerOneID { get; set; }
        public int PlayerTwoID { get; set; }
        public int WinnerID { get; set; }
        public int LogID { get; set; }
    
        //References ForeignKey
        public virtual Arena Arena { get; set; }
        public virtual Log Log { get; set; }
        public virtual Player PlayerOne{ get; set; }
        public virtual Player PlayerTwo { get; set; }
        public virtual Tournament Tournament { get; set; }
        public virtual Player PlayerWinner { get; set; }
    }
}
namespace PokemonBattle.Models {  
    public partial class Battle {

        //Table Properties
        public int battleID { get; set; }
        public int tournamentID { get; set; }
        public int arenaID { get; set; }
        public int playerOneID { get; set; }
        public int playerTwoID { get; set; }
        public int winnerID { get; set; }
        public int logID { get; set; }
    
        //References ForeignKey
        public virtual Arena ArenaBattle { get; set; }
        public virtual Log LogBattle { get; set; }
        public virtual Player PlayerOneBattle { get; set; }
        public virtual Player PlayerTwoBattle { get; set; }
        public virtual Tournament TournamentBattle { get; set; }
        public virtual Player PlayerWinnerBattle { get; set; }
    }
}
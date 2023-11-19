namespace PokemonBattle.Models {
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PokemonEntities : DbContext {
        public PokemonEntities() : base("name=PokemonEntities") { }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Arena> Arenas { get; set; }
        public virtual DbSet<Battle> Battles { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Movement> Movements { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Pokemon> Pokemons { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Tournament> Tournaments { get; set; }
        public virtual DbSet<TypeElement> TypeElements { get; set; }
        public virtual DbSet<TypeMovement> TypeMovements { get; set; }
    }
}
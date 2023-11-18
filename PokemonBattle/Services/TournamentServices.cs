using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Services
{
    internal class TournamentServices {

        public static TournamentServices _instance;

        public TournamentServices() { 
        
        
        }

        public static TournamentServices GetInstance {
            get {
                if (_instance == null) _instance = new TournamentServices();
                return _instance;
            }
        }

        public void Reset() {

        }
    }
}
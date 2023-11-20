using PokemonBattle.Services;
using PokemonBattle.View;
using System.Windows.Forms;

namespace PokemonBattle.Controllers {
    internal class PrincipalController {

        //Instances
        private PrincipalForm _principalForm;
        private TournamentManager _tournamentServices;

        public PrincipalController(PrincipalForm oPrincipalForm){  
            this._principalForm = oPrincipalForm;
            InitInstance();
            AddEventsToComponents();
        }

        //Init instances
        private void InitInstance() {
            _tournamentServices = TournamentManager.GetInstance;
            _tournamentServices.InitInstances();
        }

        //Adding events to components
        private void AddEventsToComponents() => _principalForm.KeyPress += new KeyPressEventHandler(OpenInitTournamentForm);

        //Event to Open a Init Tournament Form
        private  void OpenInitTournamentForm(object sender, KeyPressEventArgs e) => new InitTournamentForm().Show();
    }
}
using PokemonBattle.Services;
using PokemonBattle.View;
using System.Windows.Forms;

namespace PokemonBattle.Controllers {
    internal class PrincipalController {

        private PrincipalForm _principalForm;
        private TournamentManager _tournamentServices;

        public PrincipalController(PrincipalForm oPrincipalForm){
            this._principalForm = oPrincipalForm;
            InitInstance();
            _principalForm.KeyPress += new KeyPressEventHandler(OpenInitTournamentForm);
        }

        private void InitInstance() {
            _tournamentServices = TournamentManager.GetInstance;
            _tournamentServices.InitInstances();
        }

        private  void OpenInitTournamentForm(object sender, KeyPressEventArgs e) => new InitTournamentForm().Show();
    }
}
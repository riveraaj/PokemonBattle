using PokemonBattle.Services;
using PokemonBattle.View;
using System.Collections.Generic;
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
        private void OpenInitTournamentForm(object sender, KeyPressEventArgs e) {
            _tournamentServices.Reset();
            CloseFormsOpen();
            new InitTournamentForm().Show();
        }

        //This event closes all open forms
        private void CloseFormsOpen() {
            // Create a temporary list to store the forms to be closed.
            List<Form> formsToClose = new List<Form>();

            // Iterate through the collection of open forms.
            foreach (Form form in Application.OpenForms) 
                // Check if the form is not the main form.
                if (form != _principalForm) formsToClose.Add(form);

            // Close the forms stored in the temporary list.
            foreach (Form form in formsToClose) form.Close();
        }
    }
}
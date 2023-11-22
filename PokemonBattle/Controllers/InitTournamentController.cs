using PokemonBattle.Services;
using PokemonBattle.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PokemonBattle.Controllers {
    internal class InitTournamentController {

        //Instances
        private BotService _botService;
        private List<string> playersName;   
        private PlayerService _playerService;
        private TournamentManager _tournamentManager;
        private readonly InitTournamentForm _initTournamentForm;

        public InitTournamentController(InitTournamentForm oInitTournamentForm) {
            this._initTournamentForm = oInitTournamentForm;
            InitInstance();
            AddEventsToComponents();
        }

        //Init Intances
        private void InitInstance() {
            this._botService = new BotService();
            this.playersName = new List<string>();
            this._playerService = new PlayerService();
            this._tournamentManager = TournamentManager.GetInstance;
        }

        //Adding events to components
        private void AddEventsToComponents() => _initTournamentForm.btnNextPlayersForm.Click += new EventHandler(OpenPlayersForm);
        

        //Save Tournament Size in Singleton Tournament Manager
        public void SaveTournamentSize(int size) => _tournamentManager.TournamentSize = size;

        //Generate Bots with Bot Service Class based on the Size of the Tournament and the Numbers of Players
        public void GenerateBots(int size, int numberOfPlayers) {
            int numberOfBots = size - numberOfPlayers;
            for (int i = 0; i < numberOfBots; i++) {
                _botService.CreateBot();
            }
        }

        //Generate Players with the Player Service Class based on the List Size
        public void GeneratePlayers(List<string> playerNames) => playerNames.ForEach(x => _playerService.CreatePlayer(x));

        //Event to Open a Players Form
        private void OpenPlayersForm(object sender, EventArgs e) {
            bool allNoEmpty = true;
            bool noDuplicates = true;

            List<string> enteredNames = new List<string>();

            foreach (TextBox textBox in _initTournamentForm.TextBoxes) { //Scroll through all entries in the list
                if (string.IsNullOrEmpty(textBox.Text)) {
                    allNoEmpty = false;
                    break; // You can exit the loop as soon as you find an empty one, or you can continue and mark all the empty ones.
                }
                else {
                    if (enteredNames.Contains(textBox.Text)) { // Check whether the name has already been entered
                        noDuplicates = false;
                        break; // You can exit the loop as soon as you find a duplicate name.
                    }
                    enteredNames.Add(textBox.Text);
                }
            }

            if (allNoEmpty && noDuplicates)  { //If no gaps or duplicates are found, the information is stored in the TournamnetManager singleton.
                _initTournamentForm.labelWarning.Visible = false;
                SaveTournamentSize(_initTournamentForm.SizeTournament);
                GenerateBots(_initTournamentForm.SizeTournament, _initTournamentForm.NumberPlayers);
                _initTournamentForm.TextBoxes.ForEach(x => playersName.Add(x.Text));
                GeneratePlayers(playersName);
                new PlayersForm().Show();
                _initTournamentForm.Close();
            }
            else { //Show an error message
                _initTournamentForm.labelWarning.Visible = true;
                if (!noDuplicates) {
                    _initTournamentForm.labelWarning.Visible = false;
                    MessageBox.Show("Duplicate names are not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
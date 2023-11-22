using PokemonBattle.Models;
using PokemonBattle.Services;
using PokemonBattle.View;
using PokemonBattle.Views;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PokemonBattle.Controllers {
    internal class PokedexController {

        //Intances
        private int pokemonPosition;
        private int pokemonCount;
        private PokedexForm _pokedexForm;
        private TournamentManager _tournamentManager;
        private Team _team;

        public PokedexController(PokedexForm oPokedexForm) {
            this._pokedexForm = oPokedexForm;
            InitInstances();
            AddEventsToComponents();
            InitComponents();
            LoadPokedexInLayout();
        }

        //Init Instances
        private void InitInstances() {
            this.pokemonPosition = 0;
            this.pokemonCount = 0;
            this._tournamentManager = TournamentManager.GetInstance;
            this._team = new Team();
        }

        //Init Componentes of Pokedex Form
        public void InitComponents() {
            //btnBack
            if (_pokedexForm.allPlayersHaveATeam) _pokedexForm.btnBack.Text = "NEXT";
            else _pokedexForm.btnBack.Text = "BACK";
            //txtDescription
            _pokedexForm.txtDescription.ReadOnly = true;
            _pokedexForm.txtDescription.BackColor = Color.White;
            //lblPokemonID
            _pokedexForm.lblPokemonID.AutoSize = false;
            _pokedexForm.lblPokemonID.TextAlign = ContentAlignment.MiddleCenter;
            //lblName
            _pokedexForm.lblName.AutoSize = false;
            _pokedexForm.lblName.TextAlign = ContentAlignment.MiddleCenter;
            //lblTypeOne
            _pokedexForm.lblTypeOne.AutoSize = false;
            _pokedexForm.lblTypeOne.TextAlign = ContentAlignment.MiddleCenter;
            //lblTypeTwo
            _pokedexForm.lblTypeTwo.AutoSize = false;
            _pokedexForm.lblTypeTwo.TextAlign = ContentAlignment.MiddleCenter;
        }

        //Adding events to components
        private void AddEventsToComponents() {
            _pokedexForm.btnBack.Click += new EventHandler(OpenBracketFormOrPlayersForm);
            _pokedexForm.btnNextPokemon.Click += new EventHandler(NextPokemon);
            _pokedexForm.btnPreviousPokemon.Click += new EventHandler(PreviousPokemon);
            _pokedexForm.btnAddPokemon.Click += new EventHandler(AddPokemon);
        }
        
        //Event to move to the next pokemon on the list
        private void AddPokemon(object sender, EventArgs e) {
            switch (pokemonCount) {
                case 0: LoadPokemonInPctureBox(_pokedexForm.picBoxPokemon1); break;
                case 1: LoadPokemonInPctureBox(_pokedexForm.picBoxPokemon2); break;
                case 2: LoadPokemonInPctureBox(_pokedexForm.picBoxPokemon3); break;
                case 3: LoadPokemonInPctureBox(_pokedexForm.picBoxPokemon4); break;
                case 4: LoadPokemonInPctureBox(_pokedexForm.picBoxPokemon5); break;
                case 5: LoadPokemonInPctureBox(_pokedexForm.picBoxPokemon6); break;
            }
        }

        //Load pokemon added in the PictureBox
        private void LoadPokemonInPctureBox(PictureBox oPictureBox){
            int pokemonID = _tournamentManager.PokemonsList[pokemonPosition].PokemonID;
            if (_team.PokemonOneID != pokemonID && _team.PokemonTwoID != pokemonID
                 && _team.PokemonThreeID != pokemonID && _team.PokemonFourID != pokemonID
                 && _team.PokemonFiveID != pokemonID && _team.PokemonSixID != pokemonID) {
                oPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject($"_{pokemonID}");
                oPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                SavePokemonInTeamPlayer();
                pokemonCount++;
            }  else MessageBox.Show("No two pokemon can be the same in the team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //
        private void SavePokemonInTeamPlayer(){
            switch (pokemonCount) {
                case 0: _team.PokemonOneID = Convert.ToInt32(_pokedexForm.lblPokemonID.Text); break;
                case 1: _team.PokemonTwoID = Convert.ToInt32(_pokedexForm.lblPokemonID.Text); break;
                case 2: _team.PokemonThreeID = Convert.ToInt32(_pokedexForm.lblPokemonID.Text); break;
                case 3: _team.PokemonFourID = Convert.ToInt32(_pokedexForm.lblPokemonID.Text); break;
                case 4: _team.PokemonFiveID = Convert.ToInt32(_pokedexForm.lblPokemonID.Text); break;
                case 5: _team.PokemonSixID = Convert.ToInt32(_pokedexForm.lblPokemonID.Text); break;
            }  
        }

        //Event to move to the next pokemon on the list
        private void NextPokemon(object sender, EventArgs e) {
            if (pokemonPosition == 106) pokemonPosition = 0;
            else pokemonPosition++;
            LoadPokedexInLayout();
        }

        //Event to move to the previous pokemon on the list
        private void PreviousPokemon(object sender, EventArgs e){
            if (pokemonPosition == 0) pokemonPosition = 106;
            else pokemonPosition--;
            LoadPokedexInLayout();
        }

        //Event to Go to bracket form if all players have a team or Go to Player Form
        private void OpenBracketFormOrPlayersForm(object sender, EventArgs e) {
            if (_team.PokemonOneID != 0 && _team.PokemonTwoID != 0 
                && _team.PokemonThreeID != 0 && _team.PokemonFourID != 0 
                && _team.PokemonFiveID != 0 && _team.PokemonSixID != 0)  {
                string prefix = "btnPlayer";
                string playerName = _pokedexForm.namePlayer.Substring(prefix.Length);

                Player oPlayer = _tournamentManager.PlayersList.FirstOrDefault(x => x.PlayerName == playerName);
                oPlayer.Team = _team;
                if (_pokedexForm.allPlayersHaveATeam) new BracketForm().Show();
                else new PlayersForm().Show();
                _pokedexForm.Close();
            } else MessageBox.Show("You have to choose your entire team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }

        public void LoadPokedexInLayout() {
            _pokedexForm.lblTypeTwo.Text = "";
            _pokedexForm.lblPokemonID.Text = $"0{_tournamentManager.PokemonsList[pokemonPosition].PokemonID}";
            _pokedexForm.picBoxPokemon.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"_{_tournamentManager.PokemonsList[pokemonPosition].PokemonID}");
            _pokedexForm.lblName.Text = _tournamentManager.PokemonsList[pokemonPosition].PokemonName;
            _pokedexForm.lblTypeOne.Text = _tournamentManager.PokemonsList[pokemonPosition].TypeElementOne.TypeElementName;
            if (_tournamentManager.PokemonsList[pokemonPosition].TypeElementTwoID != null) _pokedexForm.lblTypeTwo.Text = _tournamentManager.PokemonsList[pokemonPosition].TypeElementTwo.TypeElementName;
            _pokedexForm.txtDescription.Text = _tournamentManager.PokemonsList[pokemonPosition].PokemonDescription;
        }
    }
}
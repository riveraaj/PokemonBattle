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
            LoadPokedexInLayout();
        }

        //Init Instances
        private void InitInstances() {
            this.pokemonPosition = 0;
            this.pokemonCount = 0;
            this._tournamentManager = TournamentManager.GetInstance;
            this._team = new Team();
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
                default: MessageBox.Show("You have already selected all your equipment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
        }

        //Load pokemon added in the PictureBox
        private void LoadPokemonInPctureBox(PictureBox oPictureBox){
            int pokemonID = _tournamentManager.PokemonsList[pokemonPosition].PokemonID;
            //Validate that the selected pokemon is not in the team.
            if (_team.PokemonOneID != pokemonID && _team.PokemonTwoID != pokemonID
                 && _team.PokemonThreeID != pokemonID && _team.PokemonFourID != pokemonID
                 && _team.PokemonFiveID != pokemonID && _team.PokemonSixID != pokemonID) {
                oPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject($"_{pokemonID}");
                oPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                SavePokemonInTeamPlayer();
                pokemonCount++;
            }  else MessageBox.Show("No two pokemon can be the same in the team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Save for each selected pokemon its id to a global variable of type Team.
        private void SavePokemonInTeamPlayer(){
            switch (pokemonCount) {
                case 0: _team.PokemonOneID = Convert.ToInt32(_pokedexForm.lblPokemonID.Text.Split('#')[1]); break;
                case 1: _team.PokemonTwoID = Convert.ToInt32(_pokedexForm.lblPokemonID.Text.Split('#')[1]); break;
                case 2: _team.PokemonThreeID = Convert.ToInt32(_pokedexForm.lblPokemonID.Text.Split('#')[1]); break;
                case 3: _team.PokemonFourID = Convert.ToInt32(_pokedexForm.lblPokemonID.Text.Split('#')[1]); break;
                case 4: _team.PokemonFiveID = Convert.ToInt32(_pokedexForm.lblPokemonID.Text.Split('#')[1]); break;
                case 5: _team.PokemonSixID = Convert.ToInt32(_pokedexForm.lblPokemonID.Text.Split('#')[1]); break;
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
            //Validate if the equipment is already complete
            if (_team.PokemonOneID != 0 && _team.PokemonTwoID != 0 
                && _team.PokemonThreeID != 0 && _team.PokemonFourID != 0 
                && _team.PokemonFiveID != 0 && _team.PokemonSixID != 0)  {
                string prefix = "btnPlayer";
                string playerName = _pokedexForm.namePlayer.Substring(prefix.Length);

                //Search for a player by name to assign equipment
                Player oPlayer = _tournamentManager.PlayersList.FirstOrDefault(x => x.PlayerName == playerName);
                oPlayer.Team = _team;

                //Validate if all players already have an equipment
                if (_pokedexForm.allPlayersHaveATeam) new BracketForm().Show();
                else new PlayersForm().Show();
                _pokedexForm.Close();
            } else MessageBox.Show("You have to choose your entire team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }

        public void LoadPokedexInLayout() {
            //Clear PictureBoxTypeElement
            _pokedexForm.picBoxType1.BackgroundImage = null;
            _pokedexForm.picBoxType2.BackgroundImage = null;

            //Pokemon card
            _pokedexForm.lblPokemonID.Text = $"#{_tournamentManager.PokemonsList[pokemonPosition].PokemonID}";
            _pokedexForm.picBoxPokemon.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"_{_tournamentManager.PokemonsList[pokemonPosition].PokemonID}");
            _pokedexForm.lblName.Text = _tournamentManager.PokemonsList[pokemonPosition].PokemonName;
            SetImageForPokemonElementType(_pokedexForm.picBoxType1, 1);
            _pokedexForm.txtDescription.Text = _tournamentManager.PokemonsList[pokemonPosition].PokemonDescription;

            //Validate if a pokemon has a second element type
            if (_tournamentManager.PokemonsList[pokemonPosition].TypeElementTwoID != null)
                SetImageForPokemonElementType(_pokedexForm.picBoxType2, 0);

            //Movements of the pokemon
            _pokedexForm.lblMovement1.Text = _tournamentManager.PokemonsList[pokemonPosition].MovementOne.MovementName;
            _pokedexForm.lblMovement2.Text = _tournamentManager.PokemonsList[pokemonPosition].MovementTwo.MovementName;
            _pokedexForm.lblMovement3.Text = _tournamentManager.PokemonsList[pokemonPosition].MovementThree.MovementName;
            _pokedexForm.lblMovement4.Text = _tournamentManager.PokemonsList[pokemonPosition].MovementFour.MovementName;

            //Power of pokemon movements
            _pokedexForm.lblMovementPower1.Text = _tournamentManager.PokemonsList[pokemonPosition].MovementOne.MovementPower.ToString();
            _pokedexForm.lblMovementPower2.Text = _tournamentManager.PokemonsList[pokemonPosition].MovementTwo.MovementPower.ToString();
            _pokedexForm.lblMovementPower3.Text = _tournamentManager.PokemonsList[pokemonPosition].MovementThree.MovementPower.ToString();
            _pokedexForm.lblMovementPower4.Text = _tournamentManager.PokemonsList[pokemonPosition].MovementFour.MovementPower.ToString();

            //Type of pokemon movements
            _pokedexForm.lblMovementType1.Text = _tournamentManager.PokemonsList[pokemonPosition].MovementOne.TypeMovement.TypeMovementName;
            _pokedexForm.lblMovementType2.Text = _tournamentManager.PokemonsList[pokemonPosition].MovementTwo.TypeMovement.TypeMovementName;
            _pokedexForm.lblMovementType3.Text = _tournamentManager.PokemonsList[pokemonPosition].MovementThree.TypeMovement.TypeMovementName;
            _pokedexForm.lblMovementType4.Text = _tournamentManager.PokemonsList[pokemonPosition].MovementFour.TypeMovement.TypeMovementName;
            _pokedexForm.txtDescription.Text = _tournamentManager.PokemonsList[pokemonPosition].PokemonDescription;
        }

        public void SetImageForPokemonElementType(PictureBox oPictureBox, int numberType) {
            if (numberType == 1) {
                switch (_tournamentManager.PokemonsList[pokemonPosition].TypeElementOne.TypeElementName) {
                    case "Fairy": oPictureBox.BackgroundImage = Properties.Resources.Fairy; break;
                    case "Steel": oPictureBox.BackgroundImage = Properties.Resources.Steel; break;
                    case "Dark": oPictureBox.BackgroundImage = Properties.Resources.Dark; break;
                    case "Dragon": oPictureBox.BackgroundImage = Properties.Resources.Dragon; break;
                    case "Ghost": oPictureBox.BackgroundImage = Properties.Resources.Ghost; break;
                    case "Rock": oPictureBox.BackgroundImage = Properties.Resources.Rock; break;
                    case "Bug": oPictureBox.BackgroundImage = Properties.Resources.Bug; break;
                    case "Psychc": oPictureBox.BackgroundImage = Properties.Resources.Psychc; break;
                    case "Flying": oPictureBox.BackgroundImage = Properties.Resources.Flying; break;
                    case "Ground": oPictureBox.BackgroundImage = Properties.Resources.Ground; break;
                    case "Poison": oPictureBox.BackgroundImage = Properties.Resources.Poison; break;
                    case "Fight": oPictureBox.BackgroundImage = Properties.Resources.Fight; break;
                    case "Ice": oPictureBox.BackgroundImage = Properties.Resources.Ice; break;
                    case "Grass": oPictureBox.BackgroundImage = Properties.Resources.Grass; break;
                    case "Electr": oPictureBox.BackgroundImage = Properties.Resources.Electr; break;
                    case "Water": oPictureBox.BackgroundImage = Properties.Resources.Water; break;
                    case "Fire": oPictureBox.BackgroundImage = Properties.Resources.Fire; break;
                    case "Normal": oPictureBox.BackgroundImage = Properties.Resources.Normal; break;
                }
            }
            else {
                switch (_tournamentManager.PokemonsList[pokemonPosition].TypeElementTwo.TypeElementName) {
                    case "Fairy": oPictureBox.BackgroundImage = Properties.Resources.Fairy; break;
                    case "Steel": oPictureBox.BackgroundImage = Properties.Resources.Steel; break;
                    case "Dark": oPictureBox.BackgroundImage = Properties.Resources.Dark; break;
                    case "Dragon": oPictureBox.BackgroundImage = Properties.Resources.Dragon; break;
                    case "Ghost": oPictureBox.BackgroundImage = Properties.Resources.Ghost; break;
                    case "Rock": oPictureBox.BackgroundImage = Properties.Resources.Rock; break;
                    case "Bug": oPictureBox.BackgroundImage = Properties.Resources.Bug; break;
                    case "Psychc": oPictureBox.BackgroundImage = Properties.Resources.Psychc; break;
                    case "Flying": oPictureBox.BackgroundImage = Properties.Resources.Flying; break;
                    case "Ground": oPictureBox.BackgroundImage = Properties.Resources.Ground; break;
                    case "Poison": oPictureBox.BackgroundImage = Properties.Resources.Poison; break;
                    case "Fight": oPictureBox.BackgroundImage = Properties.Resources.Fight; break;
                    case "Ice": oPictureBox.BackgroundImage = Properties.Resources.Ice; break;
                    case "Grass": oPictureBox.BackgroundImage = Properties.Resources.Grass; break;
                    case "Electr": oPictureBox.BackgroundImage = Properties.Resources.Electr; break;
                    case "Water": oPictureBox.BackgroundImage = Properties.Resources.Water; break;
                    case "Fire": oPictureBox.BackgroundImage = Properties.Resources.Fire; break;
                    case "Normal": oPictureBox.BackgroundImage = Properties.Resources.Normal; break;
                }
            }
        }
    }
}
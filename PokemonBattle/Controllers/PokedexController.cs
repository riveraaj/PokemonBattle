using PokemonBattle.Models;
using PokemonBattle.Services;
using PokemonBattle.View;
using PokemonBattle.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PokemonBattle.Controllers {
    internal class PokedexController{

        //Intances & Variables
        private Team _team;
        private int pokemonCount;
        private int pokemonPosition;
        private PokedexForm _pokedexForm;
        private PokedexService _pokedexService; 

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
            this._pokedexService = new PokedexService();
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
                case 0: LoadPokemonInPictureBox(_pokedexForm.picBoxPokemon1); break;
                case 1: LoadPokemonInPictureBox(_pokedexForm.picBoxPokemon2); break;
                case 2: LoadPokemonInPictureBox(_pokedexForm.picBoxPokemon3); break;
                case 3: LoadPokemonInPictureBox(_pokedexForm.picBoxPokemon4); break;
                case 4: LoadPokemonInPictureBox(_pokedexForm.picBoxPokemon5); break;
                case 5: LoadPokemonInPictureBox(_pokedexForm.picBoxPokemon6); break;
                default: MessageBox.Show("You have already selected all your equipment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
        }

        //Load pokemon added in the PictureBox
        private void LoadPokemonInPictureBox(PictureBox oPictureBox) {
            int pokemonID = _pokedexService.GetPokemonByPositionOnList(pokemonPosition).PokemonID;
            //Validate that the selected pokemon is not in the team.
            if (_team.PokemonOneID != pokemonID && _team.PokemonTwoID != pokemonID
                 && _team.PokemonThreeID != pokemonID && _team.PokemonFourID != pokemonID
                 && _team.PokemonFiveID != pokemonID && _team.PokemonSixID != pokemonID) {
                oPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject($"_{pokemonID}");
                oPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                SavePokemonInTeamPlayer();
                pokemonCount++;
            }
            else MessageBox.Show("No two pokemon can be the same in the team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Save for each selected pokemon its id to a global variable of type Team.
        private void SavePokemonInTeamPlayer() {
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
        private void PreviousPokemon(object sender, EventArgs e) {
            if (pokemonPosition == 0) pokemonPosition = 106;
            else pokemonPosition--;
            LoadPokedexInLayout();
        }

        //Event to Go to bracket form if all players have a team or Go to Player Form
        private void OpenBracketFormOrPlayersForm(object sender, EventArgs e) {
            //Validate if the equipment is already complete
            if (_team.PokemonOneID != 0 && _team.PokemonTwoID != 0
                && _team.PokemonThreeID != 0 && _team.PokemonFourID != 0
                && _team.PokemonFiveID != 0 && _team.PokemonSixID != 0) {

                string prefix = "btnPlayer";
                string playerName = _pokedexForm.namePlayer.Substring(prefix.Length);

                //Assign equipment
                _pokedexService.SaveTeamPlayer(_team, playerName);

                //Validate if all players already have an equipment
                if (_pokedexForm.allPlayersHaveATeam) {
                    _pokedexService.SaveTeamAndTeam();
                    new BracketForm().Show();
                }
                else new PlayersForm().Show();
                _pokedexForm.Close();
            }
            else MessageBox.Show("You have to choose your entire team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void LoadPokedexInLayout() {
            //Instance Aux
            Pokemon oPokemon = _pokedexService.GetPokemonByPositionOnList(pokemonPosition);

            //Clear PictureBoxTypeElement
            _pokedexForm.picBoxType1.BackgroundImage = null;
            _pokedexForm.picBoxType2.BackgroundImage = null;

            //Pokemon card
            _pokedexForm.lblPokemonID.Text = $"#{oPokemon.PokemonID}";
            _pokedexForm.picBoxPokemon.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"_{oPokemon.PokemonID}");
            _pokedexForm.lblName.Text = oPokemon.PokemonName;
            SetImageForPokemonElementType(_pokedexForm.picBoxType1, 1);
            _pokedexForm.txtDescription.Text = oPokemon.PokemonDescription;

            //Validate if a pokemon has a second element type
            if (oPokemon.TypeElementTwoID != null)
                SetImageForPokemonElementType(_pokedexForm.picBoxType2, 0);

            //Movements of the pokemon
            _pokedexForm.lblMovement1.Text = oPokemon.MovementOne.MovementName;
            _pokedexForm.lblMovement2.Text = oPokemon.MovementTwo.MovementName;
            _pokedexForm.lblMovement3.Text = oPokemon.MovementThree.MovementName;
            _pokedexForm.lblMovement4.Text = oPokemon.MovementFour.MovementName;

            //Power of pokemon movements
            _pokedexForm.lblMovementPower1.Text = oPokemon.MovementOne.MovementPower.ToString();
            _pokedexForm.lblMovementPower2.Text = oPokemon.MovementTwo.MovementPower.ToString();
            _pokedexForm.lblMovementPower3.Text = oPokemon.MovementThree.MovementPower.ToString();
            _pokedexForm.lblMovementPower4.Text = oPokemon.MovementFour.MovementPower.ToString();

            //Type of pokemon movements
            _pokedexForm.lblMovementType1.Text = oPokemon.MovementOne.TypeMovement.TypeMovementName;
            _pokedexForm.lblMovementType2.Text = oPokemon.MovementTwo.TypeMovement.TypeMovementName;
            _pokedexForm.lblMovementType3.Text = oPokemon.MovementThree.TypeMovement.TypeMovementName;
            _pokedexForm.lblMovementType4.Text = oPokemon.MovementFour.TypeMovement.TypeMovementName;
            _pokedexForm.txtDescription.Text = oPokemon.PokemonDescription;
        }

        //Adds an image to a picture box according to the picturebox and item number
        public void SetImageForPokemonElementType(PictureBox oPictureBox, int numberType) {
            string typeElement = _pokedexService.GetTypeElementName(pokemonPosition, numberType);
            //Verify that the string is not null
            if (typeElement != "") oPictureBox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(typeElement);
        }
    }
}
using PokemonBattle.Models;
using PokemonBattle.Properties;
using PokemonBattle.Services;
using PokemonBattle.View;
using PokemonBattle.Views;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PokemonBattle.Controllers {
    internal class BracketController {

        //Instances & Variables
        private Player _playerWinner;  
        private BracketService _bracketService;
        private readonly BracketForm _bracketForm;
        private int tournamentSize, countForSemiFinals, countForQuarterFinals;

        public BracketController(BracketForm oBracketForm) {
            this._bracketForm = oBracketForm;
            InitInstances();
            InitLoad();
            InitTimer();
        }

        //Init Instances and viariables
        private void InitInstances(){
            countForSemiFinals = 0;
            countForQuarterFinals = 0;
            _bracketService = new BracketService();
            tournamentSize = _bracketService.GetSizeTournament();
            _playerWinner = _bracketService.GetWinner();
        }

        //Init MainLayout
        private void InitLoad() {
            if (tournamentSize == 16) LoadLayout(Resources.TournamentSixteen);
            else if (tournamentSize == 8) LoadLayout(Resources.TournamentEight);
            else LoadLayout(Resources.TournamentFour);
        }

        //Init Timer
        private void InitTimer(){
            _bracketForm.timer = new Timer {
                Interval = 10000 // 10 seconds
            };

            _bracketForm.timer.Tick += Timer_Tick;
            _bracketForm.timer.Start();
        }

        //Event to open a form after the set time of the timer
        private void Timer_Tick(object sender, EventArgs e){
            _bracketForm.timer.Stop();
            //Validates if there is a winner of the tournament
            if (_playerWinner != null){        
                DialogResult result = MessageBox.Show("Do you want to create another tournament or close the game?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Validates if the yes button was clicked.
                if (result == DialogResult.Yes) {
                    _bracketService.CleanTorunamentManager();
                    new InitTournamentForm().Show();
                } else Application.Exit();     
            } else new VersusForm(_bracketService.GetNextBattle()).Show();
            _bracketForm.Close();
        }

        //Load the information to the alyout of the form
        private void LoadLayout(Image backgroundImage) {
            // Sets the background image for the tournament
            _bracketForm.BackgroundImage = backgroundImage;

            // Variables aux
            int playerIndex = tournamentSize - 1;
            string labelName = (tournamentSize == 16) ? "lblUser" : (tournamentSize == 8) ? "lblUserQuarter" : "lblUserSemi";
            string pictureBoxName = (tournamentSize == 16) ? "picBoxUser" : (tournamentSize == 8) ? "picBoxUserQuarter" : "picBoxUserSemi";

            // Validate if there is a winner in the tournament
            ConfigWinner();

            //All components are to be configured with each player
            for (int i = 0; i <= tournamentSize + 1; i++) {
                //Validates that the components exist
                if (_bracketForm.Controls.Find($"{labelName}{i + 1}", true).FirstOrDefault() is Label playerLabel 
                    && _bracketForm.Controls.Find($"{pictureBoxName}{i + 1}", true).FirstOrDefault() is PictureBox playerPictureBox) {
                    var player = _bracketService.GetPlayerByPositionOnList(playerIndex);
                    //Validates that a player exists
                    if (player != null) { 
                        playerLabel.Text = player.PlayerName;
                        playerPictureBox.BackgroundImage = Resources.DefaultPlayerImage;
                    }
                }
                playerIndex--;
            }
            
            // Scroll through the list of players to see if they are in other rounds.
            foreach (var player in _bracketService.GetPlayerList())  {
                // Quarter
                if (player.IsInQuarter && tournamentSize == 16) ConfigQuarterFinals(player);

                // Semi
                if (player.IsInSemi && (tournamentSize == 16 || tournamentSize == 8) ) ConfigSemiFinals(player);

                // Finals
                if (player.IsInFinal && (tournamentSize == 16 || tournamentSize == 8 || tournamentSize == 4)) ConfigFinals(player);
            }
        }

        //If there is a winner, this method is called to load the winner's name and image.
        public void ConfigWinner() {
            //Validate if there is a winner in the tournament
            if (_playerWinner != null) {
                _bracketForm.lblWinner.Text = _playerWinner.PlayerName;
                _bracketForm.panelWinner.BackgroundImage = Resources.DefaultPlayerImage;
            }
        }

        //Upload information for the Quarterfinal round
        public void ConfigQuarterFinals(Player oPlayer) {
            // Check the count to determine the appropriate quarterfinal slot
            if (countForQuarterFinals <= 1) {
                // Check the availability of the background image
                if (_bracketForm.picBoxUserQuarter8.BackgroundImage != null) {
                    // Update the display for quarterfinal slot 
                    _bracketForm.lblUserQuarter7.Text = oPlayer.PlayerName;
                    _bracketForm.picBoxUserQuarter7.BackgroundImage = Resources.DefaultPlayerImage;
                    countForQuarterFinals++;
                } else {
                    // Update the display for quarterfinal slot 
                    _bracketForm.lblUserQuarter8.Text = oPlayer.PlayerName;
                    _bracketForm.picBoxUserQuarter8.BackgroundImage = Resources.DefaultPlayerImage;
                    countForQuarterFinals++;
                }
            } else if (countForQuarterFinals <= 3) {
                if (_bracketForm.picBoxUserQuarter6.BackgroundImage != null)  {
                    _bracketForm.lblUserQuarter5.Text = oPlayer.PlayerName;
                    _bracketForm.picBoxUserQuarter5.BackgroundImage = Resources.DefaultPlayerImage;
                    countForQuarterFinals++;
                } else {
                    _bracketForm.lblUserQuarter6.Text = oPlayer.PlayerName;
                    _bracketForm.picBoxUserQuarter6.BackgroundImage = Resources.DefaultPlayerImage;
                    countForQuarterFinals++;
                }
            } else if (countForQuarterFinals <= 5) {
                if (_bracketForm.picBoxUserQuarter4.BackgroundImage != null) {
                    _bracketForm.lblUserQuarter3.Text = oPlayer.PlayerName;
                    _bracketForm.picBoxUserQuarter3.BackgroundImage = Resources.DefaultPlayerImage;
                    countForQuarterFinals++;
                } else {
                    _bracketForm.lblUserQuarter4.Text = oPlayer.PlayerName;
                    _bracketForm.picBoxUserQuarter4.BackgroundImage = Resources.DefaultPlayerImage;
                    countForQuarterFinals++;
                }
            } else {
                if (_bracketForm.picBoxUserQuarter2.BackgroundImage != null){
                    _bracketForm.lblUserQuarter1.Text = oPlayer.PlayerName;
                    _bracketForm.picBoxUserQuarter1.BackgroundImage = Resources.DefaultPlayerImage;
                    countForQuarterFinals++;
                } else {
                    _bracketForm.lblUserQuarter2.Text = oPlayer.PlayerName;
                    _bracketForm.picBoxUserQuarter2.BackgroundImage = Resources.DefaultPlayerImage;
                    countForQuarterFinals++;
                }
            }
        }

        //Upload information for the Semifinal round
        public void ConfigSemiFinals(Player oPlayer) {
            // Check the count to determine the appropriate semifinal slot
            if (countForSemiFinals <= 1) {
                // Check the availability of the background image
                if (_bracketForm.picBoxUserSemi4.BackgroundImage != null) {
                    // Update the display for semifinal slot 
                    _bracketForm.lblUserSemi3.Text = oPlayer.PlayerName;
                    _bracketForm.picBoxUserSemi3.BackgroundImage = Resources.DefaultPlayerImage;
                    countForSemiFinals++;
                } else {
                    // Update the display for semifinal slot 
                    _bracketForm.lblUserSemi4.Text = oPlayer.PlayerName;
                    _bracketForm.picBoxUserSemi4.BackgroundImage = Resources.DefaultPlayerImage;
                    countForSemiFinals++;
                }
            } else {
                if (_bracketForm.picBoxUserSemi2.BackgroundImage != null) {
                    _bracketForm.lblUserSemi1.Text = oPlayer.PlayerName;
                    _bracketForm.picBoxUserSemi1.BackgroundImage = Resources.DefaultPlayerImage;
                } else {
                    _bracketForm.lblUserSemi2.Text = oPlayer.PlayerName;
                    _bracketForm.picBoxUserSemi2.BackgroundImage = Resources.DefaultPlayerImage;
                }
            }
        }

        //Upload information for the Final round
        public void ConfigFinals(Player oPlayer) {
            // Check the availability of the background image
            if (_bracketForm.picBoxUserFinal2.BackgroundImage != null) {
                // Update the display for final slot 
                _bracketForm.lblUserFinal1.Text = oPlayer.PlayerName;
                _bracketForm.picBoxUserFinal1.BackgroundImage = Resources.DefaultPlayerImage;
            } else {
                // Update the display for final slot 
                _bracketForm.lblUserFinal2.Text = oPlayer.PlayerName;
                _bracketForm.picBoxUserFinal2.BackgroundImage = Resources.DefaultPlayerImage;
            }
        }
    }
}
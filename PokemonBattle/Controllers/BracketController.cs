﻿using PokemonBattle.Models;
using PokemonBattle.Properties;
using PokemonBattle.Services;
using PokemonBattle.Views;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PokemonBattle.Controllers {
    internal class BracketController {

        //Instances and variables
        private int tournamentSize, countForSemiFinals, countForQuarterFinals;
        private Player _playerWinner;
        private BracketForm _bracketForm;
        private BracketService _bracketService;

        public BracketController(BracketForm oBracketForm) {
            this._bracketForm = oBracketForm;
            InitInstances();
            InitLoad();
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
                var playerLabel = _bracketForm.Controls.Find($"{labelName}{i + 1}", true).FirstOrDefault() as Label;
                var playerPictureBox = _bracketForm.Controls.Find($"{pictureBoxName}{i + 1}", true).FirstOrDefault() as PictureBox;

               //Validates that the components exist
                if (playerLabel != null && playerPictureBox != null) {
                    var player = _bracketService.GetPlayerByPositionOnList(playerIndex);

                    if (player != null) {
                        playerLabel.Text = player.PlayerName;
                        playerLabel.ForeColor = Color.White;
                        playerLabel.Size = new Size(63, 17);
                        playerLabel.TextAlign = ContentAlignment.MiddleCenter;

                        playerPictureBox.BackgroundImage = Resources.DefaultPlayerImage;
                        playerPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
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

        public void ConfigWinner() {
            //Validate if there is a winner in the tournament
            if (_playerWinner != null) {
                _bracketForm.lblWinner.Text = _playerWinner.PlayerName;
                _bracketForm.lblWinner.Size = new Size(275, 50);
                _bracketForm.lblWinner.TextAlign = ContentAlignment.MiddleCenter;
                _bracketForm.panelWinner.BackgroundImage = Resources.DefaultPlayerImage;
            }
            else _bracketForm.panelHelper.SendToBack();
        }

        public void ConfigQuarterFinals(Player oPlayer) {
            // Check the count to determine the appropriate quarterfinal slot
            if (countForQuarterFinals <= 1) {
                // Check the availability of the background image
                if (_bracketForm.picBoxUserQuarter8.BackgroundImage != null) {
                    // Update the display for quarterfinal slot 
                    _bracketForm.lblUserQuarter7.Text = oPlayer.PlayerName;
                    _bracketForm.lblUserQuarter7.Size = new Size(63, 17);
                    _bracketForm.lblUserQuarter7.TextAlign = ContentAlignment.MiddleCenter;
                    _bracketForm.picBoxUserQuarter7.BackgroundImageLayout = ImageLayout.Stretch;
                    _bracketForm.picBoxUserQuarter7.BackgroundImage = Resources.DefaultPlayerImage;
                    countForQuarterFinals++;
                } else {
                    // Update the display for quarterfinal slot 
                    _bracketForm.lblUserQuarter8.Text = oPlayer.PlayerName;
                    _bracketForm.lblUserQuarter8.Size = new Size(63, 17);
                    _bracketForm.lblUserQuarter8.TextAlign = ContentAlignment.MiddleCenter;
                    _bracketForm.picBoxUserQuarter8.BackgroundImageLayout = ImageLayout.Stretch;
                    _bracketForm.picBoxUserQuarter8.BackgroundImage = Resources.DefaultPlayerImage;
                    countForQuarterFinals++;
                }
            } else if (countForQuarterFinals <= 3) {
                if (_bracketForm.picBoxUserQuarter6.BackgroundImage != null)  {
                    _bracketForm.lblUserQuarter5.Text = oPlayer.PlayerName;
                    _bracketForm.lblUserQuarter5.Size = new Size(63, 17);
                    _bracketForm.lblUserQuarter5.TextAlign = ContentAlignment.MiddleCenter;
                    _bracketForm.picBoxUserQuarter5.BackgroundImageLayout = ImageLayout.Stretch;
                    _bracketForm.picBoxUserQuarter5.BackgroundImage = Resources.DefaultPlayerImage;
                    countForQuarterFinals++;
                } else {
                    _bracketForm.lblUserQuarter6.Text = oPlayer.PlayerName;
                    _bracketForm.lblUserQuarter6.Size = new Size(63, 17);
                    _bracketForm.lblUserQuarter6.TextAlign = ContentAlignment.MiddleCenter;
                    _bracketForm.picBoxUserQuarter6.BackgroundImageLayout = ImageLayout.Stretch;
                    _bracketForm.picBoxUserQuarter6.BackgroundImage = Resources.DefaultPlayerImage;
                    countForQuarterFinals++;
                }
            } else if (countForQuarterFinals <= 5) {
                if (_bracketForm.picBoxUserQuarter4.BackgroundImage != null) {
                    _bracketForm.lblUserQuarter3.Text = oPlayer.PlayerName;
                    _bracketForm.lblUserQuarter3.Size = new Size(63, 17);
                    _bracketForm.lblUserQuarter3.TextAlign = ContentAlignment.MiddleCenter;
                    _bracketForm.picBoxUserQuarter3.BackgroundImageLayout = ImageLayout.Stretch;
                    _bracketForm.picBoxUserQuarter3.BackgroundImage = Resources.DefaultPlayerImage;
                    countForQuarterFinals++;
                } else {
                    _bracketForm.lblUserQuarter4.Text = oPlayer.PlayerName;
                    _bracketForm.lblUserQuarter4.Size = new Size(63, 17);
                    _bracketForm.lblUserQuarter4.TextAlign = ContentAlignment.MiddleCenter;
                    _bracketForm.picBoxUserQuarter4.BackgroundImageLayout = ImageLayout.Stretch;
                    _bracketForm.picBoxUserQuarter4.BackgroundImage = Resources.DefaultPlayerImage;
                    countForQuarterFinals++;
                }
            } else {
                if (_bracketForm.picBoxUserQuarter2.BackgroundImage != null){
                    _bracketForm.lblUserQuarter1.Text = oPlayer.PlayerName;
                    _bracketForm.lblUserQuarter1.Size = new Size(63, 17);
                    _bracketForm.lblUserQuarter1.TextAlign = ContentAlignment.MiddleCenter;
                    _bracketForm.picBoxUserQuarter1.BackgroundImageLayout = ImageLayout.Stretch;
                    _bracketForm.picBoxUserQuarter1.BackgroundImage = Resources.DefaultPlayerImage;
                    countForQuarterFinals++;
                } else {
                    _bracketForm.lblUserQuarter2.Text = oPlayer.PlayerName;
                    _bracketForm.lblUserQuarter2.Size = new Size(63, 17);
                    _bracketForm.lblUserQuarter2.TextAlign = ContentAlignment.MiddleCenter;
                    _bracketForm.picBoxUserQuarter2.BackgroundImageLayout = ImageLayout.Stretch;
                    _bracketForm.picBoxUserQuarter2.BackgroundImage = Resources.DefaultPlayerImage;
                    countForQuarterFinals++;
                }
            }
        }

        public void ConfigSemiFinals(Player oPlayer) {
            // Check the count to determine the appropriate semifinal slot
            if (countForSemiFinals <= 1) {
                // Check the availability of the background image
                if (_bracketForm.picBoxUserSemi4.BackgroundImage != null) {
                    // Update the display for semifinal slot 
                    _bracketForm.lblUserSemi3.Text = oPlayer.PlayerName;
                    _bracketForm.lblUserSemi3.Size = new Size(63, 17);
                    _bracketForm.lblUserSemi3.TextAlign = ContentAlignment.MiddleCenter;
                    _bracketForm.picBoxUserSemi3.BackgroundImageLayout = ImageLayout.Stretch;
                    _bracketForm.picBoxUserSemi3.BackgroundImage = Resources.DefaultPlayerImage;
                    countForSemiFinals++;
                } else {
                    // Update the display for semifinal slot 
                    _bracketForm.lblUserSemi4.Text = oPlayer.PlayerName;
                    _bracketForm.lblUserSemi4.Size = new Size(63, 17);
                    _bracketForm.lblUserSemi4.TextAlign = ContentAlignment.MiddleCenter;
                    _bracketForm.picBoxUserSemi4.BackgroundImageLayout = ImageLayout.Stretch;
                    _bracketForm.picBoxUserSemi4.BackgroundImage = Resources.DefaultPlayerImage;
                    countForSemiFinals++;
                }
            } else {
                if (_bracketForm.picBoxUserSemi2.BackgroundImage != null) {
                    _bracketForm.lblUserSemi1.Text = oPlayer.PlayerName;
                    _bracketForm.lblUserSemi1.Size = new Size(63, 17);
                    _bracketForm.lblUserSemi1.TextAlign = ContentAlignment.MiddleCenter;
                    _bracketForm.picBoxUserSemi1.BackgroundImageLayout = ImageLayout.Stretch;
                    _bracketForm.picBoxUserSemi1.BackgroundImage = Resources.DefaultPlayerImage;
                } else {
                    _bracketForm.lblUserSemi2.Text = oPlayer.PlayerName;
                    _bracketForm.lblUserSemi2.Size = new Size(63, 17);
                    _bracketForm.lblUserSemi2.TextAlign = ContentAlignment.MiddleCenter;
                    _bracketForm.picBoxUserSemi2.BackgroundImageLayout = ImageLayout.Stretch;
                    _bracketForm.picBoxUserSemi2.BackgroundImage = Resources.DefaultPlayerImage;
                }
            }
        }

        public void ConfigFinals(Player oPlayer) {
            // Check the availability of the background image
            if (_bracketForm.picBoxUserFinal2.BackgroundImage != null) {
                // Update the display for final slot 
                _bracketForm.lblUserFinal1.Text = oPlayer.PlayerName;
                _bracketForm.lblUserFinal1.Size = new Size(63, 17);
                _bracketForm.lblUserFinal1.TextAlign = ContentAlignment.MiddleCenter;
                _bracketForm.picBoxUserFinal1.BackgroundImage = Resources.DefaultPlayerImage;
                _bracketForm.picBoxUserFinal1.BackgroundImageLayout = ImageLayout.Stretch;
            } else {
                // Update the display for final slot 
                _bracketForm.lblUserFinal2.Text = oPlayer.PlayerName;
                _bracketForm.lblUserFinal2.Size = new Size(63, 17);
                _bracketForm.lblUserFinal2.TextAlign = ContentAlignment.MiddleCenter;
                _bracketForm.picBoxUserFinal2.BackgroundImage = Resources.DefaultPlayerImage;
                _bracketForm.picBoxUserFinal2.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}
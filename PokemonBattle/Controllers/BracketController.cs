using PokemonBattle.Helpers;
using PokemonBattle.Services;
using PokemonBattle.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Controllers {
    internal class BracketController {

        private BracketForm _bracketForm;
        private TournamentManager _tournamentManager;
        public BracketController(BracketForm oBracketForm) {
            this._tournamentManager = TournamentManager.GetInstance;
            this._bracketForm = oBracketForm;
            if (_tournamentManager.TournamentSize == 16) LoadLayoutForSixteen();
            else if (_tournamentManager.TournamentSize == 8) LoadLayoutForEight();
            else LoadLayoutForFour();
        }

        private void LoadLayoutForSixteen()
        {
            //Sets the background image for the tournament 16
            _bracketForm.BackgroundImage = Properties.Resources.TournamentSixteen;

            //Validate if there is a winner in the tournament
            if (_tournamentManager.Winner != null)
            {
                _bracketForm.lblWinner.Text = _tournamentManager.Winner.PlayerName;
                _bracketForm.lblWinner.Size = new System.Drawing.Size(275, 50);
                _bracketForm.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                _bracketForm.panelWinner.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            }
            else _bracketForm.panelHelper.SendToBack();

            //Round of sixteen
            _bracketForm.lblUser1.Text = _tournamentManager.PlayersList[15].PlayerName;
            _bracketForm.lblUser1.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUser1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUser1.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUser1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUser2.Text = _tournamentManager.PlayersList[14].PlayerName;
            _bracketForm.lblUser2.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUser2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUser2.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUser2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUser3.Text = _tournamentManager.PlayersList[13].PlayerName;
            _bracketForm.lblUser3.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUser3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUser3.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUser3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUser4.Text = _tournamentManager.PlayersList[12].PlayerName;
            _bracketForm.lblUser4.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUser4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUser4.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUser4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUser5.Text = _tournamentManager.PlayersList[11].PlayerName;
            _bracketForm.lblUser5.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUser5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUser5.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUser5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUser6.Text = _tournamentManager.PlayersList[10].PlayerName;
            _bracketForm.lblUser6.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUser6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUser6.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUser6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUser7.Text = _tournamentManager.PlayersList[9].PlayerName;
            _bracketForm.lblUser7.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUser7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUser7.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUser7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUser8.Text = _tournamentManager.PlayersList[8].PlayerName;
            _bracketForm.lblUser8.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUser8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUser8.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUser8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUser9.Text = _tournamentManager.PlayersList[7].PlayerName;
            _bracketForm.lblUser9.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUser9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUser9.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUser9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUser10.Text = _tournamentManager.PlayersList[6].PlayerName;
            _bracketForm.lblUser10.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUser10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUser10.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUser10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUser11.Text = _tournamentManager.PlayersList[5].PlayerName;
            _bracketForm.lblUser11.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUser11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUser11.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUser11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUser12.Text = _tournamentManager.PlayersList[4].PlayerName;
            _bracketForm.lblUser12.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUser12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUser12.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUser12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUser13.Text = _tournamentManager.PlayersList[3].PlayerName;
            _bracketForm.lblUser13.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUser13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUser13.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUser13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUser14.Text = _tournamentManager.PlayersList[2].PlayerName;
            _bracketForm.lblUser14.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUser14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUser14.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUser14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUser15.Text = _tournamentManager.PlayersList[1].PlayerName;
            _bracketForm.lblUser15.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUser15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUser15.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUser15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUser16.Text = _tournamentManager.PlayersList[0].PlayerName;
            _bracketForm.lblUser16.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUser16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUser16.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUser16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;


            int auxCount = 0;
            int auxCount2 = 0;

            //scroll through the list of players to see if they are in other rounds.
            foreach (var player in _tournamentManager.PlayersList) {

                //Quarter
                if (player.IsInQuarter)
                {
                    if (auxCount2 <= 1)
                    {
                        if (_bracketForm.picBoxUserQuarter8.BackgroundImage != null)
                        {
                            _bracketForm.lblUserQuarter7.Text = player.PlayerName;
                            _bracketForm.lblUserQuarter7.Size = new System.Drawing.Size(63, 17);
                            _bracketForm.lblUserQuarter7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            _bracketForm.picBoxUserQuarter7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            _bracketForm.picBoxUserQuarter7.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                            auxCount2++;
                        }
                        else
                        {
                            _bracketForm.lblUserQuarter8.Text = player.PlayerName;
                            _bracketForm.lblUserQuarter8.Size = new System.Drawing.Size(63, 17);
                            _bracketForm.lblUserQuarter8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            _bracketForm.picBoxUserQuarter8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            _bracketForm.picBoxUserQuarter8.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                            auxCount2++;
                        }
                    }
                    else if(auxCount2 <= 3)
                    {
                        if (_bracketForm.picBoxUserQuarter6.BackgroundImage != null)
                        {
                            _bracketForm.lblUserQuarter5.Text = player.PlayerName;
                            _bracketForm.lblUserQuarter5.Size = new System.Drawing.Size(63, 17);
                            _bracketForm.lblUserQuarter5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            _bracketForm.picBoxUserQuarter5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            _bracketForm.picBoxUserQuarter5.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                            auxCount2++;
                        }
                        else
                        {
                            _bracketForm.lblUserQuarter6.Text = player.PlayerName;
                            _bracketForm.lblUserQuarter6.Size = new System.Drawing.Size(63, 17);
                            _bracketForm.lblUserQuarter6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            _bracketForm.picBoxUserQuarter6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            _bracketForm.picBoxUserQuarter6.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                            auxCount2++;
                        }
                    }
                    else if (auxCount2 <= 5)
                    {
                        if (_bracketForm.picBoxUserQuarter4.BackgroundImage != null)
                        {
                            _bracketForm.lblUserQuarter3.Text = player.PlayerName;
                            _bracketForm.lblUserQuarter3.Size = new System.Drawing.Size(63, 17);
                            _bracketForm.lblUserQuarter3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            _bracketForm.picBoxUserQuarter3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            _bracketForm.picBoxUserQuarter3.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                            auxCount2++;
                        }
                        else
                        {
                            _bracketForm.lblUserQuarter4.Text = player.PlayerName;
                            _bracketForm.lblUserQuarter4.Size = new System.Drawing.Size(63, 17);
                            _bracketForm.lblUserQuarter4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            _bracketForm.picBoxUserQuarter4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            _bracketForm.picBoxUserQuarter4.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                            auxCount2++;
                        }
                    }
                    else
                    {
                        if (_bracketForm.picBoxUserQuarter2.BackgroundImage != null)
                        {
                            _bracketForm.lblUserQuarter1.Text = player.PlayerName;
                            _bracketForm.lblUserQuarter1.Size = new System.Drawing.Size(63, 17);
                            _bracketForm.lblUserQuarter1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            _bracketForm.picBoxUserQuarter1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            _bracketForm.picBoxUserQuarter1.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                            auxCount2++;
                        }
                        else
                        {
                            _bracketForm.lblUserQuarter2.Text = player.PlayerName;
                            _bracketForm.lblUserQuarter2.Size = new System.Drawing.Size(63, 17);
                            _bracketForm.lblUserQuarter2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            _bracketForm.picBoxUserQuarter2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            _bracketForm.picBoxUserQuarter2.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                            auxCount2++;
                        }
                    }
                }

                //Semi
                if (player.IsInSemi)
                {
                    if (auxCount <= 1)
                    {
                        if (_bracketForm.picBoxUserSemi4.BackgroundImage != null)
                        {
                            _bracketForm.lblUserSemi3.Text = player.PlayerName;
                            _bracketForm.lblUserSemi3.Size = new System.Drawing.Size(63, 17);
                            _bracketForm.lblUserSemi3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            _bracketForm.picBoxUserSemi3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            _bracketForm.picBoxUserSemi3.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                            auxCount++;
                        }
                        else
                        {
                            _bracketForm.lblUserSemi4.Text = player.PlayerName;
                            _bracketForm.lblUserSemi4.Size = new System.Drawing.Size(63, 17);
                            _bracketForm.lblUserSemi4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            _bracketForm.picBoxUserSemi4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            _bracketForm.picBoxUserSemi4.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                            auxCount++;
                        }
                    }
                    else
                    {
                        if (_bracketForm.picBoxUserSemi2.BackgroundImage != null)
                        {
                            _bracketForm.lblUserSemi1.Text = player.PlayerName;
                            _bracketForm.lblUserSemi1.Size = new System.Drawing.Size(63, 17);
                            _bracketForm.lblUserSemi1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            _bracketForm.picBoxUserSemi1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            _bracketForm.picBoxUserSemi1.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                        }
                        else
                        {
                            _bracketForm.lblUserSemi2.Text = player.PlayerName;
                            _bracketForm.lblUserSemi2.Size = new System.Drawing.Size(63, 17);
                            _bracketForm.lblUserSemi2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            _bracketForm.picBoxUserSemi2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            _bracketForm.picBoxUserSemi2.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                        }
                    }
                }

                //Finals
                if (player.IsInFinal)
                {
                    if (_bracketForm.picBoxUserFinal2.BackgroundImage != null)
                    {
                        _bracketForm.lblUserFinal1.Text = player.PlayerName;
                        _bracketForm.lblUserFinal1.Size = new System.Drawing.Size(63, 17);
                        _bracketForm.lblUserFinal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        _bracketForm.picBoxUserFinal1.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                        _bracketForm.picBoxUserFinal1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    }
                    else
                    {
                        _bracketForm.lblUserFinal2.Text = player.PlayerName;
                        _bracketForm.lblUserFinal2.Size = new System.Drawing.Size(63, 17);
                        _bracketForm.lblUserFinal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        _bracketForm.picBoxUserFinal2.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                        _bracketForm.picBoxUserFinal2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    }
                }
            }
        }
    

        private void LoadLayoutForEight() {
            //Sets the background image for the tournament 4
            _bracketForm.BackgroundImage = Properties.Resources.TournamentEight;

            //Validate if there is a winner in the tournament
            if (_tournamentManager.Winner != null) {
                _bracketForm.lblWinner.Text = _tournamentManager.Winner.PlayerName;
                _bracketForm.lblWinner.Size = new System.Drawing.Size(275, 50);
                _bracketForm.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                _bracketForm.panelWinner.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            } else _bracketForm.panelHelper.SendToBack();

            //Quarter
            _bracketForm.lblUserQuarter1.Text = _tournamentManager.PlayersList[7].PlayerName;
            _bracketForm.lblUserQuarter1.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUserQuarter1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUserQuarter1.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUserQuarter1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUserQuarter2.Text = _tournamentManager.PlayersList[6].PlayerName;
            _bracketForm.lblUserQuarter2.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUserQuarter2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUserQuarter2.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUserQuarter2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUserQuarter3.Text = _tournamentManager.PlayersList[5].PlayerName;
            _bracketForm.lblUserQuarter3.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUserQuarter3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUserQuarter3.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUserQuarter3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUserQuarter4.Text = _tournamentManager.PlayersList[4].PlayerName;
            _bracketForm.lblUserQuarter4.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUserQuarter4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUserQuarter4.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUserQuarter4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUserQuarter5.Text = _tournamentManager.PlayersList[3].PlayerName;
            _bracketForm.lblUserQuarter5.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUserQuarter5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUserQuarter5.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUserQuarter5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUserQuarter6.Text = _tournamentManager.PlayersList[2].PlayerName;
            _bracketForm.lblUserQuarter6.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUserQuarter6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUserQuarter6.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUserQuarter6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUserQuarter7.Text = _tournamentManager.PlayersList[1].PlayerName;
            _bracketForm.lblUserQuarter7.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUserQuarter7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUserQuarter7.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUserQuarter7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUserQuarter8.Text = _tournamentManager.PlayersList[0].PlayerName;
            _bracketForm.lblUserQuarter8.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUserQuarter8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUserQuarter8.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUserQuarter8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            int auxCount = 0;

            //scroll through the list of players to see if they are in other rounds.
            foreach (var player in _tournamentManager.PlayersList) {
                //Semi
                if (player.IsInSemi){
                    if (auxCount <= 1)  {
                        if (_bracketForm.picBoxUserSemi4.BackgroundImage != null)
                        {
                            _bracketForm.lblUserSemi3.Text = player.PlayerName;
                            _bracketForm.lblUserSemi3.Size = new System.Drawing.Size(63, 17);
                            _bracketForm.lblUserSemi3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            _bracketForm.picBoxUserSemi3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            _bracketForm.picBoxUserSemi3.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                            auxCount++;
                        }
                        else
                        {
                            _bracketForm.lblUserSemi4.Text = player.PlayerName;
                            _bracketForm.lblUserSemi4.Size = new System.Drawing.Size(63, 17);
                            _bracketForm.lblUserSemi4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            _bracketForm.picBoxUserSemi4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            _bracketForm.picBoxUserSemi4.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                            auxCount++;
                        }
                    } else   {
                        if (_bracketForm.picBoxUserSemi2.BackgroundImage != null)
                        {
                            _bracketForm.lblUserSemi1.Text = player.PlayerName;
                            _bracketForm.lblUserSemi1.Size = new System.Drawing.Size(63, 17);
                            _bracketForm.lblUserSemi1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            _bracketForm.picBoxUserSemi1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            _bracketForm.picBoxUserSemi1.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                        }
                        else
                        {
                            _bracketForm.lblUserSemi2.Text = player.PlayerName;
                            _bracketForm.lblUserSemi2.Size = new System.Drawing.Size(63, 17);
                            _bracketForm.lblUserSemi2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            _bracketForm.picBoxUserSemi2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            _bracketForm.picBoxUserSemi2.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                        }
                    }
                }

                //Finals
                if (player.IsInFinal)
                {
                    if (_bracketForm.picBoxUserFinal2.BackgroundImage != null)
                    {
                        _bracketForm.lblUserFinal1.Text = player.PlayerName;
                        _bracketForm.lblUserFinal1.Size = new System.Drawing.Size(63, 17);
                        _bracketForm.lblUserFinal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        _bracketForm.picBoxUserFinal1.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                        _bracketForm.picBoxUserFinal1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    }
                    else
                    {
                        _bracketForm.lblUserFinal2.Text = player.PlayerName;
                        _bracketForm.lblUserFinal2.Size = new System.Drawing.Size(63, 17);
                        _bracketForm.lblUserFinal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        _bracketForm.picBoxUserFinal2.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                        _bracketForm.picBoxUserFinal2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    }
                }
            }
        }

        private void LoadLayoutForFour(){
            //Sets the background image for the tournament 4
            _bracketForm.BackgroundImage = Properties.Resources.TournamentFour;

            //Validate if there is a winner in the tournament
            if (_tournamentManager.Winner != null) {
                _bracketForm.lblWinner.Text = _tournamentManager.Winner.PlayerName;
                _bracketForm.lblWinner.Size = new System.Drawing.Size(275, 50);
                _bracketForm.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                _bracketForm.panelWinner.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            } else _bracketForm.panelHelper.SendToBack();

            //Semi
            _bracketForm.lblUserSemi1.Text = _tournamentManager.PlayersList[3].PlayerName;
            _bracketForm.lblUserSemi1.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUserSemi1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUserSemi1.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUserSemi1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUserSemi2.Text = _tournamentManager.PlayersList[2].PlayerName;
            _bracketForm.lblUserSemi2.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUserSemi2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUserSemi2.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUserSemi2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUserSemi3.Text = _tournamentManager.PlayersList[1].PlayerName;
            _bracketForm.lblUserSemi3.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUserSemi3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUserSemi3.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUserSemi3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            _bracketForm.lblUserSemi4.Text = _tournamentManager.PlayersList[0].PlayerName;
            _bracketForm.lblUserSemi4.Size = new System.Drawing.Size(63, 17);
            _bracketForm.lblUserSemi4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _bracketForm.picBoxUserSemi4.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _bracketForm.picBoxUserSemi4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            //scroll through the list of players to see if they are in other rounds.
            foreach (var player in _tournamentManager.PlayersList) {
                //Finals
                if (player.IsInFinal) {
                    if (_bracketForm.picBoxUserFinal2.BackgroundImage != null) {
                        _bracketForm.lblUserFinal1.Text = player.PlayerName;
                        _bracketForm.lblUserFinal1.Size = new System.Drawing.Size(63, 17);
                        _bracketForm.lblUserFinal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        _bracketForm.picBoxUserFinal1.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                        _bracketForm.picBoxUserFinal1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    }
                    else{
                        _bracketForm.lblUserFinal2.Text = player.PlayerName;
                        _bracketForm.lblUserFinal2.Size = new System.Drawing.Size(63, 17);
                        _bracketForm.lblUserFinal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        _bracketForm.picBoxUserFinal2.BackgroundImage = Properties.Resources.DefaultPlayerImage;
                        _bracketForm.picBoxUserFinal2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    }
                }
            }
        }
    }
}
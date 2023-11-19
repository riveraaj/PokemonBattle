using PokemonBattle.Properties;
using PokemonBattle.Services;
using PokemonBattle.Utilities;
using PokemonBattle.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Resources;
using System.Windows.Forms;

namespace PokemonBattle
{
    public partial class PrincipalForm : Form {
 
        private int initPositionX;
        private bool pulsating;
        private SoundPlayer oSoundPlayer;
        private bool isMusicPlaying;
        private TournamentManager _tournamentServices;

        public PrincipalForm() {
            InitInstance();
            InitializeComponent();
            ButtonTransparentHelper.CustomizeAppearanceButtons(new List<Button> { btnPlayer });
            oSoundPlayer.Play();
            initPositionX = labelStart.Location.X;
            timer1.Interval = 1000;
            timer1.Start();
        }
        
        private void InitInstance() {
            pulsating = false;
            isMusicPlaying = true;
            oSoundPlayer = new SoundPlayer("Resources/music-pokemon-battle.wav");
            _tournamentServices = TournamentManager.GetInstance;
            _tournamentServices.InitInstances();
        }

        private void OpenInitTournament(object sender, KeyPressEventArgs e) {
            InitTournamentForm oInitTournamentForm = new InitTournamentForm();
            oInitTournamentForm.Show();
        }

        protected override void WndProc(ref Message m) {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;

            if (m.Msg == WM_NCLBUTTONDOWN && (int)m.WParam == HTCAPTION) return;
            
            base.WndProc(ref m);
        }

        private void Timer1_Tick(object sender, EventArgs e) {
            if (pulsating) {
                labelStart.Font = new System.Drawing.Font(labelStart.Font.FontFamily, labelStart.Font.Size - 2, labelStart.Font.Style);
                labelStart.Location = new Point(initPositionX, labelStart.Location.Y);
                pulsating = false;
                labelStart.Refresh();
            } else {
                labelStart.TextAlign = ContentAlignment.MiddleCenter;
                labelStart.Font = new System.Drawing.Font(labelStart.Font.FontFamily, labelStart.Font.Size + 2, labelStart.Font.Style);
                labelStart.Location = new Point(labelStart.Location.X - 15, labelStart.Location.Y);
                pulsating = true;
                labelStart.Refresh();
            }
        }

        private void StopMusic(object sender, EventArgs e) {
            if (isMusicPlaying) {
                isMusicPlaying = false;
                oSoundPlayer.Stop();
                btnPlayer.BackgroundImage = Properties.Resources.ButtonPlay;
            } else {
                isMusicPlaying = true;
                oSoundPlayer.Play();
                btnPlayer.BackgroundImage = Properties.Resources.ButtonStop;
            }
        }
    }
}
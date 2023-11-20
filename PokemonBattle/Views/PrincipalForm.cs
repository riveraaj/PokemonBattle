using PokemonBattle.Controllers;
using PokemonBattle.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace PokemonBattle {
    internal partial class PrincipalForm : Form {
 
        //Intances
        private int initPositionX;
        private bool pulsating;
        private SoundPlayer oSoundPlayer;
        private bool isMusicPlaying;

        public PrincipalForm() {
            InitInstance();
            InitializeComponent();
            InitializeComponentCustom();  
            new PrincipalController(this);
        }

        //Init Components Custom Properties
        private void InitializeComponentCustom(){
            oSoundPlayer.Play();
            initPositionX = labelStart.Location.X;
            timer.Interval = 1000;
            timer.Start();
            ButtonHelper.CustomizeAppearanceButtons(new List<Button> { btnPlayer });
        }
        
        //Init Instances
        private void InitInstance() {
            this.pulsating = false;
            this.isMusicPlaying = true;
            this.oSoundPlayer = new SoundPlayer("Resources/music-pokemon-battle.wav");     
        }

        //Cancel the ability to move the screen
        protected override void WndProc(ref Message m) {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;

            if (m.Msg == WM_NCLBUTTONDOWN && (int)m.WParam == HTCAPTION) return;       
            base.WndProc(ref m);
        }

        //Event for timer and animation for label startup
        private void Timer_Tick(object sender, EventArgs e) {
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

        //Event to stop or play the music
        private void MusicManager(object sender, EventArgs e) {
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
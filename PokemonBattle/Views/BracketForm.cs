using PokemonBattle.Controllers;
using System;
using System.Windows.Forms;

namespace PokemonBattle.Views {
    public partial class BracketForm : Form {

        //Instances and variables
        private Timer timer;
        private BracketController _bracketController;

        public BracketForm() {
            InitializeComponent();
            InitTimer();
            this._bracketController = new BracketController(this);
        }

        //Init Timer
        private void InitTimer(){
            timer = new Timer {
                Interval = 10000 // 10 segundos
            };

            timer.Tick += Timer_Tick;
            timer.Start();
        }

        //Cancel the ability to move the screen
        protected override void WndProc(ref Message m) {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;

            if (m.Msg == WM_NCLBUTTONDOWN && (int)m.WParam == HTCAPTION) return;
            base.WndProc(ref m);
        }

        //Event to open a fomr after the set time of the timer
        private void Timer_Tick(object sender, EventArgs e){
            this.timer.Stop();
            new BattleForm().Show();
            this.Close();
        }
    }
}
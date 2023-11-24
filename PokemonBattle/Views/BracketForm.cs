using PokemonBattle.Controllers;
using System;
using System.Windows.Forms;

namespace PokemonBattle.Views {
    public partial class BracketForm : Form {

        private Timer timer;
        private BracketController _bracketController;

        public BracketForm() {
            InitializeComponent();
            InitTimer();
            this._bracketController = new BracketController(this);
        }

        private void InitTimer(){
            timer = new Timer {
                Interval = 100000 // 10 segundos
            };

            timer.Tick += Timer_Tick;
            timer.Start();
        }

        protected override void WndProc(ref Message m) {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;

            if (m.Msg == WM_NCLBUTTONDOWN && (int)m.WParam == HTCAPTION) return;
            base.WndProc(ref m);
        }

        private void Timer_Tick(object sender, EventArgs e){
            this.timer.Stop();
            new BattleForm().Show();
            this.Close();
        }
    }
}
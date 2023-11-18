using System;
using System.Windows.Forms;

namespace PokemonBattle.Views
{
    public partial class BracketForm : Form {

        private readonly Timer timer;

        public BracketForm() {
            InitializeComponent();
            if (panelWinner.BackgroundImage != null) panelHelper.SendToBack();

            this.timer = new Timer {
                Interval = 10000 // 10 segundos
            };

            this.timer.Tick += Timer_Tick;
            this.timer.Start();
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
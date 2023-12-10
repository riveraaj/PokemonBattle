using PokemonBattle.Controllers;
using System.Windows.Forms;

namespace PokemonBattle.View {
    public partial class PlayersForm : Form {

        //Instances
        private readonly PlayersController _playersController;

        public PlayersForm() {
            InitializeComponent();
            this.FormClosing += FormClose;
            _playersController = new PlayersController(this);
        }

        //Cancel the ability to move the screen
        protected override void WndProc(ref Message m) {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;

            if (m.Msg == WM_NCLBUTTONDOWN && (int)m.WParam == HTCAPTION) return;
            base.WndProc(ref m);
        }

        //Event that closes the application if the user closes the window.
        private void FormClose(object sender, FormClosingEventArgs e) => Application.Exit();
    }
}
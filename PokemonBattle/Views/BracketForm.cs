using PokemonBattle.Controllers;
using System;
using System.Windows.Forms;

namespace PokemonBattle.Views {
    public partial class BracketForm : Form {

        //Instances and variables
        internal Timer timer;
        private BracketController _bracketController;

        public BracketForm() {
            InitializeComponent();
            this._bracketController = new BracketController(this);
        }

        //Cancel the ability to move the screen
        protected override void WndProc(ref Message m) {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;

            if (m.Msg == WM_NCLBUTTONDOWN && (int)m.WParam == HTCAPTION) return;
            base.WndProc(ref m);
        }
    }
}
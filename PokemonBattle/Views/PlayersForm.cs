using PokemonBattle.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PokemonBattle.View
{
    public partial class PlayersForm : Form {
        public PlayersForm() {
            InitializeComponent();
            ButtonTransparentHelper.CustomizeAppearanceButtons(new List<Button> { btnNext, btnChoosePokemon});
        }

        protected override void WndProc(ref Message m) {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;

            if (m.Msg == WM_NCLBUTTONDOWN && (int)m.WParam == HTCAPTION) return;
            base.WndProc(ref m);
        }

        private void OpenPokedex(object sender, EventArgs e){
            new PokedexForm().Show();
            this.Close();
        }
    }
}
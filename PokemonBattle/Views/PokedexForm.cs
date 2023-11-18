using PokemonBattle.Utilities;
using PokemonBattle.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PokemonBattle.View
{
    public partial class PokedexForm : Form {
        public PokedexForm() {
            InitializeComponent();
            ButtonTransparentHelper.CustomizeButtonAppearance(new List<Button> { button1});
        }

        protected override void WndProc(ref Message m){
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;

            if (m.Msg == WM_NCLBUTTONDOWN && (int)m.WParam == HTCAPTION) return;
            base.WndProc(ref m);
        }

        private void Next(object sender, EventArgs e){
            new BracketForm().Show();
            this.Close();
        }
    }
}
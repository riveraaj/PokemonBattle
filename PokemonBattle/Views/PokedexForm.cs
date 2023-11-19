using PokemonBattle.Services;
using PokemonBattle.Utilities;
using PokemonBattle.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PokemonBattle.View
{
    public partial class PokedexForm : Form {

        private readonly TournamentManager _tournamentServices;

        public PokedexForm() {
            _tournamentServices = TournamentManager.GetInstance;
            InitializeComponent();
            LoadPokedexInLayout();
            ButtonTransparentHelper.CustomizeAppearanceButtons(new List<Button> { btnBack});
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

        public void LoadPokedexInLayout() {
            lblPokemonID.Text = $"0{_tournamentServices.PokemonsList[3].PokemonID}";
            picBoxPokemon.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"_{_tournamentServices.PokemonsList[3].PokemonID}");
            lblName.Text = _tournamentServices.PokemonsList[3].PokemonName;
            lblTypeOne.Text = _tournamentServices.PokemonsList[3].TypeElementOne.TypeElementName;
            if (_tournamentServices.PokemonsList[3].TypeElementTwoID != null) lblTypeTwo.Text = _tournamentServices.PokemonsList[3].TypeElementTwo.TypeElementName;
            txtDescription.Text = _tournamentServices.PokemonsList[3].PokemonDescription;
            txtDescription.SelectionAlignment = HorizontalAlignment.Center;
            txtDescription.ReadOnly = true;
            txtDescription.BackColor = Color.White;
        }
    }
}
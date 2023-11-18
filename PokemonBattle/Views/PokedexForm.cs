using PokemonBattle.Models;
using PokemonBattle.Repositories;
using PokemonBattle.Utilities;
using PokemonBattle.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PokemonBattle.View
{
    public partial class PokedexForm : Form {

        private readonly PokemonRepository _pokemonRepository;
        private List<Pokemon> _pokemons;

        public PokedexForm() {
            _pokemonRepository = new PokemonRepository(new PokemonEntities());
            _pokemons = (List<Pokemon>)_pokemonRepository.GetAll();
            InitializeComponent();
            LoadPokedexInLayout();
            ButtonTransparentHelper.CustomizeButtonAppearance(new List<Button> { btnBack});
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
            lblPokemonID.Text = $"0{_pokemons[3].pokemonID}";
            picBoxPokemon.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"_{_pokemons[3].pokemonID}");
            lblName.Text = _pokemons[3].pokemonName;
            lblTypeOne.Text = _pokemons[3].TypeElement.typeElementName;
            if (_pokemons[3].typeElementTwoID != null) lblTypeTwo.Text = _pokemons[3].TypeElement.typeElementName;
            txtDescription.Text = _pokemons[3].pokemonDescription;
            txtDescription.SelectionAlignment = HorizontalAlignment.Center;
        }

    }
}
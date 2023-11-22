using PokemonBattle.Controllers;
using PokemonBattle.Utilities;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PokemonBattle.View {
    public partial class PokedexForm : Form {

        //Instances
        private readonly PokedexController _pokedexController;
        internal readonly bool allPlayersHaveATeam;
        internal readonly string namePlayer;

        public PokedexForm(string namePlayer, bool allPlayersHaveATeam) {
            this.allPlayersHaveATeam = allPlayersHaveATeam;
            this.namePlayer = namePlayer;
            InitializeComponent();
            InitComponents();
            ButtonHelper.CustomizeAppearanceButtons(new List<Button> { btnBack, btnAddPokemon, btnPreviousPokemon, btnNextPokemon});
            _pokedexController = new PokedexController(this);
        }

        protected override void WndProc(ref Message m){
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;

            if (m.Msg == WM_NCLBUTTONDOWN && (int)m.WParam == HTCAPTION) return;
            base.WndProc(ref m);
        }


        //Init Componentes of Pokedex Form
        public void InitComponents() {
            //btnBack
            if (allPlayersHaveATeam) btnBack.Text = "NEXT";
            else btnBack.Text = "BACK";
            //txtDescription
            txtDescription.ReadOnly = true;
            txtDescription.BackColor = Color.White;
            //lblPokemonID
            lblPokemonID.AutoSize = false;
            lblPokemonID.TextAlign = ContentAlignment.MiddleCenter;
            //lblName
            lblName.AutoSize = false;
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            //lblTypeOne
            lblTypeOne.AutoSize = false;
            lblTypeOne.TextAlign = ContentAlignment.MiddleCenter;
            //lblTypeTwo
            lblTypeTwo.AutoSize = false;
            lblTypeTwo.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
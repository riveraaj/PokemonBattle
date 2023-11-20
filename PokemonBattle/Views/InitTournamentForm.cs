using PokemonBattle.Controllers;
using PokemonBattle.Helpers;
using PokemonBattle.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PokemonBattle.View {
    internal partial class InitTournamentForm : Form {

        //Instances
        internal List<TextBox> TextBoxes;
        internal int SizeTournament, NumberPlayers;
            
        public InitTournamentForm() {
            InitInstance();
            InitializeComponent();
            InitializeComponentCustom();
            new InitTournamentController(this);
        }

        //Init Instances
        private void InitInstance() {
            TextBoxes = new List<TextBox>();
            SizeTournament = 0;
            NumberPlayers = 0;   
        }

        //Init Components Custom Properties
        private void InitializeComponentCustom() {
            ButtonHelper.CustomizeAppearanceButtons(new List<Button> { btnNextPlayersForm });
            cmbSizeTournament.SelectedIndex = 0;
            cmbNumberPlayer.SelectedIndex = 0;
        }

        //Cancel the ability to move the screen
        protected override void WndProc(ref Message m) {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;

            if (m.Msg == WM_NCLBUTTONDOWN && (int)m.WParam == HTCAPTION) return;
            base.WndProc(ref m);
        }

        //Changes the values of the combo box depending on the selected value
        private void ChangeListOfPlayer(object sender, EventArgs e) {
            SizeTournament = Convert.ToInt32(cmbSizeTournament.SelectedItem);
            cmbNumberPlayer.Items.Clear();
            for (int i = 1; i < SizeTournament +  1; i++) cmbNumberPlayer.Items.Add(i);
            cmbNumberPlayer.SelectedIndex = 0;
        }

        //Event that creates inputs depending on the selected size
        private void ChangeListCreateInputForNamesPlayers(object sender, EventArgs e) {
            NumberPlayers = Convert.ToInt32(cmbNumberPlayer.SelectedItem);
            TextBoxes.Clear();
            layoutNamePlayers.Controls.Clear();
            for (int i = 1; i < NumberPlayers + 1; i++) {
                var txtBox = TextBoxHelper.CreateDynamicInput(i);
                layoutNamePlayers.Controls.Add(txtBox);
                TextBoxes.Add(txtBox);
            }
        }
    }
}
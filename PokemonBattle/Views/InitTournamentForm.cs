using PokemonBattle.Controllers;
using PokemonBattle.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PokemonBattle.View
{
    internal partial class InitTournamentForm : Form{

        private List<TextBox> textBoxes;
        private List<string> playersName;
        private InitTournamentController _initTournamentController;
        private int sizeTournament, numberPlayers;

        public InitTournamentForm() {
            InitInstance();
            InitializeComponent();
            ButtonTransparentHelper.CustomizeAppearanceButtons(new List<Button> { btnNextPlayersForm });
            cmbSizeTournament.SelectedIndex = 0;
            cmbNumberPlayer.SelectedIndex = 0;
        }

        private void InitInstance() {
            _initTournamentController = new InitTournamentController();
            textBoxes = new List<TextBox>();
            sizeTournament = 0;
            numberPlayers = 0;
            playersName = new List<string>();
        }

        protected override void WndProc(ref Message m) {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;

            if (m.Msg == WM_NCLBUTTONDOWN && (int)m.WParam == HTCAPTION) return;

            base.WndProc(ref m);
        }

        private void ChangeListOfPlayer(object sender, EventArgs e) {
            sizeTournament = Convert.ToInt32(cmbSizeTournament.SelectedItem);
            cmbNumberPlayer.Items.Clear();
            for (int i = 1; i < sizeTournament +  1; i++) cmbNumberPlayer.Items.Add(i);
            cmbNumberPlayer.SelectedIndex = 0;
        }

        private void ChangeListCreateInputForNamesPlayers(object sender, EventArgs e) {
            numberPlayers = Convert.ToInt32(cmbNumberPlayer.SelectedItem);
            textBoxes.Clear();
            layoutNamePlayers.Controls.Clear();
            for (int i = 1; i < numberPlayers + 1; i++) {
                var txtBox = CreateDinamicInput(i);
                layoutNamePlayers.Controls.Add(txtBox);
                textBoxes.Add(txtBox);
            }
        }

        private void OpenPlayersForm(object sender, EventArgs e)
        {
            bool allNoEmpty = true;
            bool noDuplicates = true;

            List<string> enteredNames = new List<string>();

            foreach (TextBox textBox in textBoxes) {
                if (string.IsNullOrEmpty(textBox.Text)){
                    allNoEmpty = false;
                    break; // You can exit the loop as soon as you find an empty one, or you can continue and mark all the empty ones.
                } else {
                    if (enteredNames.Contains(textBox.Text)) { // Check whether the name has already been entered
                        noDuplicates = false;
                        break; // You can exit the loop as soon as you find a duplicate name.
                    }
                    enteredNames.Add(textBox.Text);
                }
            }

            if (allNoEmpty && noDuplicates){
                labelWarning.Visible = false;
                _initTournamentController.SaveTournamentSize(sizeTournament);
                _initTournamentController.GenerateBots(sizeTournament, numberPlayers);
                textBoxes.ForEach(x => playersName.Add(x.Text));
                _initTournamentController.GeneratePlayers(playersName);
                PlayersForm oPlayersForm = new PlayersForm();
                oPlayersForm.Show();
                this.Close();
            }
            else {
                labelWarning.Visible = true;
                if (!noDuplicates) {
                    labelWarning.Visible = false;
                    MessageBox.Show("No se pueden tener nombres duplicados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private TextBox CreateDinamicInput(int id) {
            TextBox input = new TextBox();
            input.Name = $"txtPlayer{id}";
            input.Width = 89;
            input.Height = 20;
            input.TextAlign = HorizontalAlignment.Center;
            input.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            input.Margin = new Padding(15, 15, 15, 15);
            return input;
        }
    }
}
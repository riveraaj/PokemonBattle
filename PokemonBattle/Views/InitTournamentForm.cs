using PokemonBattle.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PokemonBattle.View
{
    public partial class InitTournamentForm : Form{

        List<TextBox> textBoxes;

        public InitTournamentForm() {
            textBoxes = new List<TextBox>();
            InitializeComponent();
            ButtonTransparentHelper.CustomizeButtonAppearance(new List<Button> { btnNextPlayersForm });
            cmbSizeTournament.SelectedIndex = 0;
            cmbNumberPlayer.SelectedIndex = 0;
        }

        protected override void WndProc(ref Message m) {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;

            if (m.Msg == WM_NCLBUTTONDOWN && (int)m.WParam == HTCAPTION) return;

            base.WndProc(ref m);
        }

        private void ChangeListOfPlayer(object sender, EventArgs e) {
            int sizeTournament = Convert.ToInt32(cmbSizeTournament.SelectedItem);
            cmbNumberPlayer.Items.Clear();
            for (int i = 1; i < sizeTournament +  1; i++) cmbNumberPlayer.Items.Add(i);
            cmbNumberPlayer.SelectedIndex = 0;
        }

        private void ChangeListCreateInputForNamesPlayers(object sender, EventArgs e) {
            int numberPlayers = Convert.ToInt32(cmbNumberPlayer.SelectedItem);
            textBoxes.Clear();
            layoutNamePlayers.Controls.Clear();
            for (int i = 1; i < numberPlayers + 1; i++) {
                var txtBox = CreateDinamicInput(i);
                layoutNamePlayers.Controls.Add(txtBox);
                textBoxes.Add(txtBox);
            }
        }

        private void NextPlayersForm(object sender, EventArgs e) {
            bool allNoEmpty = true;

            foreach (TextBox textBox in textBoxes) {
                if (string.IsNullOrEmpty(textBox.Text)) {
                    allNoEmpty = false;
                    break; // You can exit the loop as soon as you find an empty one, or you can continue and mark all the empty ones.
                }
            }

            if (allNoEmpty) { // All TextBoxes are filled
                labelWarning.Visible = false;
                PlayersForm oPlayersForm = new PlayersForm();
                oPlayersForm.Show();
                this.Close();
            }
            else /* At least one of the TextBoxes is empty */ labelWarning.Visible = true;
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
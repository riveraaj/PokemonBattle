using PokemonBattle.Helpers;
using PokemonBattle.Services;
using PokemonBattle.Utilities;
using PokemonBattle.View;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PokemonBattle.Controllers{
    internal class PlayersController {

        //Instances
        private PlayersForm _playerForm;
        private TournamentManager _tournamentManager;

        public PlayersController(PlayersForm oPlayerForm) { 
            //Init Instances
            _playerForm = oPlayerForm;
            _tournamentManager = TournamentManager.GetInstance;
            LoadLayoutsForPlayers();
        }

        //Event to Open a Pokedex Form
        private void OpenPokedex(object sender, EventArgs e) {
            bool allPlayersHaveATeam = true;
            var btnNamePlayer = sender as Button;

            foreach(var player in _tournamentManager.PlayersList) {
                if (player.Team == null) {
                    allPlayersHaveATeam = false;
                    break;
                }
            }

            new PokedexForm(btnNamePlayer.Name, allPlayersHaveATeam).Show();
            _playerForm.Close();
        }

        //Upload players' data so that they can choose their pokémon
        private void LoadLayoutsForPlayers() {
            int count = 1;

            foreach (var player in _tournamentManager.PlayersList) {
                Label lblAux = LabelHelper.CreateDynamicLabel(player.PlayerName);
                Button btnAux = ButtonHelper.CreateDynamicButton(player.PlayerName);
                if (!player.PlayerName.Equals("BOT") && player.Team == null) btnAux.Click += new EventHandler(OpenPokedex);
                FlowLayoutPanel layout = _playerForm.Controls.Find($"layoutPanel{count}", true).FirstOrDefault() as FlowLayoutPanel;

                layout.Controls.Add(lblAux);
                layout.Controls.Add(btnAux);
                count++;
            }
        }
    }
}
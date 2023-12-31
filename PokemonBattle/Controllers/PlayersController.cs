﻿using PokemonBattle.Helpers;
using PokemonBattle.Services;
using PokemonBattle.Utilities;
using PokemonBattle.View;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PokemonBattle.Controllers {
    internal class PlayersController {

        //Instances
        private readonly PlayersForm _playerForm;
        private readonly PlayerService _playersService;

        public PlayersController(PlayersForm oPlayerForm) { 
            //Init Instances
            _playerForm = oPlayerForm;
            _playersService = new PlayerService();
            LoadLayoutsForPlayers();
        }

        //Event to Open a Pokedex Form
        private void OpenPokedex(object sender, EventArgs e) {
            var btnNamePlayer = sender as Button;
            new PokedexForm(btnNamePlayer.Name, _playersService.GetAPlayerNameAndVerifyHaveAnTeam()).Show();
            _playerForm.Close();
        }

        //Upload players' data so that they can choose their pokémon
        private void LoadLayoutsForPlayers() {
            int count = 1;

            //Scrolls through all players and assigns as needed
            foreach (var player in _playersService.GetPlayerList()) {
                Label lblAux = LabelHelper.CreateDynamicLabel(player.PlayerName); 
                Button btnAux = ButtonHelper.CreateDynamicButton(player.PlayerName, (player.Team != null));
                if (!player.PlayerName.Equals("BOT") && player.Team == null) btnAux.Click += new EventHandler(OpenPokedex);
                FlowLayoutPanel layout = _playerForm.Controls.Find($"layoutPanel{count}", true).FirstOrDefault() as FlowLayoutPanel;

                layout.Controls.Add(lblAux);
                layout.Controls.Add(btnAux);
                count++;
            }
        }
    }
}
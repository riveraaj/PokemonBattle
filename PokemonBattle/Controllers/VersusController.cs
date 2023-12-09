using PokemonBattle.Models;
using PokemonBattle.Services;
using PokemonBattle.View;
using PokemonBattle.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonBattle.Controllers
{
    internal class VersusController{

        private (string playerOneName, string playerTwoName) values;
        private BattleService _battleService;
        private readonly VersusForm _versusForm;
        private List<Player> playerList;
        private Arena oArena;

        public VersusController(VersusForm oVersusForm) {
            this._versusForm = oVersusForm;
            this.values = _versusForm.values;
            this._battleService = new BattleService();
            InitLayout();
            InitTimer();
        }

        //Init Timer
        private void InitTimer() {
            _versusForm.timer = new Timer
            {
                Interval = 10000 // 10 seconds
            };

            _versusForm.timer.Tick += Timer_Tick;
            _versusForm.timer.Start();
        }

        //Event to open a form after the set time of the timer
        private void Timer_Tick(object sender, EventArgs e) {
            _versusForm.timer.Stop();
            if (values.playerOneName.StartsWith("BOT") && values.playerTwoName.StartsWith("BOT")) {
                ConfigBots();
                new BracketForm().Show();
            } else new BattleForm(values).Show();
            _versusForm.Close();
        }

        private void InitLayout() {
            _versusForm.lblPLayerOneName.Text = values.playerOneName;
            _versusForm.lblPLayerTwoName.Text = values.playerTwoName;
            _versusForm.picBoxPLayerOneImage.BackgroundImage = Properties.Resources.DefaultPlayerImage;
            _versusForm.picBoxPLayerTwoImage.BackgroundImage = Properties.Resources.DefaultPlayerImage;
        }

        private void ConfigBots(){
            playerList = _battleService.GetPlayersByName(values.playerOneName, values.playerTwoName);
            oArena = _battleService.GetRandomArena();
            int numberRandom = _battleService.GetRandomNumber(1, 2);

            if (numberRandom == 1) {
                if (playerList[0].IsInFinal) {
                    _battleService.CreateBattle(playerList, oArena.ArenaID, true, 3);
                    _battleService.SaveBattles(playerList[0]);
                    playerList[1].IsEliminated = true;
                } else if (playerList[0].IsInSemi) {
                    _battleService.CreateBattle(playerList, oArena.ArenaID, true, 3);
                    playerList[1].IsEliminated = true;
                    playerList[0].IsInFinal = true;
                } else if (playerList[0].IsInQuarter) {
                    _battleService.CreateBattle(playerList, oArena.ArenaID, true, 3);
                    playerList[1].IsEliminated = true;
                    playerList[0].IsInSemi = true;
                } else {
                    _battleService.CreateBattle(playerList, oArena.ArenaID, true, 3);
                    playerList[1].IsEliminated = true;
                    playerList[0].IsInQuarter = true;
                }
            }
            else {
                if (playerList[1].IsInFinal) {
                    _battleService.CreateBattle(playerList, oArena.ArenaID, false, 3);
                    _battleService.SaveBattles(playerList[1]);
                    playerList[0].IsEliminated = true;
                } else if (playerList[1].IsInSemi) {
                    _battleService.CreateBattle(playerList, oArena.ArenaID, false, 3);
                    playerList[0].IsEliminated = true;
                    playerList[1].IsInFinal = true;
                } else if (playerList[1].IsInQuarter) {
                    _battleService.CreateBattle(playerList, oArena.ArenaID, false, 3);
                    playerList[0].IsEliminated = true;
                    playerList[1].IsInSemi = true;
                } else {
                    _battleService.CreateBattle(playerList, oArena.ArenaID, false, 3);
                    playerList[0].IsEliminated = true;
                    playerList[1].IsInQuarter = true;
                }
            }
        }
    }
}
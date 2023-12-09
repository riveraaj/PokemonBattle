using PokemonBattle.Models;
using PokemonBattle.Properties;
using PokemonBattle.Services;
using PokemonBattle.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonBattle.Controllers { 
    internal class BattleController {
        //Instances & Variables
        private Arena oArena;
        private Pokemon oPokemon;
        private List<Player> playerList;
        private BattleService _battleService;
        private readonly BattleForm _battleForm;
        private (string playerOneName, string playerTwoName) values;
        private bool turnPlayerOne, pokemonPlayerOneProtected, pokemonPlayerTwoProtected;
        private int numberOfPokemonPlayerOne, numberOfPokemonPlayerTwo, healthPokemonPlayerOne, healthPokemonPlayerTwo;

        public BattleController (BattleForm oBattleForm) {
            this._battleForm = oBattleForm;
            InitInstancesAndVariables();
            InitLayoutBattleForm();
            InitBattleForBots();
        }

        //This method helps us to start the battle for a bot.
        private async void InitBattleForBots(){
            //If player 1 is a bot, he must initiate the automatic attack.
            if (playerList[0].PlayerName.StartsWith("BOT"))  {
                await SimulateBotAttackAsync();
                turnPlayerOne = false;
            }
        }

        //Initialize instances and declared variables
        public void InitInstancesAndVariables(){ 
            turnPlayerOne = true;
            values = _battleForm.values;
            numberOfPokemonPlayerOne = 0;
            numberOfPokemonPlayerTwo = 0;
            healthPokemonPlayerOne = 100;
            healthPokemonPlayerTwo = 100;
            pokemonPlayerOneProtected = false;
            pokemonPlayerTwoProtected = false;
            _battleService = new BattleService();
        }

        //Initialize the view on first appearance
        private void InitLayoutBattleForm() {
            //Obtain list of players who will fight
            playerList = _battleService.GetPlayersByName(values.playerOneName, values.playerTwoName); 
            oPokemon = new Pokemon();
            //Obtain a random sand
            oArena = _battleService.GetRandomArena();

            ChangePokemon();

            //The view is loaded with the obtained data
            _battleForm.lblArena.Text = $"Arena: {oArena.TypeElement.TypeElementName}";
            _battleForm.lblPlayerNameOne.Text = playerList[0].PlayerName;
            _battleForm.lblPlayerNameTwo.Text = playerList[1].PlayerName;

            //Events are assigned to the buttons
            _battleForm.btnAttakOnePlayerOne.Click += new EventHandler(PokemonAttackPlayerOne);
            _battleForm.btnAttakTwoPlayerOne.Click += new EventHandler(PokemonAttackPlayerOne);
            _battleForm.btnAttakThreePlayerOne.Click += new EventHandler(PokemonAttackPlayerOne);
            _battleForm.btnAttakFourPlayerOne.Click += new EventHandler(PokemonAttackPlayerOne);

            _battleForm.btnAttakOnePlayerTwo.Click += new EventHandler(PokemonAttackPlayerTwo);
            _battleForm.btnAttakTwoPlayerTwo.Click += new EventHandler(PokemonAttackPlayerTwo);
            _battleForm.btnAttakThreePlayerTwo.Click += new EventHandler(PokemonAttackPlayerTwo);
            _battleForm.btnAttakFourPlayerTwo.Click += new EventHandler(PokemonAttackPlayerTwo);

            //Validate if a player is a bot to disable buttons
            if (playerList[0].PlayerName.StartsWith("BOT")){
                _battleForm.btnAttakOnePlayerOne.Enabled = false;
                _battleForm.btnAttakTwoPlayerOne.Enabled = false;
                _battleForm.btnAttakThreePlayerOne.Enabled = false;
                _battleForm.btnAttakFourPlayerOne.Enabled = false;
            }

            if (playerList[1].PlayerName.StartsWith("BOT")) {
                _battleForm.btnAttakOnePlayerTwo.Enabled = false;
                _battleForm.btnAttakTwoPlayerTwo.Enabled = false;
                _battleForm.btnAttakThreePlayerTwo.Enabled = false;
                _battleForm.btnAttakFourPlayerTwo.Enabled = false;
            }
        }

        //This method is executed as long as player one is attacking
        private async void PokemonAttackPlayerOne(object sender, EventArgs e) {
            if (sender is Button oButton) {
                //Validate the player's turn
                if (turnPlayerOne) {
                    AttakPlayerOne(oButton);
                    turnPlayerOne = false;

                    // After player one's attack, simulates bot attack if player two is a bot.
                    if (playerList[1].PlayerName.StartsWith("BOT")) {
                        await SimulateBotAttackAsync();
                        turnPlayerOne = true;
                    }
                } else MessageBox.Show("It is now the turn of player two", "Wait...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }      
        }

        //This method is executed as long as player two is attacking
        private async void PokemonAttackPlayerTwo(object sender, EventArgs e) {
            if (sender is Button oButton) {
                //Validate the player's turn
                if (!turnPlayerOne) {
                    AttakPlayerTwo(oButton);
                    turnPlayerOne = true;

                    // After player one's attack, simulates bot attack if player one is a bot.
                    if (playerList[0].PlayerName.StartsWith("BOT")) {
                        await SimulateBotAttackAsync();
                        turnPlayerOne = false;
                    }
                } else MessageBox.Show("It is now the turn of player one", "Wait", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        //This method executes the attack by player one and updates the required fields.
        private void AttakPlayerOne(Button oButton) {
            //Validate that the pokemon's life is not 0
            if (healthPokemonPlayerTwo > 0) {
                var movement = _battleService.GetMovement(oButton.Text);
                //If the movement is of the defense type, the protection will be activated.
                if (movement.TypeMovementID == 2) {
                    _battleForm.txtStatsPlayerOne.Text = $"{playerList[0].PlayerName} has used {movement.MovementName}...";
                    pokemonPlayerOneProtected = true;
                }
                else
                {
                    //If a pokemon is protected, it cannot be harmed.
                    if (pokemonPlayerTwoProtected)
                    {
                        _battleForm.txtStatsPlayerOne.Text = $"{playerList[0].PlayerName} has used {movement.MovementName}...";
                        _battleForm.txtStatsPlayerOne.Text += $"\nThe {playerList[1].PlayerName}'s pokemon is protected";
                        pokemonPlayerTwoProtected = false;
                        pokemonPlayerOneProtected = false;
                    }
                    else
                    {
                        _battleForm.txtStatsPlayerOne.Text = $"{playerList[0].PlayerName} has used {movement.MovementName}...";
                        healthPokemonPlayerTwo -= movement.MovementPower;
                        _battleForm.lblHealthPlayerTwo.Text = (healthPokemonPlayerTwo < 0) ? "0/100" : $"{healthPokemonPlayerTwo}/100";
                        //Validate that the pokemon has less than 0 health
                        if (healthPokemonPlayerTwo <= 0)
                        {
                            _battleForm.progressPokemonPlayer2.Value = 0;
                            //Validate if the player has already lost his first 4 pokémon.
                            if (numberOfPokemonPlayerTwo == 4)
                            {
                                //It validates if the player is in which stage and depending on that the battle is created and the player's mapping is updated.
                                if (playerList[0].IsInFinal)
                                {
                                    _battleService.CreateBattle(playerList, oArena.ArenaID, true, numberOfPokemonPlayerOne);
                                    _battleService.SaveBattles(playerList[0]);
                                    playerList[1].IsEliminated = true;
                                }
                                else if (playerList[0].IsInSemi)
                                {
                                    _battleService.CreateBattle(playerList, oArena.ArenaID, true, numberOfPokemonPlayerOne);
                                    playerList[1].IsEliminated = true;
                                    playerList[0].IsInFinal = true;
                                }
                                else if (playerList[0].IsInQuarter)
                                {
                                    _battleService.CreateBattle(playerList, oArena.ArenaID, true, numberOfPokemonPlayerOne);
                                    playerList[1].IsEliminated = true;
                                    playerList[0].IsInSemi = true;
                                }
                                else
                                {
                                    _battleService.CreateBattle(playerList, oArena.ArenaID, true, numberOfPokemonPlayerOne);
                                    playerList[1].IsEliminated = true;
                                    playerList[0].IsInQuarter = true;
                                }
                                MessageBox.Show($"The Winner is {playerList[0].PlayerName}", "Wait...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //The braket is reopened
                                new BracketForm().Show();
                                _battleForm.Close();
                            }
                            else
                            {
                                _battleForm.txtStatsPlayerOne.Text += $"\n{playerList[0].PlayerName} has eliminated the pokemon";
                                //MessageBox.Show("Player one has eliminated the pokemon", "Wait...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                numberOfPokemonPlayerTwo++;
                                healthPokemonPlayerTwo = 100;
                                ChangePokemon();
                            }
                        }
                        else _battleForm.progressPokemonPlayer2.Value = healthPokemonPlayerTwo;
                    }
                }
            } else {
                MessageBox.Show("Player one has eliminated the pokemon", "Wait...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numberOfPokemonPlayerTwo++;
                healthPokemonPlayerTwo = 100;
                ChangePokemon();
            }
        }

        //This method executes the attack by player two and updates the required fields.
        private void AttakPlayerTwo(Button oButton) {
            //Validate that the pokemon's life is not 0
            if (healthPokemonPlayerOne > 0) {
                var movement = _battleService.GetMovement(oButton.Text);
                //If the movement is of the defense type, the protection will be activated.
                if (movement.TypeMovementID == 2) {
                    _battleForm.txtStatsPlayerTwo.Text = $"{playerList[1].PlayerName} has used {movement.MovementName}...";
                    pokemonPlayerTwoProtected = true;
                }
                else
                {
                    //If a pokemon is protected, it cannot be harmed.
                    if (pokemonPlayerOneProtected)
                    {
                        _battleForm.txtStatsPlayerTwo.Text = $"{playerList[1].PlayerName} has used {movement.MovementName}...";
                        _battleForm.txtStatsPlayerTwo.Text += $"\nThe {playerList[0].PlayerName}'s pokemon is protected";
                        //MessageBox.Show("The pokemon is protected", "Wait...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pokemonPlayerOneProtected = false;
                        pokemonPlayerTwoProtected = false;
                    }
                    else
                    {
                        _battleForm.txtStatsPlayerTwo.Text = $"{playerList[1].PlayerName} has used {movement.MovementName}...";
                        healthPokemonPlayerOne -= movement.MovementPower;
                        _battleForm.lblHealthPlayerOne.Text = (healthPokemonPlayerOne < 0) ? "0/100" : $"{healthPokemonPlayerOne}/100";
                        //Validate that the pokemon has less than 0 health
                        if (healthPokemonPlayerOne <= 0)
                        {
                            _battleForm.progressPokemonPlayer1.Value = 0;
                            //Validate if the player has already lost his first 4 pokémon.
                            if (numberOfPokemonPlayerOne == 4)
                            {
                                //It validates if the player is in which stage and depending on that the battle is created and the player's mapping is updated.
                                if (playerList[1].IsInFinal)
                                {
                                    _battleService.CreateBattle(playerList, oArena.ArenaID, false, numberOfPokemonPlayerTwo);
                                    _battleService.SaveBattles(playerList[1]);
                                    playerList[0].IsEliminated = true;
                                }
                                else if (playerList[1].IsInSemi)
                                {
                                    _battleService.CreateBattle(playerList, oArena.ArenaID, false, numberOfPokemonPlayerTwo);
                                    playerList[0].IsEliminated = true;
                                    playerList[1].IsInFinal = true;
                                }
                                else if (playerList[1].IsInQuarter)
                                {
                                    _battleService.CreateBattle(playerList, oArena.ArenaID, false, numberOfPokemonPlayerTwo);
                                    playerList[0].IsEliminated = true;
                                    playerList[1].IsInSemi = true;
                                }
                                else
                                {
                                    _battleService.CreateBattle(playerList, oArena.ArenaID, false, numberOfPokemonPlayerTwo);
                                    playerList[0].IsEliminated = true;
                                    playerList[1].IsInQuarter = true;
                                }
                                MessageBox.Show($"The Winner is {playerList[1].PlayerName}", "Wait...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //The braket is reopened
                                new BracketForm().Show();
                                _battleForm.Close();
                            }
                            else
                            {
                                _battleForm.txtStatsPlayerTwo.Text += $"\n{playerList[1].PlayerName} has eliminated the pokemon";
                                //MessageBox.Show("Player two has eliminated the pokemon", "Wait...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                numberOfPokemonPlayerOne++;
                                healthPokemonPlayerOne = 100;
                                ChangePokemon();
                            }
                        }
                        else _battleForm.progressPokemonPlayer1.Value = healthPokemonPlayerOne;
                    }
                }
            } else {
                MessageBox.Show("Player two has eliminated the pokemon", "Wait...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numberOfPokemonPlayerOne++;
                healthPokemonPlayerOne = 100;
                ChangePokemon();
            }
        }

        private void ChangePokemon() {
            //It helps us to assign a pokemon according to the current pokemon of player one to use and load information into the layout.
            switch (numberOfPokemonPlayerOne) {
                case 0: oPokemon = playerList[0].Team.PokemonOne; break;
                case 1: oPokemon = playerList[0].Team.PokemonTwo; break;
                case 2: oPokemon = playerList[0].Team.PokemonThree; break;
                case 3: oPokemon = playerList[0].Team.PokemonFour; break;
                case 4: oPokemon = playerList[0].Team.PokemonFive; break;
                case 5: oPokemon = playerList[0].Team.PokemonSix; break;
            }

            //Loading player one's pokemon information
            _battleForm.picBoxPokemonPlayer1.BackgroundImage = (Image)Resources.ResourceManager.GetObject($"_{oPokemon.PokemonID}");
            _battleForm.btnAttakOnePlayerOne.Text = oPokemon.MovementOne.MovementName;
            _battleForm.btnAttakTwoPlayerOne.Text = oPokemon.MovementTwo.MovementName;
            _battleForm.btnAttakThreePlayerOne.Text = oPokemon.MovementThree.MovementName;
            _battleForm.btnAttakFourPlayerOne.Text = oPokemon.MovementFour.MovementName;
            _battleForm.lblHealthPlayerOne.Text = $"{healthPokemonPlayerOne}/100";
            _battleForm.progressPokemonPlayer1.Value = healthPokemonPlayerOne;

            //It helps us to assign a pokemon according to the current pokemon of player two to use and load information into the layout.
            switch (numberOfPokemonPlayerTwo) {
                case 0: oPokemon = playerList[1].Team.PokemonOne; break;
                case 1: oPokemon = playerList[1].Team.PokemonTwo; break;
                case 2: oPokemon = playerList[1].Team.PokemonThree; break;
                case 3: oPokemon = playerList[1].Team.PokemonFour; break;
                case 4: oPokemon = playerList[1].Team.PokemonFive; break;
                case 5: oPokemon = playerList[1].Team.PokemonSix; break;
            }

            //Loading player two's pokemon information
            _battleForm.picBoxPokemonPlayer2.BackgroundImage = (Image)Resources.ResourceManager.GetObject($"_{oPokemon.PokemonID}");
            _battleForm.btnAttakOnePlayerTwo.Text = oPokemon.MovementOne.MovementName;
            _battleForm.btnAttakTwoPlayerTwo.Text = oPokemon.MovementTwo.MovementName;
            _battleForm.btnAttakThreePlayerTwo.Text = oPokemon.MovementThree.MovementName;
            _battleForm.btnAttakFourPlayerTwo.Text = oPokemon.MovementFour.MovementName;
            _battleForm.lblHealthPlayerTwo.Text = $"{healthPokemonPlayerTwo}/100";
            _battleForm.progressPokemonPlayer2.Value = healthPokemonPlayerTwo;
        }

        //This method will simulate bot attacks.
        private async Task SimulateBotAttackAsync() {
            await Task.Delay(2000); //Wait 2 seconds to perform the action

            Random random = new Random();
            int randomAttack = random.Next(1, 5);

            //With the number obtained randomly, an attack is executed.
            switch (randomAttack) {
                case 1:
                    AttakPlayerTwo(_battleForm.btnAttakOnePlayerTwo);
                    break;
                case 2:
                    AttakPlayerTwo(_battleForm.btnAttakTwoPlayerTwo);
                    break;
                case 3:
                    AttakPlayerTwo(_battleForm.btnAttakThreePlayerTwo);
                    break;
                case 4:
                    AttakPlayerTwo(_battleForm.btnAttakFourPlayerTwo);
                    break;
            }
        }
    }
}
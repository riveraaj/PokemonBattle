using PokemonBattle.Controllers;
using PokemonBattle.Utilities;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PokemonBattle.Views {
    public partial class BattleForm : Form {

        //Instance & Variables
        internal (string playerOneName, string playerTwoName) values;
        private readonly BattleController _battleController;

        public BattleForm((string playerOneName, string playerTwoName) values){
            this.values = values;
            InitializeComponent();
            //This helps us to customize a list of buttons
            ButtonHelper.CustomizeAppearanceButtons(new List<Button> { btnAttakFourPlayerOne, btnAttakFourPlayerTwo,
               btnAttakOnePlayerTwo, btnAttakOnePlayerOne, 
               btnAttakThreePlayerOne, btnAttakThreePlayerTwo,
               btnAttakTwoPlayerOne,btnAttakTwoPlayerTwo});       
            _battleController = new BattleController(this);
        }

        //Cancel the ability to move the screen
        protected override void WndProc(ref Message m){
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;

            if (m.Msg == WM_NCLBUTTONDOWN && (int)m.WParam == HTCAPTION) return;
            base.WndProc(ref m);
        }
    }
}
using PokemonBattle.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonBattle.Views
{
    public partial class VersusForm : Form {
        //Instances and variables
        internal Timer timer;
        internal (string playerOneName, string playerTwoName) values;
        private readonly VersusController _versusController;

        public VersusForm((string playerOneName, string playerTwoName) values) {
            this.values = values;
            InitializeComponent();
            this._versusController = new VersusController(this);
        }

        //Cancel the ability to move the screen
        protected override void WndProc(ref Message m) {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;

            if (m.Msg == WM_NCLBUTTONDOWN && (int)m.WParam == HTCAPTION) return;
            base.WndProc(ref m);
        }
    }
}
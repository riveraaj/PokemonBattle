using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PokemonBattle.Utilities {
    public class ButtonHelper {

        //Customize the Appearance of the Buttons
        public static void CustomizeAppearanceButtons(List<Button> buttonList){
            buttonList.ForEach(button => {
                // Init Config Button
                button.BackColor = Color.Transparent;
                button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;

                //Event Mouse
                button.MouseEnter += (sender, e) => { ButtonMouseEnter(button); };
                button.MouseLeave += (sender, e) => { ButtonMouseLeave(button); };

                //Event Click
                button.MouseDown += (sender, e) => { ButtonMouseDown(button); };
                button.MouseUp += (sender, e) => { ButtonMouseUp(button); };
            });
        }

        public static Button CreateDinamicButton(string id) {
            Button button = new Button {
                Name = $"btnPlayer{id}",
                Width = 100,
                Height = 40,
                Text = "Go to Pokedex",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Margin = new Padding(3),
                BackgroundImage = Properties.Resources.ButtonChoosePokemon
            };

            CustomizeAppearanceButtons(new List<Button>() { button });
            return button;
        }

        static void ButtonMouseEnter(Button button) => button.BackColor = Color.FromArgb(50, 255, 255, 255);   
        static void ButtonMouseLeave(Button button) => button.BackColor = Color.Transparent;   
        static void ButtonMouseDown(Button button) => button.BackColor = Color.Transparent;
        static void ButtonMouseUp(Button button) => button.BackColor = Color.FromArgb(50, 255, 255, 255);
    }
}
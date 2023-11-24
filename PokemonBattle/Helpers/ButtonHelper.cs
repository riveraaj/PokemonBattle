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

        public static Button CreateDynamicButton(string id, bool haveATeam) {

            var img = (haveATeam) ? Properties.Resources.ButtonChoosePokemonDisable : Properties.Resources.ButtonChoosePokemon;
            Button button = new Button {
                BackgroundImage = img,
                BackgroundImageLayout = ImageLayout.Stretch,
                Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0),
                Location = new Point(13, 48),
                Margin = new Padding(0, 12, 0, 0),
                Name = $"btnPlayer{id}",
                Size = new Size(119, 41),
                TabIndex = 1,
                Text = "Go to Pokedex",
                UseVisualStyleBackColor = false
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
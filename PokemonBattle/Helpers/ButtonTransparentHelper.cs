using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PokemonBattle.Utilities {
    public class ButtonTransparentHelper {
        public static void CustomizeButtonAppearance(List<Button> buttonList){
            buttonList.ForEach(button => {
                // Init Config Button
                button.BackColor = Color.Transparent;
                button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;

                //Event Mouse
                button.MouseEnter += (sender, e) => { Button_MouseEnter(button); };
                button.MouseLeave += (sender, e) => { Button_MouseLeave(button); };

                //Event Click
                button.MouseDown += (sender, e) => { Button_MouseDown(button); };
                button.MouseUp += (sender, e) => { Button_MouseUp(button); };
            });
        }

        static void Button_MouseEnter(Button button) => button.BackColor = Color.FromArgb(50, 255, 255, 255);
        

        static void Button_MouseLeave(Button button) => button.BackColor = Color.Transparent;
        
        static void Button_MouseDown(Button button) => button.BackColor = Color.Transparent;

        static void Button_MouseUp(Button button) => button.BackColor = Color.FromArgb(50, 255, 255, 255);
    }
}
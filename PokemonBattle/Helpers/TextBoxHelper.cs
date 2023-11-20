using System.Drawing;
using System.Windows.Forms;

namespace PokemonBattle.Helpers {
    internal class TextBoxHelper {

        //Create a single input
        public static TextBox CreateDynamicInput(int id){
            return new TextBox {
                Name = $"txtPlayer{id}",
                Width = 89,
                Height = 20,
                TextAlign = HorizontalAlignment.Center,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Margin = new Padding(15)
            };
        }
    }
}
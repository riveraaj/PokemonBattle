using System.Drawing;
using System.Windows.Forms;

namespace PokemonBattle.Helpers {
    internal class LabelHelper  {

        public static Label CreateDynamicLabel(string id){
            return new Label {
                BackColor = Color.FromArgb(150, 0, 0, 0),
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.WhiteSmoke,
                Location = new Point(13, 15),
                Margin = new Padding(0),
                Name = $"lblPLayer{id}",
                Size = new Size(119, 21),
                TabIndex = 0,
                Text = $"{id}",
                TextAlign = ContentAlignment.MiddleCenter
             
            };
        }
    }
}
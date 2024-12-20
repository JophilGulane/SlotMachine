using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Classes
{
    public class Theme_Animal : Theme
    {
        public override Dictionary<string, Image> Symbols => new Dictionary<string, Image>
        {
            { "chicken", Image.FromFile(@"Assets/Animal/01 chicken.png") },
            { "pig", Image.FromFile(@"Assets/Animal/02 pig.png") },
            { "sheep", Image.FromFile(@"Assets/Animal/03 sheep.png") },
            { "turtle", Image.FromFile(@"Assets/Animal/04 turtle.png") },
            { "wolf", Image.FromFile(@"Assets/Animal/05 wolf.png") },
            { "cat", Image.FromFile(@"Assets/Animal/06 cat.png") }
        };
        public override Color BackgroundColor => Color.LightYellow;
        public override Color TextColor => Color.DarkOrange;
    }
}

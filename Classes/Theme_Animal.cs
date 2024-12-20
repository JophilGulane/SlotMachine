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
            { "chicken", Image.FromFile(@"Assets/Animal/01.png") },
            { "pig", Image.FromFile(@"Assets/Animal/02.png") },
            { "sheep", Image.FromFile(@"Assets/Animal/03.png") },
            { "turtle", Image.FromFile(@"Assets/Animal/04.png") },
            { "wolf", Image.FromFile(@"Assets/Animal/05.png") },
            { "cat", Image.FromFile(@"Assets/Animal/06.png") }
        };
        public override Color BackgroundColor => Color.LightYellow;
        public override Color TextColor => Color.DarkOrange;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Classes
{
    public class Theme_Animal : Theme
    {
        public override Image[] Symbols => new[]
        {
            Image.FromFile($"Assets/Animal/01 chicken.png"),
            Image.FromFile($"Assets/Animal/02 pig.png"),
            Image.FromFile($"Assets/Animal/03 sheep.png"),
            Image.FromFile($"Assets/Animal/04 turtle.png"),
            Image.FromFile($"Assets/Animal/05 wolf.png"),
            Image.FromFile($"Assets/Animal/06 cat.png")
        };
        public override Color BackgroundColor => Color.LightYellow;
        public override Color TextColor => Color.DarkOrange;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Classes
{
    public class Theme_Jewels : Theme
    {
        public override Image[] Symbols => new[]
        {
            Image.FromFile($"Assets/Gems/tile008.png"),
            Image.FromFile($"Assets/Gems/tile036.png"),
            Image.FromFile($"Assets/Gems/tile053.png"),
            Image.FromFile($"Assets/Gems/tile073.png"),
            Image.FromFile($"Assets/Gems/tile094.png"),
            Image.FromFile($"Assets/Gems/tile163.png")
        };
        public override Color BackgroundColor => Color.LightBlue;
        public override Color TextColor => Color.DarkBlue;
    }
}

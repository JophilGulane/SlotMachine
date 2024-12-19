using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Classes
{
    public class Theme_Numbers : Theme
    {
        public override Image[] Symbols => new[]
        {
            Image.FromFile($"Assets/Numbers/Number 1.png"),
            Image.FromFile($"Assets/Numbers/Number 2.png"),
            Image.FromFile($"Assets/Numbers/Number 3.png"),
            Image.FromFile($"Assets/Numbers/Number 4.png"),
            Image.FromFile($"Assets/Numbers/Number 5.png"),
            Image.FromFile($"Assets/Numbers/Number 6.png")
        };
        public override Color BackgroundColor => Color.LightGray;
        public override Color TextColor => Color.Black;
    }
}

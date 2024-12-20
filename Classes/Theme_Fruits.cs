using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Classes
{
    public class Theme_Fruits : Theme
    {
        public override Dictionary<string, Image> Symbols => new Dictionary<string, Image>
        {
            { "berry", Image.FromFile("Assets/Fruits/01.png") },
            { "pear", Image.FromFile("Assets/Fruits/02.png") },
            { "cherry", Image.FromFile("Assets/Fruits/03.png") },
            { "banana", Image.FromFile("Assets/Fruits/04.png") },
            { "apple", Image.FromFile("Assets/Fruits/05.png") },
            { "tomato", Image.FromFile("Assets/Fruits/06.png") }

        };
        public override Color BackgroundColor => Color.LightGreen;
        public override Color TextColor => Color.DarkGreen;
    }
}

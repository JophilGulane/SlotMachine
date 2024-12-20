using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Classes
{
    public class Theme_Jewels : Theme
    {
        public override Dictionary<string, Image> Symbols => new Dictionary<string, Image>
        {
            { "red", Image.FromFile("Assets/Gems/tile008.png") },
            { "violet", Image.FromFile("Assets/Gems/tile036.png") },
            { "purple", Image.FromFile("Assets/Gems/tile053.png") },
            { "blue", Image.FromFile("Assets/Gems/tile073.png") },
            { "green", Image.FromFile("Assets/Gems/tile094.png") },
            { "white", Image.FromFile("Assets/Gems/tile163.png") }
        };
        public override Color BackgroundColor => Color.LightBlue;
        public override Color TextColor => Color.DarkBlue;
    }
}

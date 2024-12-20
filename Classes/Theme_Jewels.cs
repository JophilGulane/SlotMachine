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
            { "red", Image.FromFile("Assets/Gems/01.png") },
            { "violet", Image.FromFile("Assets/Gems/02.png") },
            { "purple", Image.FromFile("Assets/Gems/03.png") },
            { "blue", Image.FromFile("Assets/Gems/04.png") },
            { "green", Image.FromFile("Assets/Gems/05.png") },
            { "white", Image.FromFile("Assets/Gems/06.png") }
        };
        public override Color BackgroundColor => Color.LightBlue;
        public override Color TextColor => Color.White;
    }
}

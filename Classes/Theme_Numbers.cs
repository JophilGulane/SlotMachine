using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Classes
{
    public class Theme_Numbers : Theme
    {

        public override Dictionary<string, Image> Symbols => new Dictionary<string, Image>
        {
            { "1", Image.FromFile("Assets/Numbers/01.png") },
            { "2", Image.FromFile("Assets/Numbers/02.png") },
            { "3", Image.FromFile("Assets/Numbers/03.png") },
            { "4", Image.FromFile("Assets/Numbers/04.png") },
            { "5", Image.FromFile("Assets/Numbers/05.png") },
            { "6", Image.FromFile("Assets/Numbers/06.png") },
            { "7", Image.FromFile("Assets/Numbers/07.png") }
        };
        public override Color BackgroundColor => Color.LightGray;
        public override Color TextColor => Color.Black;
    }
}

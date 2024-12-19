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
            { "1", Image.FromFile("Assets/Numbers/Number 1.png") },
            { "2", Image.FromFile("Assets/Numbers/Number 2.png") },
            { "3", Image.FromFile("Assets/Numbers/Number 3.png") },
            { "4", Image.FromFile("Assets/Numbers/Number 4.png") },
            { "5", Image.FromFile("Assets/Numbers/Number 5.png") },
            { "6", Image.FromFile("Assets/Numbers/Number 6.png") }
        };
        public override Color BackgroundColor => Color.LightGray;
        public override Color TextColor => Color.Black;
    }
}

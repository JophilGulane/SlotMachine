using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Classes
{
    public abstract class Theme
    {
        public abstract Image[] Symbols { get; }
        public abstract Color BackgroundColor { get; }
        public abstract Color TextColor { get; }
    }
}

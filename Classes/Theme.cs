using System;
using System.Collections.Generic;
using System.Drawing;

namespace SlotMachine.Classes
{
    public abstract class Theme
    {
        public abstract Dictionary<string, Image> Symbols { get; }
        public abstract Color BackgroundColor { get; }
        public abstract Color TextColor { get; }
    }
}

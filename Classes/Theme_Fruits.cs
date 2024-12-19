﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Classes
{
    public class Theme_Fruits : Theme
    {
        public override Image[] Symbols => new[]
        {
            Image.FromFile($"Assets/Fruits/01.png"),
            Image.FromFile($"Assets/Fruits/02.png"),
            Image.FromFile($"Assets/Fruits/03.png"),
            Image.FromFile($"Assets/Fruits/04.png"),
            Image.FromFile($"Assets/Fruits/05.png"),
            Image.FromFile($"Assets/Fruits/06.png")
        };
        public override Color BackgroundColor => Color.LightGreen;
        public override Color TextColor => Color.DarkGreen;
    }
}

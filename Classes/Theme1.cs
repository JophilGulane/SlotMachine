using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Classes
{
    public abstract class Theme1
    {
        public abstract string[] SymbolPaths { get; }
        public abstract Font Font { get; }
        public abstract Brush Color { get; }
    }
        public class FruitsTheme : Theme1
        {
            public override string[] SymbolPaths => new[]
            {
            "Assets/Fruits/01.png",
            "Assets/Fruits/02.png",
            "Assets/Fruits/03.png",
            "Assets/Fruits/04.png",
            "Assets/Fruits/05.png",
            "Assets/Fruits/06.png"
        };
            public override Font Font => new Font("Segoe UI", 12, FontStyle.Regular);
            public override Brush Color => Brushes.Black;
        }

        public class AnimalsTheme : Theme1
        {
            public override string[] SymbolPaths => new[]
            {
            "Assets/Animals/01.png",
            "Assets/Animals/02.png",
            "Assets/Animals/03.png",
            "Assets/Animals/04.png",
            "Assets/Animals/05.png",
            "Assets/Animals/06.png"
        };
            public override Font Font => new Font("Segoe UI", 12, FontStyle.Regular);
            public override Brush Color => Brushes.Black;
        }

    public class Gems : Theme1
    {
        public override string[] SymbolPaths => new[]
        {
            "Assets/Gems/01.png",
            "Assets/Gems/02.png",
            "Assets/Gems/03.png",
            "Assets/Gems/04.png",
            "Assets/Gems/05.png",
            "Assets/Gems/06.png"
        };
        public override Font Font => new Font("Segoe UI", 12, FontStyle.Regular);
        public override Brush Color => Brushes.Black;
    }

    public class Numbers : Theme1
    {
        public override string[] SymbolPaths => new[]
        {
            "Assets/Numbers/01.png",
            "Assets/Numbers/02.png",
            "Assets/Numbers/03.png",
            "Assets/Numbers/04.png",
            "Assets/Numbers/05.png",
            "Assets/Numbers/06.png"
        };
        public override Font Font => new Font("Segoe UI", 12, FontStyle.Regular);
        public override Brush Color => Brushes.Black;
    }

}

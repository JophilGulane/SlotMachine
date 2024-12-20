using SlotMachine.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SlotMachine.Models
{
    public class Reel
    {
        private string symbolKey; // Stores the key from the Symbols dictionary
        private readonly PictureBox pictureBox;
        private readonly Random random = new Random();
        private Theme theme;

        public string SymbolKey
        {
            get => symbolKey;
            private set
            {
                symbolKey = value;
                pictureBox.Invalidate();
            }
        }

        public Reel(PictureBox pictureBox, Theme theme)
        {
            this.pictureBox = pictureBox;
            this.theme = theme;
            pictureBox.Paint += Reel_Paint;
            Spin();
        }

        public void Spin()
        {
            var keys = new List<string>(theme.Symbols.Keys);
            SymbolKey = keys[random.Next(keys.Count)];
        }

        public void StopSpin()
        {
            // Placeholder for logic to gracefully stop spinning animation
        }

        public void SetTheme(Theme newTheme)
        {
            theme = newTheme;
            Spin(); // Reset to match the new theme
        }

        private void Reel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(theme.BackgroundColor);

            if (theme.Symbols.TryGetValue(SymbolKey, out Image symbolImage))
            {
                e.Graphics.DrawImage(symbolImage, new Rectangle(10, 10, 80, 80));
            }
        }
    }
}

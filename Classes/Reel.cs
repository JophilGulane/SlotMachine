using SlotMachine.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SlotMachine.Models
{
    public class Reel
    {
        private Image symbol;
        private readonly PictureBox pictureBox;
        private Theme theme;
        private readonly Random random = new Random();
        private System.Windows.Forms.Timer spinTimer;

        public Reel(PictureBox pictureBox, Theme initialTheme)
        {
            if (pictureBox == null) throw new ArgumentNullException(nameof(pictureBox), "PictureBox cannot be null.");
            if (initialTheme == null) throw new ArgumentNullException(nameof(initialTheme), "Theme cannot be null.");

            this.pictureBox = pictureBox;
            SetTheme(initialTheme); // Initialize with a valid theme
        }

        public Image Symbol
        {
            get => symbol;
            private set
            {
                symbol = value;
                pictureBox.Image = symbol; // Update the PictureBox with the new symbol
            }
        }

        public void SetTheme(Theme newTheme)
        {
            if (newTheme == null) throw new ArgumentNullException(nameof(newTheme), "Theme cannot be null.");

            theme = newTheme;
            pictureBox.BackColor = theme.BackgroundColor; // Set the background color for the PictureBox
            Spin(); // Start spinning with the new theme
        }

        public void Spin()
        {
            if (spinTimer == null)
            {
                spinTimer = new System.Windows.Forms.Timer { Interval = 100 }; // Adjust interval for spinning speed
                spinTimer.Tick += (s, e) =>
                {
                    if (theme.Symbols == null || theme.Symbols.Length == 0)
                    {
                        throw new InvalidOperationException("Theme's Symbols are not initialized or empty.");
                    }

                    Symbol = theme.Symbols[random.Next(theme.Symbols.Length)];
                };
            }

            spinTimer.Start(); // Start the spinning animation
        }

        public void StopSpin()
        {
            spinTimer?.Stop(); // Stop the spinning animation
        }
    }
}

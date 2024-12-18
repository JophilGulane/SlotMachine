using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace SlotMachine.Classes
{

    public class TransparentGifForm : Form
    {
        private Image gifImage;

        public TransparentGifForm()
        {
            // Load your GIF with a transparent background
            gifImage = Image.FromFile("your_gif.gif");

            // Set double buffering to reduce flickering
            this.DoubleBuffered = true;

            // Set the form background color to a desired color (or keep default)
            this.BackColor = Color.LightGray; // Adjust as needed
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw the GIF at the desired position
            e.Graphics.DrawImage(gifImage, new Point(50, 50)); // Adjust position
        }

        private void InitializeComponent()
        {

        }

        [STAThread]
        public static void Main()
        {
            Application.Run(new TransparentGifForm());
        }
    }

}

using System;
using System.Drawing;
using System.Windows.Forms;
using SlotMachine.Classes;
using SlotMachine.Models;
namespace SlotMachine
{
    public partial class Form1 : Form
    {
        private Slot slotMachine;
        private System.Windows.Forms.Timer timerSpin = new System.Windows.Forms.Timer();
        AudioManager audioManager = new AudioManager();
        private System.Windows.Forms.Timer masterSpinTimer;
        private int spinCount;
        public Form1()
        {
            InitializeComponent();

            audioManager.PlayBackgroundMusic(@"SoundFX/tmpBG.mp3");
            audioManager.SetBackgroundMusicVolume(0.05f);

            // Initialize PictureBoxes for reels
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3 };
            Reel[] reels = new Reel[pictureBoxes.Length];

            // Default theme
            Theme defaultTheme = new Theme_Fruits();
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                reels[i] = new Reel(pictureBoxes[i], defaultTheme);
            }


            // Initialize SlotMachine object with initial balance of 1000
            slotMachine = new Slot(1000, reels);

            // Update the balance label on the form
            lblBalance.Text = "Balance: P" + slotMachine.Balance;
            comboBox1.Items.AddRange(new[] { "Fruits", "Animals", "Jewels", "Numbers" });
            comboBox1.SelectedIndex = 0; // Default selection
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            spinCount = 20; // Number of cycles to spin
            slotMachine.Spin();

            masterSpinTimer = new System.Windows.Forms.Timer { Interval = 100 };
            masterSpinTimer.Tick += (s, ev) =>
            {
                spinCount--;
                if (spinCount <= 0)
                {
                    masterSpinTimer.Stop();
                    slotMachine.StopSpin();

                    int winnings = slotMachine.CheckResult();
                    lblResult.Text = winnings > 0
                        ? $"🎉 WIN! You earned P{winnings} 🎉"
                        : "No luck this time!";
                    lblBalance.Text = "Balance: P" + slotMachine.Balance;
                }
            };
            masterSpinTimer.Start();
        }

        private void timerSpin_Tick(object sender, EventArgs e)
        {
            slotMachine.Spin();			// Spin the reels
            btnSpin.BackgroundImage = SlotMachine.Assets.Assets.slot_machine3;

            if (DateTime.Now.Second % 2 == 0) 	// Stop spinning after 2 seconds
            {
                btnSpin.BackgroundImage = SlotMachine.Assets.Assets.slot_machine2;
                timerSpin.Stop();
                btnSpin.Enabled = true;

                int winnings = slotMachine.CheckResult();	// Check the result and update the UI accordingly

                slotMachine.UpdateBalance(winnings);

                // Update the result label
                if (winnings > 0)
                {
                    lblResult.Text = "🎉 WIN! You earned P" + winnings + " 🎉";
                    audioManager.PlaySoundEffect(@"SoundFX/tmpWinEffect.mp3");
                    lblResult.ForeColor = Color.Green;
                }
                else
                {
                    lblResult.Text = "No luck this time!";
                    lblResult.ForeColor = Color.Red;
                }

                lblBalance.Text = "Balance: P" + slotMachine.Balance;
                txtStake.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Theme selectedTheme = comboBox1.SelectedItem switch
            {
                "Fruits" => new Theme_Fruits(),
                "Animals" => new Theme_Animal(),
                "Jewels" => new Theme_Jewels(),
                "Numbers" => new Theme_Numbers(),
                _ => throw new InvalidOperationException("Invalid theme selection.") // Detect invalid state
            };

            slotMachine.SetTheme(selectedTheme);
            UpdateFormAppearance(selectedTheme);
        }
        private void UpdateFormAppearance(Theme theme)
        {
            this.BackColor = theme.BackgroundColor;
            lblBalance.ForeColor = theme.TextColor;
            lblResult.ForeColor = theme.TextColor;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

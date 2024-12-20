using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SlotMachine.Classes;
using SlotMachine.Models;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        private Slot slotMachine;
        private System.Windows.Forms.Timer masterSpinTimer;
        private int spinCount;
        private readonly AudioManager audioManager = new AudioManager();

        public Form1()
        {
            InitializeComponent();

            InitializeAudio();
            InitializeReelsAndSlotMachine();
            InitializeUIComponents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void InitializeAudio()
        {
            audioManager.PlayBackgroundMusic(@"SoundFX/tmpBG.mp3");
            audioManager.SetBackgroundMusicVolume(0.05f);
        }

        private void InitializeReelsAndSlotMachine()
        {
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3 };
            Reel[] reels = pictureBoxes.Select(pb => new Reel(pb, new Theme_Fruits())).ToArray();
            slotMachine = new Slot(1000, reels);
            lblBalance.Text = $"Balance: P{slotMachine.Balance}";
        }

        private void InitializeUIComponents()
        {
            comboBox1.Items.AddRange(new[] { "Fruits", "Animals", "Jewels", "Numbers" });
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStake.Text, out int stake) || stake <= 0)
            {
                MessageBox.Show("Please enter a valid positive stake.");
                return;
            }

            StartSpin(stake);
        }

        private void StartSpin(int stake)
        {
            spinCount = 20;
            slotMachine.Stake = stake;
            slotMachine.Spin();

            masterSpinTimer = new System.Windows.Forms.Timer { Interval = 100 };
            masterSpinTimer.Tick += MasterSpinTimer_Tick;
            masterSpinTimer.Start();
        }

        private void MasterSpinTimer_Tick(object sender, EventArgs e)
        {
            spinCount--;
            foreach (var reel in slotMachine.Reels)
            {
                reel.Spin(); // Keep showing random results while spinning
            }

            if (spinCount <= 0)
            {
                masterSpinTimer.Stop();
                slotMachine.StopSpin();

                int winnings = slotMachine.CheckResult();
                UpdateUIAfterSpin(winnings);
            }
        }

        private void UpdateUIAfterSpin(int winnings)
        {
            lblResult.Text = winnings > 0
                ? $"🎉 WIN! You earned P{winnings} 🎉"
                : "No luck this time!";

            lblResult.ForeColor = winnings > 0 ? Color.Green : Color.Red;

            if (winnings > 0)
            {
                audioManager.PlaySoundEffect(@"SoundFX/tmpWinEffect.mp3");
                slotMachine.UpdateBalance(winnings);
            }

            lblBalance.Text = $"Balance: P{slotMachine.Balance}";
            txtStake.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Theme selectedTheme = comboBox1.SelectedItem switch
            {
                "Fruits" => new Theme_Fruits(),
                "Animals" => new Theme_Animal(),
                "Jewels" => new Theme_Jewels(),
                "Numbers" => new Theme_Numbers(),
                _ => throw new InvalidOperationException("Invalid theme selection.")
            };

            slotMachine.SetTheme(selectedTheme);
            UpdateFormAppearance(selectedTheme);
        }

        private void UpdateFormAppearance(Theme theme)
        {
            BackColor = theme.BackgroundColor;
            lblBalance.ForeColor = theme.TextColor;
            lblResult.ForeColor = theme.TextColor;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
    }
}
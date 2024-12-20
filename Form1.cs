using System;
using System.Drawing;
using System.Windows.Forms;
using SlotMachine.Models;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        private Slot slotMachine;
        private Timer timerSpin = new Timer(); // Initialize the timer

        public Form1()
        {
            InitializeComponent();

            // Initialize PictureBoxes for reels
            PictureBox[] pictureBoxes = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3 };

            // Create Reel objects for each PictureBox
            Reel[] reels = new Reel[pictureBoxes.Length];
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                reels[i] = new Reel(pictureBoxes[i]);
            }

            // Initialize SlotMachine object with initial balance of 1000
            slotMachine = new Slot(1000, reels);

            // Update the balance label on the form
            lblBalance.Text = "Balance: P" + slotMachine.Balance;

            // Configure the timer
            timerSpin.Interval = 100; // Set the timer interval to 100ms
            timerSpin.Tick += timerSpin_Tick; // Attach the Tick event handler
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Any form initialization code can go here
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            // Get the stake from the input box
            if (int.TryParse(txtStake.Text, out int stake) && stake > 0 && stake <= slotMachine.Balance)
            {
                slotMachine.Stake = stake;
                slotMachine.UpdateBalance(-stake);
                lblBalance.Text = "Balance: P" + slotMachine.Balance;

                btnSpin.Enabled = false;     // Disable the button during spin
                lblResult.Text = "";       // Clear any previous result
                timerSpin.Start();          // Start the timer for spinning
            }
            else
            {
                MessageBox.Show("Please enter a valid stake amount (between 1 and your balance).", "Invalid Stake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timerSpin_Tick(object sender, EventArgs e)
        {
            slotMachine.Spin(); // Spin the reels

            // Stop spinning after 2 seconds
            if (DateTime.Now.Second % 2 == 0)
            {
                timerSpin.Stop();
                btnSpin.Enabled = true;

                int winnings = slotMachine.CheckResult(); // Check the result and update the UI accordingly
                slotMachine.UpdateBalance(winnings);

                // Update the result label
                if (winnings > 0)
                {
                    lblResult.Text = "\uD83C\uDF89 WIN! You earned P" + winnings + " \uD83C\uDF89";
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
    }
}

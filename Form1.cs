using System;
using System.Drawing;
using System.Windows.Forms;
using SlotMachine.Models;
namespace SlotMachine
{
    public partial class Form1 : Form
    {
        private Slot slotMachine;
        private System.Windows.Forms.Timer timerSpin = new System.Windows.Forms.Timer();

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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            // Get the stake from the input box
            if (int.TryParse(txtStake.Text, out int stake) && stake > 0 && stake <= slotMachine.Balance)
            {
                

                slotMachine.Stake = stake;
                slotMachine.UpdateBalance(-stake);
                lblBalance.Text = "Balance: P" + slotMachine.Balance;

                btnSpin.Enabled = false; 	// Disable the button during spin
                lblResult.Text = "";  	// Clear any previous result
                timerSpin.Interval = 200; // Set the tick interval (in milliseconds)
                timerSpin.Tick += timerSpin_Tick;
                timerSpin.Start();
            }
            else
            {
                MessageBox.Show("Please enter a valid stake amount (between 1 and your balance).");
            }
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

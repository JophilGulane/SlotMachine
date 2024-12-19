using SlotMachine.Classes;
using System;
using System.Linq;

namespace SlotMachine.Models
{
    public class Slot
    {
        private int balance;
        private int stake;
        private readonly Reel[] reels;

        public Slot(int initialBalance, Reel[] reels)
        {
            if (reels == null || reels.Length == 0)
                throw new ArgumentException("Reels cannot be null or empty.", nameof(reels));

            this.balance = initialBalance;
            this.reels = reels;
        }

        public int Balance { get => balance; set => balance = value; }
        public int Stake
        {
            get => stake;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(value), "Stake must be a positive number.");
                stake = value;
            }
        }

        public void Spin()
        {
            if (stake > balance)
                throw new InvalidOperationException("Stake cannot exceed current balance.");

            // Deduct stake before spinning
            Balance -= stake;

            foreach (var reel in reels)
            {
                reel.Spin();
            }
        }

        public void StopSpin()
        {
            foreach (var reel in reels)
            {
                reel.StopSpin();
            }
        }

        public void SetTheme(Theme theme)
        {
            if (theme == null)
                throw new ArgumentNullException(nameof(theme), "Theme cannot be null.");

            foreach (var reel in reels)
            {
                reel.SetTheme(theme);
            }
        }

        public int CheckResult()
        {
            if (reels.All(r => r.Symbol == reels[0].Symbol))
            {
                return stake * 10; // Jackpot
            }

            if (reels[0].Symbol == reels[1].Symbol || reels[1].Symbol == reels[2].Symbol || reels[0].Symbol == reels[2].Symbol)
            {
                return stake * 2; // Partial match
            }

            return 0; // No match
        }

        public void UpdateBalance(int winnings)
        {
            if (winnings < 0)
                throw new ArgumentOutOfRangeException(nameof(winnings), "Winnings cannot be negative.");

            Balance += winnings;
        }
    }
}

using SlotMachine.Classes;
using System;
using System.Diagnostics;
using System.Linq;

namespace SlotMachine.Models
{
    public class Slot
    {
        private int balance;
        private int stake;
        private readonly Reel[] reels;

        public Reel[] Reels => reels;

        public Slot(int initialBalance, Reel[] reels)
        {
            if (reels == null || reels.Length == 0)
                throw new ArgumentException("Reels cannot be null or empty.", nameof(reels));

            balance = initialBalance;
            this.reels = reels;
        }

        public int Balance
        {
            get => balance;
            set => balance = value;
        }

        public int Stake
        {
            get => stake;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "Stake must be a positive number.");
                stake = value;
            }
        }

        public void Spin()
        {
            if (stake > balance)
                throw new InvalidOperationException("Insufficient balance to place the stake.");

            Debug.WriteLine($"Spin called. Current balance: {balance}, Stake: {stake}");

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
            bool isJackpot = reels.All(r => r.SymbolKey == reels[0].SymbolKey);

            if (isJackpot)
            {
                Debug.WriteLine("Jackpot detected!");
                return stake * 10;
            }

            bool isPartialMatch = reels
                .GroupBy(r => r.SymbolKey)
                .Any(g => g.Count() > 1);

            if (isPartialMatch)
            {
                Debug.WriteLine("Partial match detected!");
                return stake * 2;
            }

            return 0;
        }

        private bool IsSymbolsEqual(string key1, string key2)
        {
            return key1 == key2; // Compare the keys directly
        }

        public void UpdateBalance(int winnings)
        {
            if (winnings < 0)
                throw new ArgumentOutOfRangeException(nameof(winnings), "Winnings cannot be negative.");

            Balance += winnings;
        }
    }
}
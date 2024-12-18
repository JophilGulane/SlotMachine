using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Models
{
    public class Slot
    {
        private int balance;
        private int stake;
        private readonly Reel[] reels;

        public Slot(int initialBalance, Reel[] reels)
        {
            this.balance = initialBalance;
            this.reels = reels;
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public int Stake
        {
            get { return stake; }
            set { stake = value; }
        }

        public void Spin()
        {
            // Spin each reel
            foreach (var reel in reels)
            {
                reel.Spin();
            }
        }

        public int CheckResult()
        {
            int winnings = 0;

            // Check if all three symbols are the same (Jackpot)
            if (reels[0].Symbol == reels[1].Symbol && reels[1].Symbol == reels[2].Symbol)
            {
                winnings = stake * 10;  // Win 10x stake
            }
            // Check if two symbols match
            else if (reels[0].Symbol == reels[1].Symbol || reels[1].Symbol == reels[2].Symbol || reels[0].Symbol == reels[2].Symbol)
            {
                winnings = stake * 2;  // Win 2x stake
            }

            return winnings;
        }

        public void UpdateBalance(int winnings)
        {
            Balance += winnings;
        }
    }
}

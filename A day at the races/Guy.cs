using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_day_at_the_races
{
    class Guy
    {
        public string name;
        public Bet myBet;
        public decimal cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        private void UpdateLabels()
        {
            MyRadioButton.Text = name + " has " + cash + " dollar";
        }

        private void ClearBet()
        {
            myBet = null;
            MyLabel.Text = name + " hasn't placed a bet";
        }

        public bool PlaceBet(decimal betAmount, int dogChoice)
        {
            myBet = new Bet() { amount = betAmount, dog = dogChoice, Bettor = this};
            if (betAmount < cash)
            {
                MyLabel.Text = this.name + " bets " + betAmount + " dollars on dog number " + dogChoice;
                UpdateLabels();
                return true;
            }
            else
            {
                myBet = null;
                return false;
            }
        }

        public void Collect(int winner)
        {
            if (myBet != null)
            {
                cash = cash + myBet.PayOut(winner);
                ClearBet();
                UpdateLabels();
            }
        }
    }
}

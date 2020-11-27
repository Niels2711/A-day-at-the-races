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
        private string name;
        private Bet myBet;
        private int cash;

        private RadioButton myRadioButton;
        private Label myLabel;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Bet MyBet
        {
            get { return myBet; }
            set { myBet = value; }
        }
        public int Cash
        {
            get { return cash; }
            set { cash = value; }
        }
        public RadioButton MyRadioButton
        {
            get { return myRadioButton; }
            set { myRadioButton = value; }
        }
        public Label MyLabel
        {
            get { return myLabel; }
            set { myLabel = value; }
        }

        public void UpdateLabels()
        {
            myRadioButton.Text = name + " has " + cash + " dollar";
        }

        private void ClearBet()
        {
            myBet = null;
            myLabel.Text = name + " hasn't placed a bet";
        }

        public bool PlaceBet(int betAmount, int dogChoice)
        {
            myBet = new Bet() { Amount = betAmount, Dog = dogChoice, Bettor = this};
            if (betAmount < cash)
            {
                myLabel.Text = this.name + " bets " + betAmount + " dollars on dog number " + dogChoice;
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

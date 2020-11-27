using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_day_at_the_races
{
    class Bet
    {
        private int amount;
        private int dog;
        private Guy bettor;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public int Dog
        {
            get { return dog; }
            set { dog = value; }
        }
        public Guy Bettor
        {
            get { return bettor; }
            set { bettor = value; }
        }

        public string GetDescription()
        {
            if (amount == 0)
            {
                return bettor.Name + "hasn't placed a bet.";
            }
            else
            {
                return bettor.Name + " placed a bet of " + Amount + " dollars on " + Dog;
            }
        }

        public int PayOut(int winner)
        {
            if (winner == dog)
            {
                return amount;
            }
            else
            {
                return 0 - amount;
            }
        }
    }
}

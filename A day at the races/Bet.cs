using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_day_at_the_races
{
    class Bet
    {
        public decimal amount;
        public int dog;
        public Guy Bettor;

        public string GetDescription()
        {
            if (amount == 0)
            {
                return Bettor.name + " hasn't placed a bet.";
            }
            else
            {
                return Bettor.name + " placed a bet of " + amount + "dollars on dog number" + dog;
            }
        }

        public decimal PayOut(int winner)
        {
            if (winner == dog)
            {
                return amount * 2;
            }
            else
            {
                return (0 - amount);
            }
        }
    }
}

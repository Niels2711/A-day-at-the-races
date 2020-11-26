using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_day_at_the_races
{
    class Dog
    {
        public int startingPosition;
        public int raceTrackLength;
        public PictureBox MyPictureBox = null;
        public int location = 0;
        public bool winner = false;
        public Random randomizer;
        public string dogNumber;

        public bool Run()
        {
            int moveAmount = randomizer.Next(1, 5);
            location = location + moveAmount;
            MyPictureBox.Left = startingPosition + location;
            if (MyPictureBox.Left >= raceTrackLength)
            {
                winner = true;
                return true;
            }
            else
            {
                winner = false;
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            location = 0;
            MyPictureBox.Left = startingPosition;
        }
    }
}

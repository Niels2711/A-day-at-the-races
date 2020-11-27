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
        private int startingPosition;
        private int raceTrackLength;
        private PictureBox myPictureBox = null;
        private int location = 0;
        private Random randomizer;
        private int dogNumber;

        public int StartingPosition
        {
            get { return startingPosition; }
            set { startingPosition = value; }
        }
        public int RaceTrackLength
        {
            get { return raceTrackLength; }
            set { raceTrackLength = value; }
        }
        public PictureBox MyPictureBox
        {
            get { return myPictureBox; }
            set { myPictureBox = value; }
        }
        public Random Randomizer
        {
            get { return randomizer; }
            set { randomizer = value; }
        }
        public int DogNumber
        {
            get { return dogNumber; }
            set { dogNumber = value; }
        }
        

        public bool Run()
        {
            int move = randomizer.Next(1, 5);
            location = location + move;
            myPictureBox.Left = startingPosition + location;
            if (myPictureBox.Left >= raceTrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            location = 0;
            myPictureBox.Left = startingPosition;
        }
    }
}

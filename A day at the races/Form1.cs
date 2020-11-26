using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_day_at_the_races
{
    public partial class Form1 : Form
    {
        Dog[] dogArray = new Dog[4];
        decimal joesBet = 0;
        decimal bobsBet = 0;
        decimal alsBet = 0;
        bool bet = false;
        public string winningDog;
        Guy[] guyArray = new Guy[3];
        Random randomNumber = new Random();

        public Form1()
        {
            InitializeComponent();

            // Array with objects (The dogs)
            dogArray[0] = new Dog()
            {
                MyPictureBox = dog1,
                raceTrackLength = raceTrack.Width - dog1.Width,
                startingPosition = dog1.Left,
                randomizer = randomNumber,
                dogNumber = "1"
            };
            dogArray[1] = new Dog()
            {
                MyPictureBox = dog2,
                raceTrackLength = raceTrack.Width - dog2.Width,
                startingPosition = dog2.Left,
                randomizer = randomNumber,
                dogNumber = "2"
            };
            dogArray[2] = new Dog()
            {
                MyPictureBox = dog3,
                raceTrackLength = raceTrack.Width - dog3.Width,
                startingPosition = dog3.Left,
                randomizer = randomNumber,
                dogNumber = "3"
            };
            dogArray[3] = new Dog()
            {
                MyPictureBox = dog4,
                raceTrackLength = raceTrack.Width - dog4.Width,
                startingPosition = dog4.Left,
                randomizer = randomNumber,
                dogNumber = "4"
            };

            // Array with objects (The bettors)
            guyArray[0] = new Guy()
            {
                myBet = null,
                name = "Joe",
                cash = 50,
                MyLabel = joeBet,
                MyRadioButton = joeBetButton
            };
            guyArray[1] = new Guy()
            {
                myBet = null,
                name = "Bob",
                cash = 75,
                MyLabel = bobBet,
                MyRadioButton = bobBetButton
            };
            guyArray[2] = new Guy()
            {
                myBet = null,
                name = "Al",
                cash = 45,
                MyLabel = alBet,
                MyRadioButton = alBetButton
            };
        }

        private void dog1_Click(object sender, EventArgs e)
        {

        }

        private void dog2_Click(object sender, EventArgs e)
        {

        }

        private void dog3_Click(object sender, EventArgs e)
        {

        }

        private void dog4_Click(object sender, EventArgs e)
        {

        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            dogArray[0].TakeStartingPosition();
            dogArray[1].TakeStartingPosition();
            dogArray[2].TakeStartingPosition();
            dogArray[3].TakeStartingPosition();
            timer1.Start();
            raceButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dogArray.Length; i++)
            {
                dogArray[i].Run();
                if (dogArray[i].Run() == true)
                {
                    timer1.Stop();
                    timer1.Enabled = false;
                    MessageBox.Show("Dog number " + dogArray[i].dogNumber + " has won the race!");
                    winningDog = dogArray[i].dogNumber;
                    guyArray[0].Collect(Int32.Parse(winningDog));
                    guyArray[1].Collect(Int32.Parse(winningDog));
                    guyArray[2].Collect(Int32.Parse(winningDog));
                    raceButton.Enabled = true;
                }
            }
        }

        private void joeBetButton_CheckedChanged(object sender, EventArgs e)
        {
            if (joeBetButton.Enabled)
            {
                nameBet.Text = "Joe ";
            }
        }

        private void bobBetButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bobBetButton.Enabled)
            {
                nameBet.Text = "Bob ";
            }
        }

        private void alBetButton_CheckedChanged(object sender, EventArgs e)
        {
            if (alBetButton.Enabled)
            {
                nameBet.Text = "Al ";
            }
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if (nameBet.Text == "Joe ")
            {
                if (joesBet == 0)
                {
                    bet = guyArray[0].PlaceBet(betAmount.Value, Convert.ToInt32(dogNumber.Value));
                    if (bet == true)
                    {
                        joesBet = 1;
                    }
                }
                else
                {
                    MessageBox.Show("Joe has already made a bet");
                }
            }
            if (nameBet.Text == "Bob ")
            {
                if (bobsBet == 0)
                {
                    bet = guyArray[1].PlaceBet(betAmount.Value, Convert.ToInt32(dogNumber.Value));
                    if (bet == true)
                    {
                        bobsBet = 1;
                    }
                }
                else
                {
                    MessageBox.Show("Bob has already made a bet");
                }
            }
            if (nameBet.Text == "Al ")
            {
                if (alsBet == 0)
                {
                    bet = guyArray[2].PlaceBet(betAmount.Value, Convert.ToInt32(dogNumber.Value));
                    if (bet == true)
                    {
                        alsBet = 1;
                    }
                }
                else
                {
                    MessageBox.Show("Bob has already made a bet");
                }
            }
        }
    }
}

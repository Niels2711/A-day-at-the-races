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
        Dog[] dogs = new Dog[4];
        Guy[] guys = new Guy[3];
        Random randomizer = new Random();

        public Form1()
        {
            InitializeComponent();

            dogs[0] = new Dog()
            {
                MyPictureBox = dog1,
                RaceTrackLength = raceTrack.Width - dog1.Width,
                StartingPosition = dog1.Left,
                Randomizer = randomizer,
                DogNumber = 1                
            };
            dogs[1] = new Dog()
            {
                MyPictureBox = dog2,
                RaceTrackLength = raceTrack.Width - dog2.Width,
                StartingPosition = dog2.Left,
                Randomizer = randomizer,
                DogNumber = 2
            };
            dogs[2] = new Dog()
            {
                MyPictureBox = dog3,
                RaceTrackLength = raceTrack.Width - dog3.Width,
                StartingPosition = dog3.Left,
                Randomizer = randomizer,
                DogNumber = 3
            };
            dogs[3] = new Dog()
            {
                MyPictureBox = dog4,
                RaceTrackLength = raceTrack.Width - dog3.Width,
                StartingPosition = dog4.Left,
                Randomizer = randomizer,
                DogNumber = 4
            };
            
            guys[0] = new Guy()
            {
                Name = "Joe",
                MyBet = null,
                Cash = 50,
                MyLabel = joeBet,
                MyRadioButton = joeBetButton
            };
            guys[1] = new Guy()
            {
                Name = "Bob",
                MyBet = null,
                Cash = 75,
                MyLabel = bobBet,
                MyRadioButton = bobBetButton
            };
            guys[2] = new Guy()
            {
                Name = "Al",
                MyBet = null,
                Cash = 45,
                MyLabel = alBet,
                MyRadioButton = alBetButton
            };

            guys[0].UpdateLabels();
            guys[1].UpdateLabels();
            guys[2].UpdateLabels();
            minimumBetLabel.Text = "Minimum bet: " + betAmount.Minimum + " dollar";
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
            dogs[0].TakeStartingPosition();
            dogs[1].TakeStartingPosition();
            dogs[2].TakeStartingPosition();
            dogs[3].TakeStartingPosition();
            raceButton.Enabled = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].Run();
                if (dogs[i].Run() == true)
                {
                    timer1.Stop();
                    timer1.Enabled = false;
                    MessageBox.Show("Dog number " + dogs[i].DogNumber + " has won the race!");
                    raceButton.Enabled = true;
                    int winnerDog = dogs[i].DogNumber;
                    guys[0].Collect(winnerDog);
                    guys[1].Collect(winnerDog);
                    guys[2].Collect(winnerDog);
                    dogs[0].TakeStartingPosition();
                    dogs[1].TakeStartingPosition();
                    dogs[2].TakeStartingPosition();
                    dogs[3].TakeStartingPosition();
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
                if (guys[0].MyBet == null)
                {
                    guys[0].PlaceBet(Convert.ToInt32(betAmount.Value), Convert.ToInt32(dogNumber.Value));
                }
                else
                {
                    MessageBox.Show(guys[0].Name + " has already placed a bet!");
                }
            }
            else if (nameBet.Text == "Bob ")
            {
                if (guys[1].MyBet == null)
                {
                    guys[1].PlaceBet(Convert.ToInt32(betAmount.Value), Convert.ToInt32(dogNumber.Value));
                }
                else
                {
                    MessageBox.Show(guys[1].Name + " has already placed a bet!");
                }
            }
            else if (nameBet.Text == "Al ")
            {
                if (guys[2].MyBet == null)
                {
                    guys[2].PlaceBet(Convert.ToInt32(betAmount.Value), Convert.ToInt32(dogNumber.Value));
                }
                else
                {
                    MessageBox.Show(guys[2].Name + " has already placed a bet!");
                }
            }
        }

        private void minimumBetLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void raceTrack_Click(object sender, EventArgs e)
        {

        }
    }
}

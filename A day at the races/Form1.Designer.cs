namespace A_day_at_the_races
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.raceTrack = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.betterParlor = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.joeBetButton = new System.Windows.Forms.RadioButton();
            this.bobBetButton = new System.Windows.Forms.RadioButton();
            this.alBetButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.betsLabel = new System.Windows.Forms.Label();
            this.joeBet = new System.Windows.Forms.Label();
            this.bobBet = new System.Windows.Forms.Label();
            this.alBet = new System.Windows.Forms.Label();
            this.raceButton = new System.Windows.Forms.Button();
            this.nameBet = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.Button();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.bucksOnDog = new System.Windows.Forms.Label();
            this.dogNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            this.betterParlor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // raceTrack
            // 
            this.raceTrack.Location = new System.Drawing.Point(13, 13);
            this.raceTrack.Name = "raceTrack";
            this.raceTrack.Size = new System.Drawing.Size(775, 217);
            this.raceTrack.TabIndex = 0;
            this.raceTrack.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.Location = new System.Drawing.Point(13, 13);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(119, 59);
            this.dog1.TabIndex = 1;
            this.dog1.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Location = new System.Drawing.Point(13, 70);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(119, 55);
            this.dog2.TabIndex = 2;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Location = new System.Drawing.Point(13, 122);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(119, 57);
            this.dog3.TabIndex = 3;
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.Location = new System.Drawing.Point(13, 177);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(119, 53);
            this.dog4.TabIndex = 4;
            this.dog4.TabStop = false;
            // 
            // betterParlor
            // 
            this.betterParlor.Controls.Add(this.dogNumber);
            this.betterParlor.Controls.Add(this.bucksOnDog);
            this.betterParlor.Controls.Add(this.betAmount);
            this.betterParlor.Controls.Add(this.betButton);
            this.betterParlor.Controls.Add(this.nameBet);
            this.betterParlor.Controls.Add(this.raceButton);
            this.betterParlor.Controls.Add(this.alBet);
            this.betterParlor.Controls.Add(this.bobBet);
            this.betterParlor.Controls.Add(this.joeBet);
            this.betterParlor.Controls.Add(this.betsLabel);
            this.betterParlor.Controls.Add(this.minimumBetLabel);
            this.betterParlor.Controls.Add(this.alBetButton);
            this.betterParlor.Controls.Add(this.bobBetButton);
            this.betterParlor.Controls.Add(this.joeBetButton);
            this.betterParlor.Location = new System.Drawing.Point(13, 237);
            this.betterParlor.Name = "betterParlor";
            this.betterParlor.Size = new System.Drawing.Size(775, 201);
            this.betterParlor.TabIndex = 5;
            this.betterParlor.TabStop = false;
            this.betterParlor.Text = "Betting Parlor";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // joeBetButton
            // 
            this.joeBetButton.AutoSize = true;
            this.joeBetButton.Location = new System.Drawing.Point(6, 53);
            this.joeBetButton.Name = "joeBetButton";
            this.joeBetButton.Size = new System.Drawing.Size(52, 21);
            this.joeBetButton.TabIndex = 0;
            this.joeBetButton.TabStop = true;
            this.joeBetButton.Text = "Joe";
            this.joeBetButton.UseVisualStyleBackColor = true;
            // 
            // bobBetButton
            // 
            this.bobBetButton.AutoSize = true;
            this.bobBetButton.Location = new System.Drawing.Point(6, 80);
            this.bobBetButton.Name = "bobBetButton";
            this.bobBetButton.Size = new System.Drawing.Size(54, 21);
            this.bobBetButton.TabIndex = 1;
            this.bobBetButton.TabStop = true;
            this.bobBetButton.Text = "Bob";
            this.bobBetButton.UseVisualStyleBackColor = true;
            // 
            // alBetButton
            // 
            this.alBetButton.AutoSize = true;
            this.alBetButton.Location = new System.Drawing.Point(6, 108);
            this.alBetButton.Name = "alBetButton";
            this.alBetButton.Size = new System.Drawing.Size(41, 21);
            this.alBetButton.TabIndex = 2;
            this.alBetButton.TabStop = true;
            this.alBetButton.Text = "Al";
            this.alBetButton.UseVisualStyleBackColor = true;
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Location = new System.Drawing.Point(6, 30);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(88, 17);
            this.minimumBetLabel.TabIndex = 3;
            this.minimumBetLabel.Text = "Minimum Bet";
            // 
            // betsLabel
            // 
            this.betsLabel.AutoSize = true;
            this.betsLabel.Location = new System.Drawing.Point(565, 28);
            this.betsLabel.Name = "betsLabel";
            this.betsLabel.Size = new System.Drawing.Size(36, 17);
            this.betsLabel.TabIndex = 4;
            this.betsLabel.Text = "Bets";
            // 
            // joeBet
            // 
            this.joeBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBet.Location = new System.Drawing.Point(568, 53);
            this.joeBet.Name = "joeBet";
            this.joeBet.Size = new System.Drawing.Size(164, 23);
            this.joeBet.TabIndex = 5;
            this.joeBet.Text = "Joe\'s Bet";
            // 
            // bobBet
            // 
            this.bobBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBet.Location = new System.Drawing.Point(568, 81);
            this.bobBet.Name = "bobBet";
            this.bobBet.Size = new System.Drawing.Size(164, 23);
            this.bobBet.TabIndex = 6;
            this.bobBet.Text = "Bob\'s Bet";
            // 
            // alBet
            // 
            this.alBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBet.Location = new System.Drawing.Point(568, 109);
            this.alBet.Name = "alBet";
            this.alBet.Size = new System.Drawing.Size(164, 23);
            this.alBet.TabIndex = 7;
            this.alBet.Text = "Al\'s Bet";
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(568, 149);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(164, 46);
            this.raceButton.TabIndex = 8;
            this.raceButton.Text = "Race";
            this.raceButton.UseVisualStyleBackColor = true;
            // 
            // nameBet
            // 
            this.nameBet.AutoSize = true;
            this.nameBet.Location = new System.Drawing.Point(6, 164);
            this.nameBet.Name = "nameBet";
            this.nameBet.Size = new System.Drawing.Size(31, 17);
            this.nameBet.TabIndex = 9;
            this.nameBet.Text = "Joe";
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(44, 161);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 23);
            this.betButton.TabIndex = 10;
            this.betButton.Text = "Bet";
            this.betButton.UseVisualStyleBackColor = true;
            // 
            // betAmount
            // 
            this.betAmount.Location = new System.Drawing.Point(125, 162);
            this.betAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.betAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(77, 22);
            this.betAmount.TabIndex = 11;
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // bucksOnDog
            // 
            this.bucksOnDog.AutoSize = true;
            this.bucksOnDog.Location = new System.Drawing.Point(208, 164);
            this.bucksOnDog.Name = "bucksOnDog";
            this.bucksOnDog.Size = new System.Drawing.Size(145, 17);
            this.bucksOnDog.TabIndex = 12;
            this.bucksOnDog.Text = "bucks on dog number";
            // 
            // dogNumber
            // 
            this.dogNumber.Location = new System.Drawing.Point(360, 164);
            this.dogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumber.Name = "dogNumber";
            this.dogNumber.Size = new System.Drawing.Size(120, 22);
            this.dogNumber.TabIndex = 13;
            this.dogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.betterParlor);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.raceTrack);
            this.Name = "Form1";
            this.Text = "A day at the races";
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            this.betterParlor.ResumeLayout(false);
            this.betterParlor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox raceTrack;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.GroupBox betterParlor;
        private System.Windows.Forms.Label betsLabel;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.RadioButton alBetButton;
        private System.Windows.Forms.RadioButton bobBetButton;
        private System.Windows.Forms.RadioButton joeBetButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label alBet;
        private System.Windows.Forms.Label bobBet;
        private System.Windows.Forms.Label joeBet;
        private System.Windows.Forms.NumericUpDown dogNumber;
        private System.Windows.Forms.Label bucksOnDog;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label nameBet;
        private System.Windows.Forms.Button raceButton;
    }
}


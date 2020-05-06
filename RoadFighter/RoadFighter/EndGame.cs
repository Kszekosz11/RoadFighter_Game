using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadFighter
{
    public partial class FrmEndGame : Form
    {
        public FrmMenu MenuUI { get; }
        public FrmGame ActualGame { get; }
        private int Score { get; set; }
        private int Crash { get; set; }

        public FrmEndGame(FrmGame game, FrmMenu menuUI, string description, int score, int crash)
        {
            InitializeComponent();
            FormSettings.SetSetting(this);            
            ActualGame = game;
            MenuUI = menuUI;
            Score = score;
            Crash = crash;
            lblDescription.Text = description;
            lblScore.Text = "SCORE: " + score.ToString();
        }

        public FrmEndGame(FrmGame game, FrmMenu menuUI, string description, int score, int crash, string message)
        {
            InitializeComponent();
            FormSettings.SetSetting(this);
            ActualGame = game;
            MenuUI = menuUI;
            Score = score;
            Crash = crash;
            lblDescription.Text = description;
            lblScore.Text = message;
            btnConfirm.Enabled = false;
            txbYourName.Enabled = false;
        }

        private void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            this.Close();
            ActualGame.Close();
            FrmGame newGame = new FrmGame(MenuUI);
            newGame.Show();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            ActualGame.Close();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            ActualGame.Close();
            MenuUI.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ActualGame.Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            using (var context = new RoadFighterDataEnt())
            {                
                var score = new GameRecords
                {
                    Name = txbYourName.Text,
                    Score = (short)Score,
                    Crash = (short)Crash
                };
                context.GameRecords.Add(score);
                context.SaveChanges();
            }

            MessageBox.Show("Zapisano wynik!", "Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnConfirm.Enabled = false;
            txbYourName.Enabled = false;
        }
    }
}
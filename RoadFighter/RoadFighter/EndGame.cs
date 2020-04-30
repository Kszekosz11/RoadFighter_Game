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

        public FrmEndGame(FrmGame game, FrmMenu menuUI, string description)
        {
            InitializeComponent();
            FormSettings.SetSetting(this);            
            ActualGame = game;
            MenuUI = menuUI;
            lblDescription.Text = description;
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
    }
}
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
    public partial class frmEndGame : Form
    {
        public frmMenuForm MenuUI { get; }
        public frmGame ActualGame { get; }    

        public frmEndGame(frmGame game, frmMenuForm menuUI)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            ActualGame = game;
            MenuUI = menuUI;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.Close();
            ActualGame.Close();
            frmGame newGame = new frmGame(MenuUI);
            newGame.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            ActualGame.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            ActualGame.Close();
            MenuUI.Close();
        }
    }
}

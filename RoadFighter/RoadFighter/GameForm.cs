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
    public partial class frmGame : Form
    {
        public frmMenuForm MenuUI { get; }
        public GameEngine Game { get; set; }  

        public frmGame(frmMenuForm menuUI)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            tmrSceneTimer.Enabled = false;
            tmrGameTimer.Enabled = false;
            tmrFinishGame.Enabled = false;
            MenuUI = menuUI;                        
            Game = new GameEngine(this, MenuUI);           
        }

        private void sceneTimer_Tick(object sender, EventArgs e)
        {
            Game.drawLines(Game.SpeedGame);
            Game.drawTrees(Game.SpeedGame);
            Game.enemyCarControl(Game.SpeedGame);
            Game.gameOver(MenuUI);
            Game.coinCollected();
            Game.coinControl(Game.SpeedGame);

            Game.distanceToFinish();

            Game.showFinishLine();
            
        }

        private void keysHandling(object sender, KeyEventArgs e)
        {
            Game.carControl(e);
        }

        private void tmrGameTimer_Tick(object sender, EventArgs e)
        {
            Game.gameTime();
            
            Game.routeDistanceMiniCar(Game.SpeedGame);
        }

        private void tmrFinishGame_Tick(object sender, EventArgs e)
        {
            Game.finishGame(Game.SpeedGame);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MenuUI.Show();
        }   
    }
}

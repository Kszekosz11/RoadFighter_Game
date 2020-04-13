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
        //GameEngine game = new GameEngine();

        public Form MenuUI { get; }                

        public frmGame(frmMenuUI menuUI)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            MenuUI = menuUI;            
            
            tmrSceneTimer.Enabled = false;

            game.sceneTimer = tmrSceneTimer;

            game.grassPanel = grass;
            game.car = car;

            for (int i = 0; i < game.leftLines.Length; i++)
            {
                game.leftLines[i] = this.Controls.OfType<PictureBox>().Single(x => x.Tag == this.Tag);
            }

            //for (int i = 0; i < game.rightLines.Length; i++)
            //{
            //    game.rightLines[i] = this.Controls.OfType<PictureBox>().First(x => x.Tag == this.road.Tag);
            //}

            //game.leftLines[0] = line1;
            //game.leftLines[1] = line2;
            //game.leftLines[2] = line3;
            //game.leftLines[3] = line4;
            //game.leftLines[4] = line5;

            game.rightLines[0] = line6;
            game.rightLines[1] = line7;
            game.rightLines[2] = line8;
            game.rightLines[3] = line9;
            game.rightLines[4] = line10;

            game.enemy = pcbEnemy1;
            game.helper = lblHelper;
            game.coin = pcbCoin;
            game.points = lblPoints;
            game.time = lblGameTime;

            tmrGameTimer.Enabled = false;
            game.gameTimer = tmrGameTimer;

            game.finishLine = pcbFinish;

        }

        
        GameEngine game = new GameEngine();

        private void sceneTimer_Tick(object sender, EventArgs e)
        {
            game.drawLines(game.speed);
            game.drawTrees(game.speed);
            game.enemyControl(game.speed);
            game.gameOver(MenuUI);
            game.coinCollected();
            game.coinControl(game.speed);
            game.finishGame();
        }

        private void keysHandling(object sender, KeyEventArgs e)
        {
            game.carControl(e);
        }

        private void tmrGameTimer_Tick(object sender, EventArgs e)
        {
            game.gameTime();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MenuUI.Show();
        }
    }
}

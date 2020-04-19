﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadFighter
{
    public class GameEngine
    {
        public FrmGame FormGame { get; set; }
        public FrmMenu MenuForm { get; set; }
        public GreenBox Grass { get; set; }
        public RoadBox Road { get; set; }
        public Timer SceneTimer { get; set; }
        public Timer GameTimer { get; set; }
        public Timer FinishGame { get; set; }
        public int SpeedGame { get; set; }
        public int SpeedMax { get; set; }
        public int SpeedMin { get; set; }

        public GameEngine(FrmGame gameForm, FrmMenu menuForm)
        {
            FormGame = gameForm;
            MenuForm = menuForm;
            Grass = new GreenBox(FormGame);
            Road = new RoadBox(FormGame, this);
            SceneTimer = gameForm.tmrSceneTimer;
            GameTimer = gameForm.tmrGameTimer;
            FinishGame = gameForm.tmrFinishGame;            
            SpeedGame = 5;
            SpeedMax = 10;
            SpeedMin = 1;
        }

        public void GameTime()
        {
            if (Road.Ticks > 0)
            {
                Road.Ticks--;
                Road.Time.Text = "Time: " + Road.Ticks.ToString();
            }
            else
            {
                Road.Ticks = 0;
                Road.Time.Text = "Time: " + Road.Ticks.ToString();
                SceneTimer.Enabled = false;
                GameTimer.Enabled = false;

                frmEndGame endGame = new frmEndGame(FormGame, MenuForm, "TIMEOUT");
                FormGame.Enabled = false;
                endGame.Show();
            }
        }

        public void DistanceToFinish()
        {
            if (Road.RouteDistance > 0)
            {
                Road.RouteDistance -= ((double)SpeedGame / 500);
                Road.Distance.Text = string.Format("{0:F2}{1}", Road.RouteDistance, " km");
            }
            else Road.Distance.Text = "0 km";
        }

        public void ShowFinishLine()
        {
            if (Road.RouteDistance <= 0)
            {
                Road.FinishLine.Visible = true;
            }

            if ((Road.Auto.Bounds.IntersectsWith(Road.FinishLine.Bounds)) && (Road.FinishLine.Visible == true))
            {
                SceneTimer.Stop();
                GameTimer.Stop();
                FinishGame.Enabled = true;

                frmEndGame endGame = new frmEndGame(FormGame, MenuForm, "YOU WON");
                FormGame.Enabled = false;
                endGame.Show();
            }
        }

        public void IfYouWin(int speed)
        {
            Road.Auto.Top -= (int)speed * 2;
        }

        public void GameOver()
        {
            if (Road.Auto.Bounds.IntersectsWith(Road.EnemyAuto.Bounds))
            {
                SceneTimer.Enabled = false;
                GameTimer.Enabled = false;

                SpeedGame = 0;
                Road.EnemyAuto.Location = Road.RandomLocation((int)LocationY.enemyCar);                
                Road.Auto.Location = new Point(165, 543);

                Road.Ticks -= 5;
                SpeedGame = 1;
            }
        }
    }
}
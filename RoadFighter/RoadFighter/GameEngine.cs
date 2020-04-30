using System;
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

                FrmEndGame endGame = new FrmEndGame(FormGame, MenuForm, "TIMEOUT");
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
                SpeedGame = 0;
                Road.Auto.Top -= ((int)StaticValues.carStep / 2);
            }

            if ((Road.Auto.Bounds.IntersectsWith(Road.FinishLine.Bounds)) && (Road.FinishLine.Visible == true))
            {
                SceneTimer.Stop();
                GameTimer.Stop();
                FinishGame.Start();
            }
        }

        public void IfYouWin()
        {
            if (Road.Auto.Location.Y > Road.Road.Location.Y - Road.Auto.Height)
            {
                Road.Auto.Top -= (int)StaticValues.carStep;
            }
            else
            {
                FinishGame.Stop();
                FrmEndGame endGame = new FrmEndGame(FormGame, MenuForm, "WINNER");
                FormGame.Enabled = false;
                endGame.Show();
            }
        }

        public void PauseGame()
        {
            if (SceneTimer.Enabled == true)
            {
                SceneTimer.Stop();
                GameTimer.Stop();
                FormGame.lblPause.Enabled = true;
                FormGame.Visible = true;
            }
            else
            {
                SceneTimer.Start();
                GameTimer.Start();
                FormGame.lblPause.Enabled = false;
                FormGame.lblPause.Visible = false;
            }
        }

        public void GameOver()
        {
            if (Road.Auto.Bounds.IntersectsWith(Road.EnemyAuto.Bounds))
            {
                SceneTimer.Enabled = false;
                GameTimer.Enabled = false;

                SpeedGame = 0;
                Road.EnemyAuto.Location = Road.RandomLocation((int)StaticValues.enemyCarPosition);                
                Road.Auto.Location = new Point(165, 543);

                Road.Ticks -= 5;
                SpeedGame = 1;
            }
        }
    }
}
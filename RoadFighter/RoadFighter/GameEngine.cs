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
        public double SpeedGame { get; set; }
        public double SpeedMax { get; set; }
        public double SpeedMin { get; set; }
        public int Crash { get; set; }

        public GameEngine(FrmGame gameForm, FrmMenu menuForm)
        {
            FormGame = gameForm;
            MenuForm = menuForm;
            Road = new RoadBox(FormGame, this);
            Grass = new GreenBox(FormGame, Road.random);
            SceneTimer = gameForm.tmrSceneTimer;
            GameTimer = gameForm.tmrGameTimer;
            FinishGame = gameForm.tmrFinishGame;            
            SpeedGame = 5;
            SpeedMax = 10;
            SpeedMin = 1;
            Crash = 0;
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

                FrmEndGame endGame = new FrmEndGame(FormGame, MenuForm, "TIMEOUT", Road.PointQuantity, Crash, "Try Again");
                FormGame.Enabled = false;
                endGame.Show();
            }
        }

        public void DistanceToFinish()
        {
            if (Road.RouteDistance > 0)
            {
                if (SpeedGame < 1) Road.Distance.Text = string.Format("{0:F2}{1}", Road.RouteDistance, " km");
                else
                {
                    Road.RouteDistance -= ((double)SpeedGame / 500);
                    Road.Distance.Text = string.Format("{0:F2}{1}", Road.RouteDistance, " km");
                }                             
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
                FrmEndGame endGame = new FrmEndGame(FormGame, MenuForm, "WINNER", Road.PointQuantity, Crash);
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
                Road.Pause.Enabled = true;
                Road.Pause.Visible = true;
            }
            else
            {
                SceneTimer.Start();
                GameTimer.Start();
                Road.Pause.Enabled = false;
                Road.Pause.Visible = false;
            }
        }

        public void GameOver()
        {
            for (int i = 0; i < Road.EnemyCars.Length; i++)
            {
                if (Road.Auto.Bounds.IntersectsWith(Road.EnemyCars[i].Bounds))
                {
                    SceneTimer.Enabled = false;
                    GameTimer.Enabled = false;
                    Crash++;

                    SpeedGame = 0;
                    for (int j = 0; j < Road.EnemyCars.Length; j++)
                    {
                        Road.EnemyCars[j].Location = Road.RandomLocation(Road.random.Next(-1000, -250));
                    }                    
                    Road.Auto.Location = new Point(165, 543);
                    Road.CoinControl.Location = Road.RandomLocation((int)StaticValues.coinPosition);
                    Road.ClockElement.Location = Road.RandomLocation((int)StaticValues.clockPosition);

                    Road.Ticks -= 5;
                    SpeedGame = 1;
                }
            }
            
        }
    }
}
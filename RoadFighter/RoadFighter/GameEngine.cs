using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadFighter
{
    public class GameEngine
    {
        public frmGame Game { get; set; }
        public frmMenuForm MenuUI { get; set; }

        public PictureBox Car { get; set; }
        public PictureBox MiniCar { get; set; }
        public PictureBox Coin { get; set; }
        public PictureBox EnemyCar { get; set; }
        public PictureBox FinishLine { get; set; }
        public PictureBox MiniFinishLine { get; set; }
        public Panel LeftLines { get; set; }
        public Panel RightLines { get; set; }
        public Panel Grass { get; set; }
        public Panel Road { get; set; }
        public Label Points { get; set; }
        public Label Time { get; set; }
        public Label Distance { get; set; }
        public Timer SceneTimer { get; set; }
        public Timer GameTimer { get; set; }
        public Timer FinishGame { get; set; }
        private int PointQuantity { get; set; }
        public int Ticks { get; set; }
        private int DistanceOfPanel { get; set; }
        public double SpeedGame { get; set; }
        public double RouteDistance { get; set; }

        Random random = new Random();

        private double speedMax = 10.0;
        private double speedMin = 0.0;

        public GameEngine(frmGame game, frmMenuForm menuUI)
        {
            Game = game;
            MenuUI = menuUI;

            Car = game.pcbCar;
            MiniCar = game.pcbMiniCar;
            EnemyCar = game.pcbEnemyCar;            
            Coin = game.pcbCoin;
            LeftLines = game.pnlLeftLines;
            RightLines = game.pnlRightLines;
            Grass = game.pnlGrass;
            Road = game.pnlRoad;
            Points = game.lblPoints;
            Time = game.lblTime;
            Distance = game.lblDistance;
            FinishLine = game.pcbFinishLine;
            SceneTimer = game.tmrSceneTimer;
            GameTimer = game.tmrGameTimer;
            FinishGame = game.tmrFinishGame;
            MiniFinishLine = game.pcbMiniFinishLine;

            PointQuantity = 0;            
            Ticks = 30;
            DistanceOfPanel = 10;
            SpeedGame = 5;
            RouteDistance = 60;

            Points.Text = "Points: " + PointQuantity.ToString();
            Time.Text = "Time: " + Ticks.ToString();
            Distance.Text = RouteDistance.ToString() + " km";

            Coin.Location = randomLocation();
            EnemyCar.Location = randomLocation();
        }

        public void drawTrees(double speed)
        {
            if (Grass.Top >= Game.Height * 2)
            {
                Grass.Top = -(Game.Height * 2);
            }
            else Grass.Top += (int)speed;
        }

        public void drawLines(double speed)
        {
            if ((LeftLines.Top >= 138) && (RightLines.Top >= 138))
            {
                LeftLines.Top = 0;
                RightLines.Top = 0;
            }
            else 
            {
                LeftLines.Top += (int)speed;
                RightLines.Top += (int)speed;
            }
        }

        public void gameTime()
        {
            if (Ticks > 0)
            {
                Ticks--;
                Time.Text = "Time: " + Ticks.ToString();
            }
            else
            { 
                Ticks = 0;
                Time.Text = "Time: " + Ticks.ToString();
                SceneTimer.Enabled = false;
                GameTimer.Enabled = false;

                frmEndGame endGame = new frmEndGame(Game, MenuUI, "TIMEOUT");
                Game.Enabled = false;
                endGame.Show();
            }
        }

        public void distanceToFinish()
        {
            if (RouteDistance > 0)
            {
                RouteDistance -= (SpeedGame / 500);
                Distance.Text = ((int)RouteDistance).ToString() + " km";
            }
            else Distance.Text = "0";             
        }

        public void showFinishLine()
        {
            if (RouteDistance <= 0)
            {
                FinishLine.Visible = true;
            }

            if (Car.Bounds.IntersectsWith(FinishLine.Bounds))
            {
                SceneTimer.Stop();
                GameTimer.Stop();
                FinishGame.Enabled = true;

                frmEndGame endGame = new frmEndGame(Game, MenuUI, "YOU WON");
                Game.Enabled = false;
                endGame.Show();
            }
        }

        public void finishGame(double speed)
        {            
            Car.Top -= (int)speed * 2;
        }

        public void enemyCarControl(double speed)
        {
            if (EnemyCar.Top > Road.Height)
            {
                EnemyCar.Location = randomLocation();
            }
            else EnemyCar.Top += 5;
        }

        public void coinControl(double speed)
        {
            if (Coin.Top > Road.Height)
            {
                Coin.Location = randomLocation();
                if (Coin.Bounds.IntersectsWith(EnemyCar.Bounds))
                {
                    Coin.Location = randomLocation();
                }
                Coin.Visible = true;
            }
            else Coin.Top += 5;
        }

        public void coinCollected()
        {
            if (Car.Bounds.IntersectsWith(Coin.Bounds))
            {
                Points.Visible = true;
                PointQuantity++;
                Ticks += 5;
                Points.Text = "Points: " + PointQuantity.ToString();
                Coin.Visible = false;

                Coin.Location = randomLocation();
            }
        }

        private Point randomLocation()
        {
            return new Point(random.Next(EnemyCar.Width, Road.Width - EnemyCar.Width), -200);
        }

        public void gameOver(Form menuUI)
        {
            if (Car.Bounds.IntersectsWith(EnemyCar.Bounds))
            {
                //Car.Image = Properties.Resources.explosion;
                SceneTimer.Enabled = false;
                GameTimer.Enabled = false;

                SpeedGame = 0;
                EnemyCar.Location = randomLocation();
                Car.Location = new Point(165, 543);

                Ticks -= 10;
                GameTimer.Enabled = true;

                //frmEndGame endGame = new frmEndGame(Game, MenuUI);
                //Game.Enabled = false;
                
                //endGame.Show();
            }
        }

        public void routeDistanceMiniCar(double speed)
        {
            if (MiniCar.Bounds.IntersectsWith(MiniFinishLine.Bounds))
            {
                RouteDistance = 0;
            }
            MiniCar.Top -= (int)(RouteDistance / speed);
        }

        public void carControl(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (Car.Left > DistanceOfPanel) Car.Left -= 10;
                    break;
                case Keys.Right:
                    if (Car.Right < Road.Width - DistanceOfPanel) Car.Left += 10;
                    break;
                case Keys.Up:
                    SceneTimer.Enabled = true;
                    if (GameTimer.Enabled == false)
                    {
                        GameTimer.Start();
                    }
                    if (Car.Top > FinishLine.Top)
                    {
                        if (SpeedGame <= speedMax)
                        {
                            SpeedGame += 0.5;
                            if (FinishLine.Visible == true)
                            {
                                Car.Top -= 10;
                            }                            
                        }
                        Car.Top -= 5;
                    }
                    break;
                case Keys.Down:
                    if (Car.Top < Road.Height - Car.Height - DistanceOfPanel)
                    {
                        if (SpeedGame >= speedMin)
                        {
                            SpeedGame -= 0.1;
                            Car.Top += 5;                            
                        }
                    }
                    break;
                case Keys.Space:
                    if (SceneTimer.Enabled == true)
                    {
                        SceneTimer.Stop();
                        GameTimer.Stop();
                    }
                    else
                    {
                        SceneTimer.Start();
                        GameTimer.Start();
                        Car.Enabled = true;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}

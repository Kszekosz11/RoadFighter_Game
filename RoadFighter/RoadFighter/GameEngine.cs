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
        public PictureBox Car { get; set; }
        public PictureBox Coin { get; set; }
        public PictureBox EnemyCar { get; set; }
        public PictureBox FinishLine { get; set; }
        public Panel LeftLines { get; set; }
        public Panel RightLines { get; set; }
        public Panel Grass { get; set; }
        public Panel Road { get; set; }
        public Label Points { get; set; }
        public Label Time { get; set; }
        public Timer SceneTimer { get; set; }
        public Timer GameTimer { get; set; }
        public Timer FinishGame { get; set; }
        private int PointQuantity { get; set; }
        private int Ticks { get; set; }
        private int Distance { get; set; }


        Random random = new Random();

        public double speed = 5.0;
        private double speedMax = 10.0;
        private double speedMin = 1.0;

        public GameEngine(frmGame game)
        {
            Car = game.pcbCar;            
            EnemyCar = game.pcbEnemyCar;            
            Coin = game.pcbCoin;
            LeftLines = game.pnlLeftLines;
            RightLines = game.pnlRightLines;
            Grass = game.pnlGrass;
            Road = game.pnlRoad;
            Points = game.lblPoints;
            Time = game.lblTime;
            FinishLine = game.pcbFinishLine;
            SceneTimer = game.tmrSceneTimer;
            GameTimer = game.tmrGameTimer;
            FinishGame = game.tmrFinishGame;
            PointQuantity = 0;
            Ticks = 0;
            Distance = 10;

            EnemyCar.Location = randomLocation();
        }

        public void drawTrees(double speed)
        {
            if (Grass.Top >= 1500)
            {
                Grass.Top = -1500;
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
            Time.Visible = true;
            Ticks++;
            Time.Text = "Time: " + Ticks.ToString();
        }

        public void showFinishLine()
        {
            if (Ticks > 10)
            {
                FinishLine.Visible = true;
                if (Car.Bounds.IntersectsWith(FinishLine.Bounds))
                {
                    SceneTimer.Stop();
                    GameTimer.Stop();
                    FinishGame.Enabled = true;
                }
            }
        }

        public void finishGame(double speed)
        {            
            Car.Top -= (int)speed;
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
                Car.Image = Properties.Resources.explosion;
                SceneTimer.Enabled = false;
            }
            
            //
            //  OPRACOWAĆ KONIEC GRY
            //  OKNO ZAMYKAJĄCE GRE, RESTARTUJĄCE LUB WRACAJĄCE GO MENU GŁOWNEGO
            //
        }

        public void carControl(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (Car.Left > Distance) Car.Left -= 10;
                    break;
                case Keys.Right:
                    if (Car.Right < Road.Width - Distance) Car.Left += 10;
                    break;
                case Keys.Up:
                    SceneTimer.Enabled = true;
                    if (GameTimer.Enabled == false)
                    {
                        GameTimer.Start();
                    }
                    if (Car.Top > FinishLine.Top)
                    {
                        if (speed <= speedMax)
                        {
                            speed += 0.5;
                        }
                        Car.Top -= 5;
                    }
                    break;
                case Keys.Down:
                    if (Car.Top < Road.Height - Car.Height - Distance)
                    {
                        if (speed >= speedMin)
                        {
                            speed -= 0.1;
                            Car.Top += 5;
                        }
                    }
                    break;
                case Keys.Space:
                    if (SceneTimer.Enabled == true)
                    {
                        SceneTimer.Stop();
                    }
                    else
                    {
                        SceneTimer.Start();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}

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
        public frmGame Game { get; set; }
        public frmMenuForm MenuUI { get; set; }

        public PictureBox Car { get; set; }
        public PictureBox MiniCar { get; set; }
        public PictureBox Coin { get; set; }
        public PictureBox Clock { get; set; }
        public PictureBox EnemyCar { get; set; }
        public PictureBox FinishLine { get; set; }
        public PictureBox MiniFinishLine { get; set; }

        //public PictureBox Church { get; set; }
        //public PictureBox Houses { get; set; }
        //public PictureBox Flats { get; set; }

        public PictureBox[] SceneElements { get; set; }


        public PictureBox Line { get; set; }
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
        public int SpeedGame { get; set; }
        public double RouteDistance { get; set; }

        Random random = new Random();

        private int speedMax = 10;
        private int speedMin = 1;

        private int step = 10;

        int distanceBetweenLines = 50;


        public GameEngine(frmGame game, frmMenuForm menuUI)
        {
            Game = game;
            MenuUI = menuUI;

            Car = game.pcbCar;
            MiniCar = game.pcbMiniCar;
            EnemyCar = game.pcbEnemyCar;
            Coin = game.pcbCoin;
            Clock = game.pcbClock;
            LeftLines = game.pnlLeftLines;
            RightLines = game.pnlRightLines;
            Grass = game.pnlGrass;

            Line = game.pcbLine1;

            SceneElements = new PictureBox[Grass.Controls.Count];

            SceneElements[0] = game.pcbChurch;
            SceneElements[1] = game.pcbHouses;
            SceneElements[2] = game.pcbFlats;

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
            Distance.Text = string.Format("{0:F1}", RouteDistance + " km");

            Coin.Location = randomLocation((int)LocationY.coin);
            EnemyCar.Location = randomLocation((int)LocationY.enemyCar);
            Clock.Location = randomLocation((int)LocationY.clock);

            regionElements(Coin);
            regionElements(Clock);
        }

        private void regionElements(Control element)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, element.Width, element.Height);
            Region rg = new Region(gp);
            element.Region = rg;
        }

        public void drawScene(int speed)
        {
            for (int i = 0; i < SceneElements.Length; i++)
            {
                if (SceneElements[i].Top >= Game.Height) SceneElements[i].Top = -SceneElements[0].Height;
                else SceneElements[i].Top += (int)speed;
            }
        }

        public void drawLines(int speed)
        {
            if (LeftLines.Top >= Line.Height + distanceBetweenLines)
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
                RouteDistance -= ((double)SpeedGame / 500);
                Distance.Text = string.Format("{0:F2}{1}", RouteDistance, " km");
            }
            else Distance.Text = "0 km";
        }

        public void showFinishLine()
        {
            if (RouteDistance <= 0)
            {
                FinishLine.Visible = true;
            }

            if ((Car.Bounds.IntersectsWith(FinishLine.Bounds)) && (FinishLine.Visible == true))
            {
                SceneTimer.Stop();
                GameTimer.Stop();
                FinishGame.Enabled = true;

                frmEndGame endGame = new frmEndGame(Game, MenuUI, "YOU WON");
                Game.Enabled = false;
                endGame.Show();
            }
        }

        public void IfYouWin(int speed)
        {
            Car.Top -= (int)speed * 2;
        }

        public void enemyCarControl(int speed)
        {
            if (RouteDistance >= 0)
            {
                if (EnemyCar.Top > Road.Height)
                {
                    EnemyCar.Location = randomLocation(-250);
                }
                else EnemyCar.Top += 5;
            }
            else
            {
                EnemyCar.Enabled = false;
                EnemyCar.Location = randomLocation(Game.Height + EnemyCar.Height);
            }

        }

        public void coinControl(int speed)
        {
            if (Coin.Top > Road.Height)
            {
                Coin.Enabled = true;
                Coin.Location = randomLocation((int)LocationY.coin);

                if ((Coin.Location.Y == EnemyCar.Height) || (Coin.Location.X == EnemyCar.Width) || (Coin.Bounds.IntersectsWith(EnemyCar.Bounds)))
                {
                    Coin.Location = randomLocation((int)LocationY.coin);
                }
            }
            else Coin.Top += 5;


        }

        public void coinCollected()
        {
            if (Car.Bounds.IntersectsWith(Coin.Bounds))
            {
                PointQuantity++;
                Points.Text = "Points: " + PointQuantity.ToString();
                Coin.Enabled = false;

                Coin.Location = randomLocation((int)LocationY.coin);
            }
        }

        public void clockControl(int speed)
        {
            if (Clock.Top > Road.Height)
            {
                Clock.Enabled = true;
                Clock.Location = randomLocation((int)LocationY.clock);

                if ((Clock.Location.Y == EnemyCar.Height) || (Clock.Location.X == EnemyCar.Width) || (Clock.Bounds.IntersectsWith(EnemyCar.Bounds)))
                {
                    Clock.Location = randomLocation((int)LocationY.clock);
                }
            }
            else Clock.Top += 5;
        }

        public void clockCollected()
        {
            if (Car.Bounds.IntersectsWith(Clock.Bounds))
            {
                Ticks += 10;
                Clock.Enabled = false;

                Clock.Location = randomLocation((int)LocationY.clock);
            }
        }

        public void gameOver(Form menuUI)
        {
            if (Car.Bounds.IntersectsWith(EnemyCar.Bounds))
            {
                //Car.Visible = false;
                //Car.Image = Properties.Resources.boom;

                //PictureBox explosion = new PictureBox();
                //explosion.Location = Car.Location;
                //explosion.Enabled = true;
                //explosion.Visible = true;
                //explosion.BackgroundImage = Properties.Resources.boom;

                SceneTimer.Enabled = false;
                GameTimer.Enabled = false;

                SpeedGame = 0;
                EnemyCar.Location = randomLocation(-250);
                //Car.Visible = true;
                Car.Location = new Point(165, 543);

                Ticks -= 5;
                SpeedGame = 1;
            }
        }

        private Point randomLocation(int distance)
        {
            return new Point(random.Next(EnemyCar.Width, Road.Width - EnemyCar.Width), distance);
        }

        public void routeDistanceMiniCar(int speed)
        {
            if (MiniCar.Bounds.IntersectsWith(MiniFinishLine.Bounds))
            {
                MiniCar.Top -= 0;
            }
            else MiniCar.Location = new Point(23, (int)RouteDistance * 10);

            // FINISHLINE LOCATION Y = 50 HEIGHT 10
            // MINICAR LOCATION Y = 660
            // 660 - 60 = 600
        }

        public void carControl(KeyEventArgs e)
        {
            //    if ((Keyboard.IsKeyDown(Key.Left)) && (Keyboard.IsKeyDown(Key.Up)))
            //    {
            //        if (Car.Left > DistanceOfPanel) Car.Left -= step;

            //        if (SceneTimer.Enabled == false)
            //        {
            //            GameTimer.Enabled = true;
            //            SceneTimer.Enabled = true;
            //        }
            //        else if (Car.Top > FinishLine.Top)
            //        {
            //            if (SpeedGame <= speedMax)
            //            {
            //                SpeedGame += 1;
            //                if (FinishLine.Visible == true)
            //                {
            //                    Car.Top -= step;
            //                }
            //            }
            //            Car.Top -= 5;
            //        }
            //    }
            //}

            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (Car.Left > DistanceOfPanel) Car.Left -= step;
                    break;
                case Keys.Right:
                    if (Car.Right < Road.Width - DistanceOfPanel) Car.Left += step;
                    break;
                case Keys.Up:
                    if (SceneTimer.Enabled == false)
                    {
                        GameTimer.Enabled = true;
                        SceneTimer.Enabled = true;
                    }
                    else if (Car.Top > FinishLine.Top)
                    {
                        if (SpeedGame <= speedMax)
                        {
                            SpeedGame += 1;
                            if (FinishLine.Visible == true)
                            {
                                Car.Top -= step;
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
                            SpeedGame -= 1;
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
                    }
                    break;
                default:
                    break;
            }
        }
    }
}

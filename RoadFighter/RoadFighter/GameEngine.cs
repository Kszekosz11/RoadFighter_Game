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
        private static int treesQuantity = 4;
        public PictureBox[] trees = new PictureBox[treesQuantity];

        private static int linesQuantity = 5;
        public PictureBox[] leftLines = new PictureBox[linesQuantity];
        public PictureBox[] rightLines = new PictureBox[linesQuantity];

        public Panel grassPanel;
        public Panel roadPanel;
        public PictureBox car;

        public Timer sceneTimer;
        public PictureBox enemy;

        public PictureBox coin;

        public Label helper;
        public Label points;
        private int pointsQuantity = 0;

        public Label time;
        public Timer gameTimer;
        private int ticks;

        public PictureBox finishLine;

        Random random = new Random();

        public double speed = 5.0;
        private double speedMax = 10.0;
        private double speedMin = 1.0;
        
        public void drawTrees(double speed)
        {
            if (grassPanel.Top >= 1500)
            {
                grassPanel.Top = -1500;
            }
            else grassPanel.Top += (int)speed;


            //for (int i = 0; i < treesQuantity; i++)
            //{
            //    if (trees[i].Top >= 2000)
            //    {
            //        trees[i].Top = 0;
            //    }
            //    else trees[i].Top += speed;
            //}
        }


        public void drawLines(double speed)
        {
            //if (roadPanel.Top > roadPanel.Height)
            //{
            //    roadPanel.Top = 0;
            //}
            //else roadPanel.Top += speed;


            for (int i = 0; i < linesQuantity; i++)
            {
                if (leftLines[i].Top >= 680)
                {
                    leftLines[i].Top = 0;
                }
                else leftLines[i].Top += (int)speed;
            }

            for (int i = 0; i < linesQuantity; i++)
            {
                if (rightLines[i].Top >= 680)
                {
                    rightLines[i].Top = 0;
                }
                else rightLines[i].Top += (int)speed;
            }
        }

        public void gameTime()
        {
            time.Visible = true;
            ticks++;
            time.Text = "Time: " + ticks.ToString();
            
        }

        public void finishGame()
        {
            if (ticks > 2)
            {
                finishLine.Visible = true;
                if (car.Bounds.IntersectsWith(finishLine.Bounds))
                {
                    helper.Text = "WIN";
                    sceneTimer.Stop();
                }
            }

        }

        public void enemyControl(double speed)
        {
            if (enemy.Top > 680)
            {
                enemy.Location = new Point(random.Next(50,300),0);
            }
            else enemy.Top += 5;
        }

        public void coinControl(double speed)
        {
            if (coin.Top > 680)
            {
                coin.Location = new Point(random.Next(80, 600), 0);
                coin.Visible = true;
            }
            else coin.Top += 5;
        }

        public void coinCollected()
        {
            if (car.Bounds.IntersectsWith(coin.Bounds))
            {
                points.Visible = true;
                pointsQuantity++;
                points.Text = "Points: " + pointsQuantity.ToString();
                coin.Visible = false;

                coin.Location = new Point(random.Next(0), 700);
            }
        }

        public void gameOver()
        {
            if (car.Bounds.IntersectsWith(enemy.Bounds))
            {
                car.Image = Properties.Resources.explosion;
                sceneTimer.Enabled = false;
                helper.Text = "GAME OVER";
                helper.Visible = true;
            }
        }

        public void carControl(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (car.Left > 4) car.Left -= 10;
                    break;
                case Keys.Right:
                    if (car.Right < 392) car.Left += 10;
                    break;
                case Keys.Up:
                    sceneTimer.Enabled = true;
                    if (gameTimer.Enabled == false)
                    {
                        gameTimer.Start();
                    }                    
                    if (car.Top > 50)
                    {
                        if (speed <= speedMax)
                        {
                            speed += 0.5;
                        }
                        car.Top -= 5;
                    }
                    break;
                case Keys.Down:
                    if (car.Top < 554)
                    {
                        if (speed >= speedMin)
                        {
                            speed -= 0.1;
                            car.Top += 5;
                        }
                    }
                    break;
                case Keys.Space:
                    if (sceneTimer.Enabled == true)
                    {
                        sceneTimer.Stop();
                        helper.Text = "PAUSE";
                        helper.Visible = true;
                    }
                    else
                    {
                        helper.Visible = false;
                        sceneTimer.Start();
                    }
                    
                
                    break;
                default:
                    break;
            }
        }
    }
}

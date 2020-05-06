using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadFighter
{
    public class EnemyCarBox
    {
        private FrmGame GameForm { get; set; }
        private GameEngine GameEngine { get; set; }
        private RoadBox Road { get; set; }
        public PictureBox[] Enemies { get; set; }
        public int[] movement;

        public EnemyCarBox(FrmGame gameForm, GameEngine gameEngine, RoadBox road, PictureBox[] enemies)
        {
            GameForm = gameForm;
            GameEngine = gameEngine;
            Road = road;
            Enemies = enemies;
            movement = new int[Enemies.Length];
            for (int i = 0; i < road.EnemyCars.Length; i++)
            {
                Enemies[i].Location = road.RandomLocation(Road.random.Next((int)StaticValues.enemyMinLocationY, (int)StaticValues.enemyMaxLocationY));
                movement[i] = Road.random.Next((int)StaticValues.movementLeft, (int)StaticValues.movementRight);
            }
        }        

        public void EnemyCarControl(double speed)
        {
            if (Road.RouteDistance >= 0)
            {
                for (int i = 0; i < Enemies.Length; i++)
                {
                    if (Enemies[i].Top > Road.Road.Height)
                    {
                        Enemies[i].Location = Road.RandomLocation(Road.random.Next((int)StaticValues.enemyMinLocationY, (int)StaticValues.enemyMaxLocationY));
                    }
                    else
                    {
                        Enemies[i].Top += (int)speed / 2;
                        if (Enemies[i].Left > (int)StaticValues.distanceCarOfPanel && Enemies[i].Right + (int)StaticValues.distanceCarOfPanel < Road.Road.Width)
                        {
                            if (GameEngine.SpeedGame >= 1)
                            {
                                Enemies[i].Left -= movement[i];
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < Enemies.Length; i++)
                {
                    Road.CoinControl.Enabled = false;
                    Road.ClockElement.Enabled = false;
                    Road.CoinControl.Location = Road.RandomLocation(GameForm.Height + Road.CoinControl.Height);
                    Road.ClockElement.Location = Road.RandomLocation(GameForm.Height + Road.ClockElement.Height);
                    Enemies[i].Enabled = false;
                    Enemies[i].Location = Road.RandomLocation(GameForm.Height + Enemies[i].Height);
                }
            }
        }

        public void EnemiesBoundsed()
        {
            for (int i = 0; i < Enemies.Length; i++)
            {
                for (int j = 0; j < Enemies.Length; j++)
                {
                    if (i != j)
                    {
                        if (Enemies[j].Top < 0)
                        {
                            if (Enemies[i].Bounds.IntersectsWith(Enemies[j].Bounds))
                            {
                                Enemies[j].Location = Road.RandomLocation(Road.random.Next((int)StaticValues.enemyMinLocationY, (int)StaticValues.enemyMaxLocationY));
                            }
                        }
                    }
                }
            }
        }
    }
}
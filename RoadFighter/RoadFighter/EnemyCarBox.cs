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
        private PictureBox[] Enemies { get; set; }
        public int movement;
        public readonly int left = -1;
        public readonly int right = 2;
        
        public EnemyCarBox(FrmGame gameForm,GameEngine gameEngine, RoadBox road, PictureBox[] enemies)
        {
            GameForm = gameForm;
            GameEngine = gameEngine;
            Road = road;
            Enemies = enemies;
            for (int i = 0; i < road.EnemyCars.Length; i++)
            {
                Enemies[i].Location = road.RandomLocation(Road.random.Next(-1000, -250));
            }
            movement = Road.random.Next(left, right);
        }

        public void EnemyCarControl(double speed)
        {
            for (int i = 0; i < Enemies.Length; i++)
            {
                if (Road.RouteDistance >= 0)
                {
                    if (Enemies[i].Top > Road.Road.Height)
                    {
                        Enemies[i].Location = Road.RandomLocation(Road.random.Next(-1500, -100));
                        for (int j = 0; j < Enemies.Length; j++)
                        {
                            if (i != j)
                            {
                                if (Enemies[j].Bounds.IntersectsWith(Enemies[i].Bounds))
                                {
                                    Enemies[i].Location = Road.RandomLocation(Road.random.Next(-1500, -100));
                                }
                            }                            
                        }
                    }
                    else
                    {
                        Enemies[i].Top += (int)speed / 2;                        
                        for (int j = 0; j < Enemies.Length; j++)
                        {
                            if (i == j)
                            {
                                continue;
                            }
                            //else if (Enemies[i].Bounds.IntersectsWith(Enemies[j].Bounds))
                            if (Enemies[i].Location.X + Enemies[i].Width + 10 < Enemies[j].Location.X)
                            {
                                Enemies[i].Left -= 0;
                                //movement = 0;
                            }
                            if (Enemies[i].Left > (int)StaticValues.distanceCarOfPanel && Enemies[i].Right + (int)StaticValues.distanceCarOfPanel < Road.Road.Width)
                            {
                                if (GameEngine.SpeedGame >= 1)
                                {
                                    Enemies[i].Left -= movement;
                                }                                
                            }
                        }                        
                    }
                }
                else
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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadFighter
{
    public class ClockBox
    {
        private GameEngine GameEngine{ get; set; }
        private RoadBox Road { get; set; }

        public ClockBox(GameEngine gameEngine, RoadBox road)
        {
            GameEngine = gameEngine;
            Road = road;
            road.ClockElement.Location = road.RandomLocation((int)StaticValues.clockPosition);
            road.DrawRoundedControl(road.ClockElement);
        }

        public void ClockControl(double speed)
        {
            for (int i = 0; i < Road.EnemyCars.Length; i++)
            {
                if (Road.ClockElement.Top > Road.Road.Height)
                {
                    Road.ClockElement.Enabled = true;
                    Road.ClockElement.Location = Road.RandomLocation((int)StaticValues.clockPosition);

                    if ((Road.ClockElement.Location.Y == Road.EnemyCars[i].Height) || (Road.ClockElement.Location.X == Road.EnemyCars[i].Width) || (Road.ClockElement.Bounds.IntersectsWith(Road.EnemyCars[i].Bounds)))
                    {
                        Road.ClockElement.Location = Road.RandomLocation((int)StaticValues.clockPosition);
                    }
                }
                else if (GameEngine.SpeedGame >= 1)
                {
                    Road.ClockElement.Top += (int)speed / (int)StaticValues.roundStep;
                } 
            }            
        }

        public void ClockCollected()
        {
            if (Road.Auto.Bounds.IntersectsWith(Road.ClockElement.Bounds))
            {
                GameEngine.Road.Ticks += (int)StaticValues.clockCollected;
                Road.ClockElement.Enabled = false;

                Road.ClockElement.Location = Road.RandomLocation((int)StaticValues.clockPosition);
            }
        }
    }
}
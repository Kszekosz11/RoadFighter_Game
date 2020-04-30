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
            road.ChangeToRound(road.ClockElement);
        }

        public void ClockControl()
        {
            if (Road.ClockElement.Top > Road.Road.Height)
            {
                Road.ClockElement.Enabled = true;
                Road.ClockElement.Location = Road.RandomLocation((int)StaticValues.clockPosition);

                if ((Road.ClockElement.Location.Y == Road.EnemyAuto.Height) || (Road.ClockElement.Location.X == Road.EnemyAuto.Width) || (Road.ClockElement.Bounds.IntersectsWith(Road.EnemyAuto.Bounds)))
                {
                    Road.ClockElement.Location = Road.RandomLocation((int)StaticValues.clockPosition);
                }
            }
            else Road.ClockElement.Top += 5;
        }

        public void ClockCollected()
        {
            if (Road.Auto.Bounds.IntersectsWith(Road.ClockElement.Bounds))
            {
                GameEngine.Road.Ticks += 10;
                Road.ClockElement.Enabled = false;

                Road.ClockElement.Location = Road.RandomLocation((int)StaticValues.clockPosition);
            }
        }
    }
}

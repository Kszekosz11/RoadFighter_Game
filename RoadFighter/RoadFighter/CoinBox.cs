using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadFighter
{
    public class CoinBox
    {
        private GameEngine GameEngine { get; set; }
        private RoadBox Road { get; set; }       

        public CoinBox(GameEngine gameEngine, RoadBox road)
        {
            GameEngine = gameEngine;
            Road = road;            
            road.CoinControl.Location = road.RandomLocation((int)StaticValues.coinPosition);
            road.DrawRoundedControl(road.CoinControl);
        }

        public void CoinControl(double speed)
        {
            for (int i = 0; i < Road.EnemyCars.Length; i++)
            {
                if (Road.Auto.Top > Road.Road.Height)
                {
                    Road.CoinControl.Enabled = true;
                    Road.CoinControl.Location = Road.RandomLocation((int)StaticValues.coinPosition);

                    if ((Road.CoinControl.Location.Y == Road.EnemyCars[i].Height) || (Road.CoinControl.Location.X == Road.EnemyCars[i].Width) || (Road.CoinControl.Bounds.IntersectsWith(Road.EnemyCars[i].Bounds)))
                    {
                        Road.CoinControl.Location = Road.RandomLocation((int)StaticValues.coinPosition);
                    }
                }
                else if (GameEngine.SpeedGame >= 1)
                {
                    Road.CoinControl.Top += (int)speed / (int)StaticValues.roundStep;
                } 
            }                        
        }

        public void CoinCollected()
        {
            if (Road.Auto.Bounds.IntersectsWith(Road.CoinControl.Bounds))
            {
                Road.PointQuantity++;
                Road.Points.Text = "Points: " + Road.PointQuantity.ToString();
                Road.CoinControl.Enabled = false;
                Road.CoinControl.Location = Road.RandomLocation((int)StaticValues.coinPosition);
            }
            else if (Road.CoinControl.Top > Road.Road.Height)
            {
                Road.CoinControl.Location = Road.RandomLocation((int)StaticValues.coinPosition);
            }
        }
    }
}
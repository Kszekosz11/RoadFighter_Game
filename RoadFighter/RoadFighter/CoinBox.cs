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
        private RoadBox Road { get; set; }       

        public CoinBox(RoadBox road)
        {            
            Road = road;            
            road.CoinControl.Location = road.RandomLocation((int)StaticValues.coinPosition);
            road.ChangeToRound(road.CoinControl);
        }

        public void CoinControl()
        {
            if (Road.Auto.Top > Road.Road.Height)
            {
                Road.CoinControl.Enabled = true;
                Road.CoinControl.Location = Road.RandomLocation((int)StaticValues.coinPosition);

                if ((Road.CoinControl.Location.Y == Road.EnemyAuto.Height) || (Road.CoinControl.Location.X == Road.EnemyAuto.Width) || (Road.CoinControl.Bounds.IntersectsWith(Road.EnemyAuto.Bounds)))
                {
                    Road.CoinControl.Location = Road.RandomLocation((int)StaticValues.coinPosition);
                }
            }
            else Road.CoinControl.Top += 5;
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
        }
    }
}
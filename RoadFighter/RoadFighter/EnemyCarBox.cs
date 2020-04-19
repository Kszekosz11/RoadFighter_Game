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
        private FrmGame Game { get; set; }
        private RoadBox Road { get; set; }
        private int movement;
        
        public EnemyCarBox(FrmGame gameForm, RoadBox road)
        {
            Game = gameForm;
            Road = road;            
            Road.EnemyAuto.Location = road.RandomLocation((int)LocationY.enemyCar);
            movement = road.random.Next(-1, 2);
        }

        public void EnemyCarControl()
        {
            if (Road.RouteDistance >= 0)
            {
                if (Road.EnemyAuto.Top > Road.Road.Height)
                {
                    Road.EnemyAuto.Location = Road.RandomLocation((int)LocationY.enemyCar);
                    movement = Road.random.Next(-1, 2);
                }
                else
                {
                    Road.EnemyAuto.Top += 5;
                    if (Road.EnemyAuto.Left > Road.distanceOfPanel && Road.EnemyAuto.Right + Road.distanceOfPanel < Road.Road.Width)
                        Road.EnemyAuto.Left -= movement;
                }
            }
            else
            {
                Road.EnemyAuto.Enabled = false;
                Road.EnemyAuto.Location = Road.RandomLocation(Game.Height + Road.EnemyAuto.Height);
            }
        }
    }
}
    
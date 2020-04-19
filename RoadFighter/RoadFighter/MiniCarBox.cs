using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadFighter
{
    public class MiniCarBox
    {
        public PictureBox MiniCarAuto { get; set; }
        public PictureBox MiniFinishLine { get; set; }

        private RoadBox Road { get; set; }

        public MiniCarBox(FrmGame gameForm, RoadBox road)
        {
            MiniCarAuto = gameForm.pcbMiniCar;
            MiniFinishLine = gameForm.pcbMiniFinishLine;
            Road = road;
        }

        public void RouteDistanceMiniCar()
        {
            if (MiniCarAuto.Bounds.IntersectsWith(MiniFinishLine.Bounds))
            {
                MiniCarAuto.Top -= 0;
            }
            else MiniCarAuto.Location = new Point(23, (int)Road.RouteDistance * 10);

            // FINISHLINE LOCATION Y = 50 HEIGHT 10
            // MINICAR LOCATION Y = 660
            // 660 - 60 = 600
        }
    }
}

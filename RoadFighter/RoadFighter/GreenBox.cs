using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadFighter
{
    public class GreenBox
    {
        private FrmGame GameForm { get; set; }
        private Panel Grass { get; set; }
        private PictureBox[] SceneElements { get; set; }

        public GreenBox(FrmGame gameForm)
        {
            GameForm = gameForm;
            Grass = gameForm.pnlGrass;
            SceneElements = new PictureBox[Grass.Controls.Count];

            for (int i = 0; i < Grass.Controls.Count; i++)
            {
                SceneElements[i] = (PictureBox)Grass.Controls[i];
            }
        }

        public void DrawScene(double speed)
        {
            for (int i = 0; i < SceneElements.Length; i++)
            {
                if (SceneElements[i].Top >= GameForm.Height) SceneElements[i].Top = -SceneElements[0].Height;
                else SceneElements[i].Top += (int)speed;
            }
        }
    }
}
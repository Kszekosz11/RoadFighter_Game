using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadFighter
{
    public class CarBox
    {
        private GameEngine GameEngine { get; set; }
        private RoadBox Road { get; set; }
        private PictureBox Car { get; set; }

        private readonly int step = 10;

        public CarBox(FrmGame game, GameEngine gameEngine, RoadBox road)
        {
            Car = game.pcbCar;
            GameEngine = gameEngine;
            Road = road;
        }

        public void CarControl(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (Car.Left > Road.distanceOfPanel) Car.Left -= step;
                    break;
                case Keys.Right:
                    if (Car.Right < Road.Road.Width - Road.distanceOfPanel) Car.Left += step;
                    break;
                case Keys.Up:
                    if (GameEngine.SceneTimer.Enabled == false)
                    {
                        GameEngine.GameTimer.Enabled = true;
                        GameEngine.SceneTimer.Enabled = true;
                    }
                    else if (Car.Top > Road.FinishLine.Top)
                    {
                        if (GameEngine.SpeedGame <= GameEngine.SpeedMax)
                        {
                            GameEngine.SpeedGame += 1;
                            if (Road.FinishLine.Visible == true)
                            {
                                Car.Top -= step;
                            }
                        }
                        Car.Top -= 5;
                    }
                    break;
                case Keys.Down:
                    if (Car.Top < Road.Road.Height - Car.Height - Road.distanceOfPanel)
                    {
                        if (GameEngine.SpeedGame >= GameEngine.SpeedMin)
                        {
                            GameEngine.SpeedGame -= 1;
                            Car.Top += 5;
                        }
                    }
                    break;
                case Keys.Space:
                    if (GameEngine.SceneTimer.Enabled == true)
                    {
                        GameEngine.SceneTimer.Stop();
                        GameEngine.GameTimer.Stop();
                    }
                    else
                    {
                        GameEngine.SceneTimer.Start();
                        GameEngine.GameTimer.Start();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}

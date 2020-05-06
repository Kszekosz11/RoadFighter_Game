using System;
using System.Collections.Generic;
using System.Drawing;
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
                    if (GameEngine.SceneTimer.Enabled == true)
                    {
                        if (GameEngine.SpeedGame >= 1)
                        {
                            if (Car.Left > (int)StaticValues.distanceCarOfPanel) Car.Left -= (int)StaticValues.carStep;
                        }                            
                    }                        
                    break;
                case Keys.Right:
                    if (GameEngine.SceneTimer.Enabled == true)
                    {
                        if (GameEngine.SpeedGame >= 1)
                        {
                            if (Car.Right < Road.Road.Width - (int)StaticValues.distanceCarOfPanel) Car.Left += (int)StaticValues.carStep;
                        }                        
                    }                        
                    break;
                case Keys.Up:
                    if (GameEngine.SceneTimer.Enabled == false)
                    {                        
                        GameEngine.PauseGame();
                    }
                    else if (Car.Top > Road.FinishLine.Top)
                        {
                            if (GameEngine.SpeedGame <= GameEngine.SpeedMax)
                            {
                                GameEngine.SpeedGame += 0.5;
                                if (Road.FinishLine.Visible == true) Car.Top -= (int)StaticValues.carStep;                                    
                            }
                            Car.Top -= 5;
                        }                
                    break;
                case Keys.Down:
                    if (GameEngine.SceneTimer.Enabled == true)
                    {                        
                        if (Car.Top < Road.Road.Height - Car.Height - (int)StaticValues.distanceCarOfPanel)
                        {
                            if (GameEngine.SpeedGame >= GameEngine.SpeedMin)
                            {
                                GameEngine.SpeedGame -= 0.25;
                                Car.Top += 5;
                            }
                        }                                                
                    }                        
                    break;
                case Keys.Space:
                    GameEngine.PauseGame();
                    break;
                default:
                    break;
            }
        }
    }
}
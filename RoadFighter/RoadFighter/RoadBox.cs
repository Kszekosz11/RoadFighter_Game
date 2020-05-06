using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadFighter
{
    public class RoadBox
    {
        public CarBox CarBox { get; set; }
        public CoinBox CoinBox { get; set; }
        public ClockBox Clock { get; set; }
        public EnemyCarBox EnemyCarBox { get; set; }
        public MiniCarBox MiniCarBox { get; set; }
        public Panel Road { get; set; }
        public Panel LeftLines { get; set; }
        public Panel RightLines { get; set; }
        public PictureBox Line { get; set; }
        public PictureBox FinishLine { get; set; }
        public PictureBox Auto { get; set; }
        public PictureBox[] EnemyCars { get; set; }
        public PictureBox CoinControl { get; set; }
        public PictureBox ClockElement { get; set; }
        public Label Points { get; set; }
        public Label Time { get; set; }
        public Label Distance { get; set; }
        public Label Pause { get; set; }
        public int Ticks { get; set; }
        public int PointQuantity { get; set; }
        public double RouteDistance { get; set; }
        public Random random = new Random();

        public RoadBox(FrmGame gameFrom, GameEngine gameEngine)
        {
            LeftLines = gameFrom.pnlLeftLines;
            RightLines = gameFrom.pnlRightLines;
            Line = gameFrom.pcbLine1;
            Road = gameFrom.pnlRoad;
            Auto = gameFrom.pcbCar;
            EnemyCars = new PictureBox[3];
            EnemyCars[0] = gameFrom.pcbEnemyCar;
            EnemyCars[1] = gameFrom.pcbEnemyCar2;
            EnemyCars[2] = gameFrom.pcbEnemyCar3;
            CoinControl = gameFrom.pcbCoin;
            ClockElement = gameFrom.pcbClock;
            FinishLine = gameFrom.pcbFinishLine;
            Points = gameFrom.lblPoints;
            Distance = gameFrom.lblDistance;
            Time = gameFrom.lblTime;
            Pause = gameFrom.lblPause;
            Ticks = 30;
            PointQuantity = 0;
            RouteDistance = 60;
            Points.Text = "Points: " + PointQuantity.ToString();
            Time.Text = "Time: " + Ticks.ToString();
            Distance.Text = string.Format("{0:F1}", RouteDistance + " km");
            CarBox = new CarBox(gameFrom, gameEngine, this);
            EnemyCarBox = new EnemyCarBox(gameFrom, gameEngine, this, EnemyCars);
            CoinBox = new CoinBox(gameEngine, this);
            Clock = new ClockBox(gameEngine, this);
            MiniCarBox = new MiniCarBox(gameFrom, this);
        }

        public void DrawRoad(double speed)
        {
            if (LeftLines.Top >= Line.Height + (int)StaticValues.distanceBetweenLines)
            {
                LeftLines.Top = 0;
                RightLines.Top = 0;
            }
            else
            {
                LeftLines.Top += (int)speed;
                RightLines.Top += (int)speed;
            }
        }
        public void DrawRoundedControl(Control element)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, element.Width, element.Height);
            Region rg = new Region(gp);
            element.Region = rg;
        }
        public Point RandomLocation(int distance)
        {
            return new Point(random.Next(EnemyCars[0].Width, Road.Width - EnemyCars[0].Width), distance);
        }
    }
}
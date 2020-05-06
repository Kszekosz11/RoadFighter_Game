using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadFighter
{
    public partial class FrmGame : Form
    {
        public FrmMenu MenuForm { get; }        
        public GameEngine GameEngine { get; }

        public FrmGame(FrmMenu formMenu)
        {
            InitializeComponent();
            FormSettings.SetSetting(this);
            MenuForm = formMenu;            
            GameEngine = new GameEngine(this, MenuForm);       
        }

        private void SceneTimer_Tick(object sender, EventArgs e)
        {
            GameEngine.Road.DrawRoad(GameEngine.SpeedGame);
            GameEngine.Grass.DrawScene(GameEngine.SpeedGame);
            GameEngine.Road.EnemyCarBox.EnemyCarControl(GameEngine.SpeedGame);            
            GameEngine.Road.CoinBox.CoinControl(GameEngine.SpeedGame);
            GameEngine.Road.CoinBox.CoinCollected();
            GameEngine.Road.Clock.ClockControl(GameEngine.SpeedGame);
            GameEngine.Road.Clock.ClockCollected();
            GameEngine.DistanceToFinish();
            GameEngine.ShowFinishLine();
            GameEngine.GameOver();
            GameEngine.Road.EnemyCarBox.EnemiesBoundsed();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            GameEngine.GameTime();
            GameEngine.Road.MiniCarBox.RouteDistanceMiniCar();
            
            for (int i = 0; i < GameEngine.Road.EnemyCarBox.Enemies.Length; i++)
            {
                GameEngine.Road.EnemyCarBox.movement[i] = GameEngine.Road.random.Next((int)StaticValues.movementLeft, (int)StaticValues.movementRight);
            }
        }

        private void FinishGame_Tick(object sender, EventArgs e)
        {
            GameEngine.IfYouWin();
        }

        private void KeysHandling(object sender, KeyEventArgs e)
        {
            GameEngine.Road.CarBox.CarControl(e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MenuForm.Show();
        }
    }
}
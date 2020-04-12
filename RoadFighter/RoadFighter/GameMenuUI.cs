using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadFighter
{
    public partial class frmMenuUI : Form
    {
        GameEngine game = new GameEngine();

        public frmMenuUI()
        {
            InitializeComponent();            

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            pcbMenuCar.Left = -100;
        }

        private void btnStartGame_click(object sender, EventArgs e)
        {
            frmGame game = new frmGame();
            this.Hide();
            game.Show();            
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pcbMenuCar.Left < 680)
            {
                pcbMenuCar.Left += 30;
            }
            else pcbMenuCar.Left = -100;
            
            //if (pcbSmoke.Left > 0)
            //{
            //    pcbSmoke.Left -= 10;
            //}
            //else pcbSmoke.Left = 50;
        }
    }
}

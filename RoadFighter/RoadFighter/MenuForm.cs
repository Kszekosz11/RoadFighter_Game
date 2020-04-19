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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;            
        }

        private void btnStartGame_click(object sender, EventArgs e)
        {
            FrmGame startGame = new FrmGame(this);
            this.Hide();
            startGame.Show();            
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

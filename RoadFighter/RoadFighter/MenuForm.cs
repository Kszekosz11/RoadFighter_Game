using RoadFighter.Properties;
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
            FormSettings.SetSetting(this);
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            FrmGame startGame = new FrmGame(this);
            this.Hide();
            startGame.Show();            
        }

        private void BtnControls_Click(object sender, EventArgs e)
        {
            FrmControls frmControls = new FrmControls(this);
            this.Hide();
            frmControls.Show();
        }

        private void BtnRecords_Click(object sender, EventArgs e)
        {
            FrmGameRecords frmGameRecords = new FrmGameRecords(this);
            this.Hide();
            frmGameRecords.Show();
        }

        private void BtnQuitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
using RoadFighter.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace RoadFighter
{
    public partial class FrmControls : Form
    {
        private FrmMenu MenuForm { set; get; }
        public FrmControls(FrmMenu menuForm)
        {
            InitializeComponent();
            FormSettings.SetSetting(this);
            MenuForm = menuForm;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MenuForm.Show();
        }
    }
}
using RoadFighter.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadFighter
{
    public partial class FrmGameRecords : Form
    {
        private FrmMenu MenuForm { get; set; }

        public FrmGameRecords(FrmMenu frmMenu)
        {
            InitializeComponent();
            FormSettings.SetSetting(this);
            MenuForm = frmMenu;

            using (var context = new RoadFighterDataEnt())
            {
                var records = context.GameRecords.Select(x => new
                {
                    x.Score,
                    x.Name,
                    x.GameID,
                    x.Crash
                })
                .OrderByDescending(x => x.Score)
                .ToList();
                
                dtvRecords.DataSource = records;
            }           
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
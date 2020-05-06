using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadFighter
{
    public static class FormSettings
    {
        public static void SetSetting(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.Text = "RoadFighter";
            form.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}

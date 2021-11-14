using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billentyűzet
{
    class GombSzin : Button
    {
        public GombSzin()
        {
            MouseEnter += GombSzin_MouseEnter;
            MouseLeave += GombSzin_MouseLeave;
        }

        private void GombSzin_MouseLeave(object sender, EventArgs e)
        {
            BackColor = SystemColors.ButtonFace;
        }

        private void GombSzin_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}

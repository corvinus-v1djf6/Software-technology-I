using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lovak
{
    class MozgóGomb : Button
    {
        int ox, oy;
        bool mozoge = false;

        public MozgóGomb()
        {
            MouseMove += MozgóGomb_MouseMove;
            MouseUp += MozgóGomb_MouseUp;
            MouseDown += MozgóGomb_MouseDown;
        }

        private void MozgóGomb_MouseDown(object sender, MouseEventArgs e)
        {
            ox = e.X;
            oy = e.Y;
            mozoge = true;
        }

        private void MozgóGomb_MouseUp(object sender, MouseEventArgs e)
        {
            mozoge = false;
        }

        private void MozgóGomb_MouseMove(object sender, MouseEventArgs e)
        {
            //Text = e.X.ToString() + ";" + e.Y.ToString();
            //Text = $"({e.X};{e.Y})";
            if (mozoge)
            {
                Left += e.X - ox;
                Top += e.Y - oy;
            }
        }
    }
}

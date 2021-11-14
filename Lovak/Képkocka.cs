using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lovak
{
    class Képkocka : PictureBox
    {
        int ox, oy;
        bool mozoge = false;

        public Képkocka()
        {
            MouseDown += Képkocka_MouseDown;
            MouseUp += Képkocka_MouseUp;
            MouseMove += Képkocka_MouseMove;


        }

        private void Képkocka_MouseMove(object sender, MouseEventArgs e)
        {
            if (mozoge==true)
            {
                Left += e.X - ox;
                Top += e.Y - oy;
            }
        }

        private void Képkocka_MouseUp(object sender, MouseEventArgs e)
        {
            mozoge = false;
        }

        private void Képkocka_MouseDown(object sender, MouseEventArgs e)
        {
            ox = e.X;
            oy = e.Y;
            mozoge = true;
        }
    }
}

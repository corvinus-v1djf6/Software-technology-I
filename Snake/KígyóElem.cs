using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class KígyóElem : PictureBox
    {
        public static int Méret = 30;

        public KígyóElem()
        {
            Width = Méret;
            Height = Méret;
            BackColor = Color.Fuchsia;
        }
    }
}

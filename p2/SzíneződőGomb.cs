using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2
{
    class SzíneződőGomb : Button
    {
        public SzíneződőGomb()
        {
            Width = 20;
            Height = 20;
            Click += SzíneződőGomb_Click;

        }

        private void SzíneződőGomb_Click(object sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}

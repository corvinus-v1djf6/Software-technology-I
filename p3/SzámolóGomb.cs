﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p3
{
    class SzámolóGomb : Button
    {
        int szám;

        public SzámolóGomb()
        {
            Width = 20;
            Height = 20;
            Click += SzámolóGomb_Click;
            szám = 1;
            Text = szám.ToString();
        }

        private void SzámolóGomb_Click(object sender, EventArgs e)
        {
            szám++;
            if (szám==6)
            {
                szám = 1;
            }
            Text = szám.ToString();
        }
    }
}

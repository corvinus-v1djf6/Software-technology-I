using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billentyűzet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("NewFolder1/kbd_hun.txt");

            while (!sr.EndOfStream)
            {
                int x = int.Parse(sr.ReadLine());
                int y = int.Parse(sr.ReadLine());
                int h = int.Parse(sr.ReadLine()); //magasság-height
                int w = int.Parse(sr.ReadLine()); //szélesség-width
                string jel = sr.ReadLine();


                GombSzin b = new GombSzin();
                b.Top = y;
                b.Left = x;
                b.Width = w;
                b.Height = h;
                b.Text = jel;

               

                Controls.Add(b);
            }

            sr.Close();
        }

    }
}

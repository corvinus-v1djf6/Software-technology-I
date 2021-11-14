using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lovak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kever();
            int sorszam = 0;

            for (int s = 0; s < 5; s++)
            {
                for (int o = 0; o < 5; o++)
                {
                    Képkocka kk = new Képkocka();
                    kk.Width = 76;
                    kk.Height = 76;
                    kk.Top = s * (76 + 1);
                    kk.Left = o * (76 + 1);
                    kk.BackColor = Color.Fuchsia;
                    kk.Load($"Képek/lo_{tömb[sorszam]}.jpg");
                    Controls.Add(kk);
                    sorszam++;
                }
            }
        }

        int[] tömb = new int[25];

        void Kever()
        {
            int n = 25;

            for (int i = 0; i < n; i++)
            {
                tömb[i] = i+1;
                //Trace.WriteLine("*******" + i);
            }

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                int egyik = rnd.Next(0, n);
                int másik = rnd.Next(0, n);

                int köztes = tömb[egyik];
                tömb[egyik] = tömb[másik];
                tömb[másik] = köztes;
            }



        }

    }
}

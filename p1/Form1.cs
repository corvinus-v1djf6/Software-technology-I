using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int s = 0; s < 10; s++)
            {
                for (int o = 0; o < 10; o++)
                {
                    VillogoGomb button = new VillogoGomb();
                    button.Height = 40;
                    button.Width = 40;
                    button.Left = o * 40;
                    button.Top = s * 40;

                    int szorzat = s * o;
                    button.Text = szorzat.ToString();

                    Controls.Add(button);
                }

            }




        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p3
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
                    SzámolóGomb számolóGomb = new SzámolóGomb();
                    számolóGomb.Height = 20;
                    számolóGomb.Width = 20;
                    számolóGomb.Top = s * 20;
                    számolóGomb.Left = o * 20;

                    Controls.Add(számolóGomb);
                }
            }
        }
    }
}

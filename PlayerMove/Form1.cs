using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerMove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                játékos.Left -= játékos.Width;
            }

            if (e.KeyCode == Keys.D)
            {
                játékos.Left += játékos.Width;
            }

            if (e.KeyCode == Keys.W)
            {
                játékos.Top -= játékos.Height;
            }

            if (e.KeyCode == Keys.S)
            {
                játékos.Top += játékos.Height;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            játékos.Top = 0;
            játékos.Left = 0;
        }
    }
}

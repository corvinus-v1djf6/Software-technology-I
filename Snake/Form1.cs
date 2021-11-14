using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        int fejX = 100;
        int fejY = 100;
        int irányX = 1;
        int irányY = 0;
        int hossz = 5;
        int lépésszám = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fejX += irányX * KígyóElem.Méret;
            fejY += irányY * KígyóElem.Méret;

            foreach (KígyóElem item in Controls)
            {
                if (item.Top == fejY && item.Left == fejX)
                {
                    Application.Exit();
                }
            }

            KígyóElem újfej = new KígyóElem();
            újfej.Left = fejX;
            újfej.Top = fejY;

            Controls.Add(újfej);

            if (Controls.Count > hossz)
            {
                Controls.RemoveAt(0);
            }
            if (lépésszám % 5 == 0)
            {
                hossz++;
            }
            lépésszám++;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                //felfelé
                irányX = 0;
                irányY = -1;
            }

            if (e.KeyCode == Keys.A)
            {
                //lefelé
                irányX = 0;
                irányY = 1;
            }

            if (e.KeyCode == Keys.O)
            {
                //balra
                irányX = -1;
                irányY = 0;
            }

            if (e.KeyCode == Keys.P)
            {
                //jobbra
                irányX = 1;
                irányY = 0;
            }

        }
    }
}

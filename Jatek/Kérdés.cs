using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jatek
{
    public partial class Kérdés : UserControl
    {
        int jóválasz;
        public bool eltaláta = false;

        public Kérdés()
        {
            InitializeComponent();
        }

        public Kérdés(string kédés, string v1, string v2, string v3, string v4, int jóválasz)
        {
            InitializeComponent();
            label1.Text = kédés;
            button1.Text = v1;
            button2.Text = v2;
            button3.Text = v3;
            button4.Text = v4;
            this.jóválasz = jóválasz;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            Színezd();
            if (jóválasz == 1) eltaláta = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            Színezd();
            if (jóválasz == 2) eltaláta = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            Színezd();
            if (jóválasz == 3) eltaláta = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            Színezd();
            if (jóválasz == 4) eltaláta = true;
        }

        void Színezd()
        {
            if (jóválasz == 1) button1.BackColor = Color.Green;
            if (jóválasz == 2) button2.BackColor = Color.Green;
            if (jóválasz == 3) button3.BackColor = Color.Green;
            if (jóválasz == 4) button4.BackColor = Color.Green;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasodfokuEgyenlet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            try
            {
                a = double.Parse(textBoxA.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Számot írj az 'a' paraméternek.");
                return;
            }

            double b;
            try
            {
                b = double.Parse(textBoxB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Számot írj az 'b' paraméternek.");
                return;
            }

            double c;
            try
            {
                c = double.Parse(textBoxC.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Számot írj az 'c' paraméternek.");
                return;
            }



            double d = Math.Pow(b, 2) - 4 * a * c;

            double gyök1 = (-b - Math.Sqrt(d)) / (2 * a);
            double gyök2 = (-b + Math.Sqrt(d)) / (2 * a);

            textBox_e1.Text = gyök1.ToString();
            textBox_e2.Text = gyök2.ToString();

            if (d < 0)
            {
                textBox_e1.Visible = false;
                textBox_e2.Visible = false;
                return;
            }
            else
            {
                textBox_e1.Visible = true;
                textBox_e2.Visible = true;
            }


            if (d == 0)
            {
                textBox_e2.Visible = false;
            }
            else
            {
                textBox_e2.Visible = true;
            }
        }
    }
}

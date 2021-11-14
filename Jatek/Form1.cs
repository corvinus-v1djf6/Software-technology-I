using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Jatek
{
    public partial class Form1 : Form
    {
    public Form1()
    {
        InitializeComponent();

        StreamReader sr = new StreamReader("jatek2.csv", Encoding.Unicode);

        int pozíció = 0;
        while (!sr.EndOfStream)
        {
            string kérdés = sr.ReadLine();
            string válasz1 = sr.ReadLine();
            string válasz2 = sr.ReadLine();
            string válasz3 = sr.ReadLine();
            string válasz4 = sr.ReadLine();
            int jóválasz = Convert.ToInt32(sr.ReadLine());

            Kérdés k = new Kérdés(kérdés,válasz1,válasz2,válasz3,válasz4,jóválasz);
            panel1.Controls.Add(k);
            k.Top = pozíció * k.Height;
            pozíció++;
          //k.label1.Text = kérdés;
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {

        StreamWriter sw = new StreamWriter("jatek2.csv",true, Encoding.Unicode);

        StreamReader sr = new StreamReader("jatek.csv",Encoding.Default);
        while (!sr.EndOfStream)
        {
            string s = sr.ReadLine();
            string[] st = s.Split(';');

            foreach (string sd in st)
            {
                sw.WriteLine(sd);
            }
        }

        sr.Close();
        sw.Close();

    }

    private void button2_Click(object sender, EventArgs e)
    {
        int talált = 0;
        int nemTalált = 0;
        foreach(Kérdés k in  panel1.Controls)
        {
            if (k.eltaláta)
            {
                talált++;
            }
            else
            {
                nemTalált++;
            }
        }
        MessageBox.Show("Jó: " + talált + " Nem talált:" + nemTalált);
    }
}
}

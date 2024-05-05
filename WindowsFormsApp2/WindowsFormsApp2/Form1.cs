using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int say = 0;
        int ort = 0;
        int tum;
        int[] kalan = new int[5];
        int[] gecen = new int[5];
        int[] tesekkur = new int[5];
        int[] takdir = new int[5];

        string[] ogr = new string[5];

        int[] ortalama = new int[5];

        private void button1_Click(object sender, EventArgs e)
        {
            if (say < ogr.Length)
            {
                ogr[say] = textBox1.Text;
                ortalama[say] = int.Parse(textBox2.Text);


                textBox1.Text = "";
                textBox2.Text = "";

                if (ortalama[say] < 50)
                {
                    kalan[say] = ortalama[say];
                }
                else if (ortalama[say] >= 50)
                {
                    gecen[say] = ortalama[say];
                }
                if (ortalama[say] >= 70)
                {
                    if (ortalama[say] < 85)
                    {
                        tesekkur[say] = ortalama[say];
                    }
                }
                if (ortalama[say] >= 85)
                {
                    takdir[say] = ortalama[say];
                }
                say++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstOgrenciler.Items.Clear();
            say = 0;
            for (int i = 0; i < ogr.Length; i++)
            {
                lstOgrenciler.Items.Add(ogr[say] + " - " + ortalama[say]);
                say++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstOgrenciler.Items.Clear();
            say = 0;
            for (int i = 0; i < ogr.Length; i++)
            {
                lstOgrenciler.Items.Add(ogr[say] +  " - " + kalan[say]);
                say++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lstOgrenciler.Items.Clear();
            say = 0;
            for (int i = 0; i < ogr.Length; i++)
            {
                lstOgrenciler.Items.Add(ogr[say] + " - " + gecen[say]);
                say++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lstOgrenciler.Items.Clear();
            say = 0;
            for (int i = 0; i < ogr.Length; i++)
            {
                lstOgrenciler.Items.Add(ogr[say] + " - " + tesekkur[say]);
                say++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lstOgrenciler.Items.Clear();
            say = 0;
            for (int i = 0; i < ogr.Length; i++)
            {
                lstOgrenciler.Items.Add(ogr[say] + " - " + takdir[say]);
                say++;
            }
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Formats.Asn1;
using System.Globalization;

namespace Akasztófa_projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            adatokbetoltese();
        }

        List<string> szavak = new List<string>();

        private void button_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(ofd.FileName);
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        szavak.Add(line);
                    }
                    sr.Close();

                    Invalidate();
                    szoszam = szavak.Count();
                    int db = n.Next(0, szoszam);
                    kitalálandó = szavak[db];
                    hibapont = 0;
                    közbeni = "";
                    tipp = ' ';
                    közbeni = közbeni.PadRight(kitalálandó.Length, '*');
                    feladvany.Text = közbeni;
                    uzenet.Text = "";
                    hibaszam.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Button[] Gombok = new Button[35];
        int x, y, i, szoszam;
        string kitalálandó, közbeni = "", seged = "";
        char tipp;
        int hibapont = 0;
        int tippekszama = 0;
        Random n = new Random();

        private void adatokbetoltese()
        {
            string abc = "AÁBCDEÉFGHIÍJKLMNOÓÖŐPQRSTUÚÜŰVWXYZ";
            Gombok = new Button[35];
            for (int i = 0; i < 35; i++)
            {
                Gombok[i] = new Button();

                Gombok[i].Text = abc[i].ToString();
                Gombok[i].Width = 40;
                Gombok[i].Height = 40;
                Gombok[i].Tag = i;
                x = 5 + (i % 12) * 40;
                y = 200 + (i / 12) * 60;
                Gombok[i].Location = new Point(x, y);
                Gombok[i].Click += new EventHandler(MyButton_click);
                Controls.Add(Gombok[i]);
            }

            
        }


        private void MyButton_click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            tipp = Convert.ToChar(b.Text.ToLower());
            b.Visible = false;
            ellenoriz();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Button b in Gombok)
            {
                this.Controls.Remove(b);
                b.Dispose();
            }

            adatokbetoltese();
        }

        void ellenoriz()
        {
            tippekszama++;
            seged = "";
            for (int i = 0; i < kitalálandó.Length; i++)
            {
                if (tipp == kitalálandó[i])
                {
                    seged += tipp;
                }
                else
                {
                    seged += közbeni[i];
                }
            }

            if (közbeni == seged) hibapont++;

            közbeni = seged;
            hibaszam.Text = Convert.ToString(hibapont);
            feladvany.Text = közbeni;

            if ((kitalálandó == közbeni) && (hibapont < 9))
            {
                feladvany.Text = "";
                uzenet.Text = "Gratulálok, Ön nyert! A megoldás: " + kitalálandó;
            }
            if (hibapont >= 9)
            {
                uzenet.Text = "Sajnálom, Ön vesztett! A megoldás: " + kitalálandó;
            }
        }

        Pen toll = new Pen(Color.Red, 1);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            switch (hibapont)
            {
                case 1:
                    g.DrawLine(toll, 600, 100, 600, 500);
                    break;
                case 2:
                    g.DrawLine(toll, 600, 100, 750, 100);
                    break;
                case 3:
                    g.DrawLine(toll, 750, 100, 750, 150);
                    break;
                case 4:
                    {
                        g.DrawEllipse(toll, 730, 150, 40, 40);
                    }
                    break;
                case 5:
                    g.DrawLine(toll, 750, 190, 750, 300);
                    break;
                case 6:
                    g.DrawLine(toll, 700, 200, 750, 200);
                    break;
                case 7:
                    g.DrawLine(toll, 750, 200, 800, 200);
                    break;
                case 8:
                    g.DrawLine(toll, 700, 400, 750, 300);
                    break;
                case 9:
                    g.DrawLine(toll, 750, 300, 800, 400);
                    break;
            }
        }
    }
}
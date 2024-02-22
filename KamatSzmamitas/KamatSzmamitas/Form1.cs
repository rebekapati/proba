using System.Runtime.CompilerServices;

namespace KamatSzmamitas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            decimal hitel�sszeg = decimal.Parse(TextboxHitel�sszeg.Text);
            decimal haviKamat = decimal.Parse(textBoxHavikamat.Text);
            decimal haviT�rleszt� = decimal.Parse(comboBoxHavit�rleszt�.Text);

            decimal h�tral�k = hitel�sszeg; // nem a hitel�sszeg cs�kken hanem abb�l a h�tral�k

            int h�nap = 1;
            decimal k�lts�g = 0;

            //List<Sor> sorok = new List<Sor>();
            List<ExtraSor> sorok = new List<ExtraSor>();

            while (h�tral�k > 0)
            {
                h�tral�k += h�tral�k * (haviKamat / 100m);
                h�tral�k -= haviT�rleszt�;
                k�lts�g += haviT�rleszt�;

                if (haviT�rleszt� < h�tral�k * (haviKamat / 100m))
                {
                    MessageBox.Show(":((");
                    break;
                }

                Sor �jSor = new Sor();  //objektum: �jsor, classban fv.: met�dus, konstruktor fv.: azonos n�ven
                �jSor.H�tral�k = h�tral�k;
                �jSor.H�nap = h�nap;

                //sorok.Add(�jSor);
                
                ExtraSor extra = new ExtraSor();
                sorok.Add(ExtraSor);
                extra.H�nap = h�nap;
                extra.H�tral�k = h�tral�k;
                extra.Kummul�ltBefizet�s = k�lts�g;


                h�nap++;
            }

            k�lts�g += h�tral�k;

            dataGridView1.DataSource = sorok;

            MessageBox.Show(k�lts�g.ToString());

        }
    }
}
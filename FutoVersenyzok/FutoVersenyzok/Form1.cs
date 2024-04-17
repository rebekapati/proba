using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace FutoVersenyzok
{
    public partial class Form1 : Form
    {
        BindingList<Versenyz�> adatok = new BindingList<Versenyz�>(); //oszt�lyszinten hogy az �sszes met�dusban l�tsz�djon

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = versenyz�BindingSource; // l�gyszi zh-n pl�z ne
            versenyz�BindingSource.DataSource = adatok;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonOpen_Click(object sender, EventArgs e) //--F�JLBEOLVAS�S
        {
            try // a f�jlm�veletek a rem�nyr�l sz�lnak
            {
                StreamReader sr = new StreamReader("futoversenyzok.csv");
                CsvReader csv = new CsvReader(sr, CultureInfo.InvariantCulture); // a zh nem az a pont ahol az ember innov�l az �letben
                var t�mb = csv.GetRecords<Versenyz�>();
                foreach (var item in t�mb)
                {
                    adatok.Add(item);
                }

                sr.Close();
            }
            catch (Exception ex) // ex objektum �tv�tele, nem automatikus
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e) //--MENT�S
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK) //blokkol� h�v�s
            {
                try
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    CsvWriter csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(adatok);

                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e) //--SORT�RL�S
        {
            if (versenyz�BindingSource.Current == null) return;
            /*{
                MessageBox.Show("Hiba t�rt�nt, nincs kijel�lt sor!", "Hiba", MessageBoxButtons.OK);
            }*/

            if (MessageBox.Show("Biztos benne?", "T�rl�s", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                versenyz�BindingSource.RemoveCurrent();
            }
        }

        private void ButtonAddNew_Click(object sender, EventArgs e) //--�JSOR
        {
            FormAddNew formAddNew = new FormAddNew(); //lep�ld�nyos�tom

            //formAddNew.�jVersenyz� = versenyz�BindingSource.Current as Versenyz�; nem story

            if (formAddNew.ShowDialog() == DialogResult.OK) //addig nem enged vissza �s m�k�dnek a gombok <> .Show()
            {
                versenyz�BindingSource.Add(formAddNew.�jVersenyz�);
            }
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            double �sszeg = 0;
            double �sszUSA = 0;
            int darab = 0;

            double minimum = double.PositiveInfinity;

            string leggyorsabb = string.Empty;

            foreach (var item in adatok)
            {
                �sszeg += item.EredmenyPerc;

                if (item.Nemzetiseg == "USA")
                {
                    �sszUSA += item.EredmenyPerc;
                    darab++;
                }

                if (item.EredmenyPerc < minimum)
                {
                    minimum = item.EredmenyPerc;
                    leggyorsabb = item.Nev;
                }

                //double �tlag = �sszeg / adatok.Count(); //vlm nem m�kszik
            }
            double �tlag = �sszeg / adatok.Count(); //vlm nem m�kszik megold�s: ide kell tenni. nem foreachen bel�lre, mert az akkor mndig lefut. itt csak egyszer kell szamolni atlagot

            MessageBox.Show($"A legjobb id� {minimum}");
        }
    }
}
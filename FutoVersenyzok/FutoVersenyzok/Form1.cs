using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace FutoVersenyzok
{
    public partial class Form1 : Form
    {
        BindingList<Versenyzõ> adatok = new BindingList<Versenyzõ>(); //osztályszinten hogy az összes metódusban látszódjon

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = versenyzõBindingSource; // légyszi zh-n plíz ne
            versenyzõBindingSource.DataSource = adatok;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonOpen_Click(object sender, EventArgs e) //--FÁJLBEOLVASÁS
        {
            try // a fájlmûveletek a reményrõl szólnak
            {
                StreamReader sr = new StreamReader("futoversenyzok.csv");
                CsvReader csv = new CsvReader(sr, CultureInfo.InvariantCulture); // a zh nem az a pont ahol az ember innovál az életben
                var tömb = csv.GetRecords<Versenyzõ>();
                foreach (var item in tömb)
                {
                    adatok.Add(item);
                }

                sr.Close();
            }
            catch (Exception ex) // ex objektum átvétele, nem automatikus
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e) //--MENTÉS
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK) //blokkoló hívás
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

        private void ButtonDelete_Click(object sender, EventArgs e) //--SORTÖRLÉS
        {
            if (versenyzõBindingSource.Current == null) return;
            /*{
                MessageBox.Show("Hiba történt, nincs kijelölt sor!", "Hiba", MessageBoxButtons.OK);
            }*/

            if (MessageBox.Show("Biztos benne?", "Törlés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                versenyzõBindingSource.RemoveCurrent();
            }
        }

        private void ButtonAddNew_Click(object sender, EventArgs e) //--ÚJSOR
        {
            FormAddNew formAddNew = new FormAddNew(); //lepéldányosítom

            //formAddNew.ÚjVersenyzõ = versenyzõBindingSource.Current as Versenyzõ; nem story

            if (formAddNew.ShowDialog() == DialogResult.OK) //addig nem enged vissza és mûködnek a gombok <> .Show()
            {
                versenyzõBindingSource.Add(formAddNew.ÚjVersenyzõ);
            }
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            double összeg = 0;
            double összUSA = 0;
            int darab = 0;

            double minimum = double.PositiveInfinity;

            string leggyorsabb = string.Empty;

            foreach (var item in adatok)
            {
                összeg += item.EredmenyPerc;

                if (item.Nemzetiseg == "USA")
                {
                    összUSA += item.EredmenyPerc;
                    darab++;
                }

                if (item.EredmenyPerc < minimum)
                {
                    minimum = item.EredmenyPerc;
                    leggyorsabb = item.Nev;
                }

                //double átlag = összeg / adatok.Count(); //vlm nem mükszik
            }
            double átlag = összeg / adatok.Count(); //vlm nem mükszik megoldás: ide kell tenni. nem foreachen belülre, mert az akkor mndig lefut. itt csak egyszer kell szamolni atlagot

            MessageBox.Show($"A legjobb idõ {minimum}");
        }
    }
}
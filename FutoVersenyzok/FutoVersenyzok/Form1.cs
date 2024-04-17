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
            dataGridView1.DataSource = versenyzõBindingSource;
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
            if (versenyzõBindingSource.Current == null)
            {
                MessageBox.Show("Hiba történt, nincs kijelölt sor!", "Hiba", MessageBoxButtons.OK);
            }

            if (MessageBox.Show("Biztos benne?", "Törlés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                versenyzõBindingSource.RemoveCurrent();
            }
        }

        private void ButtonAddNew_Click(object sender, EventArgs e) //--ÚJSOR
        {
            FormAddNew formAddNew = new FormAddNew();

            if (formAddNew.ShowDialog() == DialogResult.OK) //addig nem enged vissza és mûködnek a gombok <> .Show()
            {

            }
        }
    }
}
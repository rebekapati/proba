using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace FutoVersenyzok
{
    public partial class Form1 : Form
    {
        BindingList<Versenyz�> adatok = new BindingList<Versenyz�>();

        public Form1()
        {
            InitializeComponent();
            versenyz�BindingSource.DataSource = adatok;
            dataGridView1.DataSource = versenyz�BindingSource;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("futoversenyzok.csv");
                CsvReader csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t�mb = csv.GetRecords<Versenyz�>();
                foreach (var item in t�mb)
                {
                    adatok.Add(item);
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    CsvWriter csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(adatok);

                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (versenyz�BindingSource.Current == null)
            {
                MessageBox.Show("Hiba t�rt�nt, nincs kijel�lt sor!", "Hiba", MessageBoxButtons.OK);
            }

            if (MessageBox.Show("Biztos benne?", "T�rl�s", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                versenyz�BindingSource.RemoveCurrent();
            }
        }

        private void ButtonAddNew_Click(object sender, EventArgs e)
        {
            FormAddNew formAddNew = new FormAddNew();

            if (formAddNew.ShowDialog() == DialogResult.OK) //addig nem enged vissza �s m�k�dnek a gombok <> .Show()
            {

            }
        }
    }
}
using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csv_gyak
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryList = new BindingList<CountryData>();
        public Form1()
        {
            InitializeComponent();
            countryDataBindingSource.DataSource = countryList;
            dataGridView1.DataSource = countryDataBindingSource;
            MouseClick += button1_MouseClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("european_countries.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tömb = csv.GetRecords<CountryData>();
            foreach (var item in tömb)
            {
                countryList.Add(item);
            }
        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }

        public partial class FormCountryEdit : Form
        {
            public CountryData CountryData;

            public FormCountryEdit()
            {
                InitializeComponent();
            }

            private void FormCountryEdit_Load(object sender, EventArgs e)
            {
                countryDataBindingSource.DataSource = CountryData;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCountryEdit fce = new FormCountryEdit();
            fce.CountryData = countryDataBindingSource.Current as CountryData;
            fce.Show();
        }
    }
}

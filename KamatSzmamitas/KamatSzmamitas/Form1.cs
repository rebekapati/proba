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
            decimal hitelÖsszeg = decimal.Parse(TextboxHitelösszeg.Text);
            decimal haviKamat = decimal.Parse(textBoxHavikamat.Text);
            decimal haviTörlesztõ = decimal.Parse(comboBoxHavitörlesztõ.Text);

            decimal hátralék = hitelÖsszeg; // nem a hitelösszeg csökken hanem abból a hátralék

            int hónap = 1;
            decimal költség = 0;

            //List<Sor> sorok = new List<Sor>();
            List<ExtraSor> sorok = new List<ExtraSor>();

            while (hátralék > 0)
            {
                hátralék += hátralék * (haviKamat / 100m);
                hátralék -= haviTörlesztõ;
                költség += haviTörlesztõ;

                if (haviTörlesztõ < hátralék * (haviKamat / 100m))
                {
                    MessageBox.Show(":((");
                    break;
                }

                Sor újSor = new Sor();  //objektum: újsor, classban fv.: metódus, konstruktor fv.: azonos néven
                újSor.Hátralék = hátralék;
                újSor.Hónap = hónap;

                //sorok.Add(újSor);
                
                ExtraSor extra = new ExtraSor();
                sorok.Add(ExtraSor);
                extra.Hónap = hónap;
                extra.Hátralék = hátralék;
                extra.KummuláltBefizetés = költség;


                hónap++;
            }

            költség += hátralék;

            dataGridView1.DataSource = sorok;

            MessageBox.Show(költség.ToString());

        }
    }
}
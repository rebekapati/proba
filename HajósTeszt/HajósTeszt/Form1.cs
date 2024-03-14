namespace HajósTeszt
{
    public partial class Form1 : Form
    {
        List<Kérdés> ÖsszesKérdés;
        List<Kérdés> AktuálisKérdések = new List<Kérdés>();
        int AktuálisKérdés = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ÖsszesKérdés = KérdésBetöltés();
            //AktuálisKérdések = new List<Kérdés>()
            for (int i = 0; i < 7; i++)
            {
                AktuálisKérdések.Add(ÖsszesKérdés[0]);
                ÖsszesKérdés.RemoveAt(0);
            }
            dataGridView1.DataSource = AktuálisKérdések;
        }

        List<Kérdés> KérdésBetöltés()
        {
            List<Kérdés> kérdések = new List<Kérdés>();

            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true); //byteordermark-ot figyelembeveszi ha true
            //txt: Copy if newer!
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] tömb = sor.Split("\t");

                if (tömb.Length != 7) continue;

                Kérdés k = new Kérdés();
                k.KérdésSzöveg = tömb[1];
                k.Válasz1 = tömb[2];
                k.Válasz2 = tömb[3];
                k.Válasz3 = tömb[4];
                k.URL = tömb[5];

                int x = 0;
                int.TryParse(tömb[6], out x);
                k.HelyesVálasz = x;

                kérdések.Add(k);
            }
            sr.Close();

            return kérdések;
        }
    }
}
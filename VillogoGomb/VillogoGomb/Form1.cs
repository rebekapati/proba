namespace VillogoGomb
{
    public partial class Form1 : Form
    {
        int méret = 40;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    Probagomb gomb = new Probagomb();
                    gomb.Height = méret;
                    gomb.Width = méret;
                    gomb.Left = oszlop * méret;
                    //ClientRectangle.Width / 2 - méret / 2; //gomb középre, bal felsõ saroktól számítja ezért a kivonás
                    gomb.Top = sor * méret;
                        //ClientRectangle.Height / 2 - méret / 2;
                    //b.Text = ((sor+1) + (oszlop+1)).ToString();
                    Controls.Add(gomb);
                }
            }
        }
    }
}
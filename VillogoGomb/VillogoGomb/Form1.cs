namespace VillogoGomb
{
    public partial class Form1 : Form
    {
        int m�ret = 40;
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
                    gomb.Height = m�ret;
                    gomb.Width = m�ret;
                    gomb.Left = oszlop * m�ret;
                    //ClientRectangle.Width / 2 - m�ret / 2; //gomb k�z�pre, bal fels� sarokt�l sz�m�tja ez�rt a kivon�s
                    gomb.Top = sor * m�ret;
                        //ClientRectangle.Height / 2 - m�ret / 2;
                    //b.Text = ((sor+1) + (oszlop+1)).ToString();
                    Controls.Add(gomb);
                }
            }
        }
    }
}
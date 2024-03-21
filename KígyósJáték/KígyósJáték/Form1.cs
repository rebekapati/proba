namespace KígyósJáték
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100; //utoljára kirakott kígyófej koordinátái

        int irány_x = 1;
        int irány_y = 0; //haladási irány: -1,0,1

        int lépésszám;

        int hossz = 5;

        public Form1()
        {
            InitializeComponent();
            KeyDown += Form1_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            List<KígyóElem> kígyó = new List<KígyóElem>(); //mérgek és almák

            for (int i = 0; i < list.Count; i++)
            {

            }

            foreach (string item in list)
            {

            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésszám++;

            //Fejnövesztés
            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;

            KígyóElem ke = new KígyóElem();
            kígyó.Add(ke); //Amikor új fejet neveztünk a kígyónak, azt beletesszük a `kígyó` listába is ..
            Controls.Add(ke); //.. és az űrlap vezérlőinek a listájába is

            foreach (KígyóElem item in Controls)
            {
                //Ha van már valami ott, ahova az új fejet tenném, vége a játéknak
                if (item.Top == fej_y && item.Left == fej_x)
                {
                    timer1.Enabled = false;
                    return;
                }
            }

            KígyóElem ÚjFej = new KígyóElem();
            ÚjFej.Top = fej_y;
            ÚjFej.Left = fej_x;
            Controls.Add(ÚjFej);

            //másszon a kígyó
            if (Controls.Count > hossz)
            {
                //KígyóElem levágandó = kígyó[0];
                Controls.RemoveAt(0);
            }

            if (lépésszám % 2 == 0)
            {
                ÚjFej.BackColor = Color.Yellow;
            }
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }
    }
}
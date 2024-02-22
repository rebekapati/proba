namespace Pascal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int m = 40;
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < sor + 1; oszlop++)
                {
                    Button button=new Button();
                    button.Width = m;
                    button.Height = m;
                    button.Left = oszlop * m;
                    button.Top = sor * m;
                    int x = Faktori�lis(sor) / (Faktori�lis(oszlop) * Faktori�lis(sor - oszlop));
                    button.Text = x.ToString();

                    Controls.Add(button);
                }
            }
        }

        int Faktori�lis(int n) //ctrl k d > automata form�z�s
        {
            if (n == 0) return 1;
            return n * Faktori�lis(n-1);
        }
    }
}
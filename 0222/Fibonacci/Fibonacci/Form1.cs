namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //design > events > load!
        {
            /*Button név = new Button(); //new()
            név.Text = ":)";
            Controls.Add(név);*/
            //git változtatás próba

            List<Sor> lista = new List<Sor>();

            for (int i = 0; i < 10; i++)
            {
                Button szám = new Button();
                szám.Text = Fibonacci(i).ToString();
                szám.Top = i * 20;
                Controls.Add(szám);
                //---
                Sor újSor = new Sor();
                újSor.Érték = Fibonacci(i);
                újSor.Sorszám = i+1;
                lista.Add(újSor);
            }

            dataGridView1.DataSource = lista;
        }

        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);

        }

    }
}
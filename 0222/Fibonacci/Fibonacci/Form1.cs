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
            /*Button n�v = new Button(); //new()
            n�v.Text = ":)";
            Controls.Add(n�v);*/
            //git v�ltoztat�s pr�ba

            List<Sor> lista = new List<Sor>();

            for (int i = 0; i < 10; i++)
            {
                Button sz�m = new Button();
                sz�m.Text = Fibonacci(i).ToString();
                sz�m.Top = i * 20;
                Controls.Add(sz�m);
                //---
                Sor �jSor = new Sor();
                �jSor.�rt�k = Fibonacci(i);
                �jSor.Sorsz�m = i+1;
                lista.Add(�jSor);
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
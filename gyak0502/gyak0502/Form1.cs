namespace gyak0502
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            //vonalas objektum: sz�n, vastags�g
            Pen pen = new Pen(Color.Fuchsia, 1);
            //kit�lt�tt  obj
            Brush brush = new SolidBrush(Color.Fuchsia);

            //rajz
            g.DrawEllipse(pen, 0, 0, 100, 100);
        }
    }
}
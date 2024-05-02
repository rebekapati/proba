using csillagterkep.Models;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace csillagterkep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            hajosContext context = new hajosContext();
            var stars = (from s in context.StarData select new { s.Hip, s.X, s.Y, s.Magnitude }).ToList();

            Graphics g = this.CreateGraphics();

            g.Clear(Color.DarkSlateBlue);
            Color c = Color.LightGoldenrodYellow;

            double nagyítás = 300;
            float cx = ClientRectangle.Width / 2;
            float cy = ClientRectangle.Height / 2;

            Pen pen = new Pen(c, 1);
            Brush brush = new SolidBrush(c);

            foreach (var star in stars)
            {
                if (star.Magnitude > 6)
                {
                    continue;
                }

                if (Math.Sqrt(Math.Pow(star.X,2)+Math.Pow(star.Y,2))>1) //egységsugarú körön belül van-e
                {
                    continue;
                }

                //Rajzolás
                float x = (float)(star.X * nagyítás + cx);
                float y = (float)(star.Y * nagyítás + cy);
                double size = 20 * Math.Pow(10, star.Magnitude / -2.5);

                g.FillEllipse(brush, x, y, (float)size,(float)size);
            }

            var lines = context.ConstellationLines.ToList(); //memóriába kerülnek a conline-ok listába

            foreach (var line in lines)
            {
                var star1 = (from s in stars
                             where s.Hip == line.Star1
                             select s).FirstOrDefault(); //a star1 innentõl egy csillag vagy semmi
                var star2 = (from s in stars
                             where s.Hip == line.Star2
                             select s).FirstOrDefault();

                if (star1 == null || star2 == null)
                {
                    continue;
                }

                float x1 = (float)(star1.X * nagyítás + cx);
                float y1 = (float)(star1.Y * nagyítás + cy);

                float x2 = (float)(star2.X * nagyítás + cx);
                float y2 = (float)(star2.Y * nagyítás + cy);

                g.DrawLine(pen, x1, y1, x2, y2);
            }
        }
    }
}
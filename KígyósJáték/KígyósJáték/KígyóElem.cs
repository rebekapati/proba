using Accessibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KígyósJáték
{
    internal class KígyóElem : PictureBox
    {
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        public static int Méret = 20;

        public KígyóElem()
        {
            Width = KígyóElem.Méret;
            Height = KígyóElem.Méret;
            BackColor = Color.Fuchsia;

            t.Tick += T_Tick;
        }

        private void T_Tick(object? sender, EventArgs e)
        {
            BackColor = SystemColors.ButtonFace;
            t.Stop();
        }
    }
}

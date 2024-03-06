using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class Probagomb :Button
    {
        int szám = 0;
        public Probagomb()
        {
            BackColor = Color.White;
            Text = szám.ToString();
            MouseEnter += Probagomb_MouseEnter;
        }

        private void Probagomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Purple;
            szám++;
            Text = szám.ToString();
        }
    }
}

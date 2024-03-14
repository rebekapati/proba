using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajósTeszt
{
    internal class VálaszGomb : TextBox //magától tördeli a sorokat, nem kell manuálisan
    {
        public VálaszGomb()
        {
            ReadOnly = true; //csak olvasható lesz a tartalma
            BackColor = Color.Gray;
            BorderStyle = BorderStyle.None;
            Multiline = true; //több soros
            Height = 70;
            Width = 300;
            Left = 20;
        }
    }
}

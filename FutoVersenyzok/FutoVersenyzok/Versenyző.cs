using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutoVersenyzok
{
    public class Versenyző //public!!!
    {
        //VersenyzoID,Nev,Nemzetiseg,EredmenyPerc,Kategoria

        public int VersenyzoID { get; set; }
        public string Nev { get; set; } = string.Empty; //megszűnik a zöld aláhúzás
        public string Nemzetiseg { get; set; } = string.Empty; // a string olyan mint az aloevera: mindenre is jó
        public double EredmenyPerc { get; set; }
        public string Kategoria { get; set; } = string.Empty;

    }
}

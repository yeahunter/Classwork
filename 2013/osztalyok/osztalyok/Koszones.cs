using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztalyok
{
    class Koszones
    {
        public string valami = "egy string";
        int ertek = 87;

        public string Koszonj(string nev)
        {
            return "Szia " + nev;
        }

        public string Koszonj(string nev, int eletkor)
        {
            if (eletkor < 20)
                return "Szia " + nev;
            if (eletkor < 30)
                return "Szevasz " + nev;
            return "Jó napot " + nev;
        }
    }
}

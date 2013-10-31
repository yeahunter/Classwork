using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztalyok
{
    class Kor
    {
        double x, y, sugar;

        public Kor(int x, int y, double sugar)
        {
            this.x = x;
            this.y = y;
            this.sugar = sugar;
        }

        public Kor(double sugar)
        {
            Random r = new Random();
            x = r.Next(100);
            y = r.Next(100);
            this.sugar = sugar;
        }

        public Kor()
        {
            Random r = new Random();
            x = r.Next(100);
            y = r.Next(100);
            sugar = r.Next(50);
        }

        public bool Bennevan(double x2, double y2)
        {
            double nsugar = Mekkoratavolsagravan(x2, y2);
            if (nsugar > sugar)
                return false;
            else
                return true;
        }

        public double Mekkoratavolsagravan(double x, double y)
        {
            double nsugar = Math.Sqrt(Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2));
            return nsugar;
        }

        public double Loves(double x, double y)
        {
            double pontszam = sugar - Mekkoratavolsagravan(x, y);
            if (pontszam < 0)
                pontszam = 0;
            return pontszam;
        }
        
    }
}

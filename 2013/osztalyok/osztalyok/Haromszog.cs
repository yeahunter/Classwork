using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztalyok
{
    class Haromszog
    {
        double a, b, c;

        double terulet, kerulet;
        bool megszerkeszthetoe;

        public double Terulet
        {
            get
            {
                return terulet;
            }
        }

        public double Kerulet
        {
            get
            {
                return kerulet;
            }
        }

        public bool Megszerkeszthetoe
        {
            get
            {
                return megszerkeszthetoe;
            }
        }

        public Haromszog(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            FKerulet();
            FTerulet();
            FMegszerkeszthetoe();
        }

        double FTerulet()
        {
            terulet = (kerulet/2) * ((kerulet/2) - a) * ((kerulet/2) - b) * ((kerulet/2) - c);
            return terulet;
        }
        double FKerulet()
        {
            kerulet = a + b + c;
            return kerulet;
        }
        bool FMegszerkeszthetoe()
        {
            if (a + b < c || a + c < b || b + c < a)
                megszerkeszthetoe = false;
            else
                megszerkeszthetoe = true;
            return megszerkeszthetoe;
        }
    }
}

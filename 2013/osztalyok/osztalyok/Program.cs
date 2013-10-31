using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztalyok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Haromszog hszog = new Haromszog(2.0, 3.0, 4.0);
            //if (hszog.Megszerkeszthetoe)
            //{
            //    Console.WriteLine(hszog.Kerulet);
            //    Console.WriteLine(hszog.Terulet);
            //}
            //else
            //    Console.WriteLine("Nem megszerkesztheto a haromszog");

            //Kor k = new Kor(0, 0, 5.0);

            //Console.Write("Adja meg az x koordinátát: ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("Adja meg az y koordinátát: ");
            //double y = double.Parse(Console.ReadLine());
            //if (k.Bennevan(x, y))
            //    Console.WriteLine("Benne van!");
            //else
            //    Console.WriteLine("Nincs benne!");

            Kor k = new Kor(5.0);

            double x, y, tavolsag;

            int pont, osszpont = 0;

            for (int i = 0; i < 15; i++)
            {
                Console.Write("Adja meg az x koordinátát: ");
                x = double.Parse(Console.ReadLine());
                Console.Write("Adja meg az y koordinátát: ");
                y = double.Parse(Console.ReadLine());

                pont = (int)k.Loves(x, y);
                osszpont += pont;
                tavolsag = k.Mekkoratavolsagravan(x, y);

                Console.WriteLine("Pontszám: {0} | Összpont: {1} | Távolság: {2}", pont, osszpont, tavolsag);
            }

            Console.ReadLine();
        }
    }
}

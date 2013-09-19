using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20130919
{
    class Program
    {
        static void Main(string[] args)
        {
            #region elso feladat
            Console.Write("Neved: ");
            string nev = Console.ReadLine();
            Console.Write("Korod: ");
            int eletkor = Int16.Parse(Console.ReadLine());
            if (eletkor > 30)
                Console.WriteLine("Üdvözlöm");
            else if (eletkor <= 30 && eletkor > 20)
                Console.WriteLine("Szevasz");
            else
                Console.WriteLine("Szia {0}\nFiatal vagy!", nev);
            if (nev == "Béla" && nev == "Béci" && nev == "Bélus")
                Console.WriteLine("Tartozol te Béla");
            int temp = 1;
            while (temp <= eletkor)
            {
                Console.WriteLine("Boldog {0}. szülinapot!", temp);
                temp++;
            }
            #endregion

            #region masodik feladat
            Console.Write("Neved: ");
            string nev = Console.ReadLine();

            switch (nev)
            {
                case "Maldini":
                    Console.WriteLine("Chiao Paulo!");
                    break;
                case "Messi":
                    Console.WriteLine("Hi Lionel!");
                    break;
                default:
                    Console.WriteLine("Hello Wayne!");
                    break;
            }
            #endregion

            #region harmadik feladat
            Random r = new Random();
            int titkos = r.Next(100);

            int tipp = -1;
            int tippszam = 0;
            while (tipp != titkos)
            {
                Console.Write("Mi a tipp?");
                tipp = int.Parse(Console.ReadLine());
                tippszam++;
                if (tipp > titkos)
                    Console.WriteLine("A gondolt szám kisebb!");

            }
            #endregion

            #region negyedik feladat
            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Művelet: ");
            string muveletjel = Console.ReadLine();
            int o = 0;
            switch (muveletjel)
            {
                case "+":
                    o = a + b;
                    break;
                case "-":
                    o = a - b;
                    break;
                case "*":
                    o = a * b;
                    break;
                case "/":
                    o = a / b;
                    break;
            }
            Console.WriteLine("{0}{3}{1}={2}", a, b, o, muveletjel);
            #endregion
        }
    }
}

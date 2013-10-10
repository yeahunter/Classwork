using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] nagytomb = new string[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    nagytomb[i, j] = "-";
                }
            }
            Random r = new Random();
            int r1 = r.Next(1, 8);
            int r2 = r.Next(1, 8);
            nagytomb[r1, r2] = "+";
            nagytomb[r1-1, r2] = "+";
            nagytomb[r1+1, r2] = "+";
            nagytomb[r1, r2+1] = "+";
            nagytomb[r1, r2-1] = "+";

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(nagytomb[i, j]);
                }
                Console.WriteLine();
            }

            int probalkozas = 0;
            int talalat = 0;

            while (probalkozas < 20 && talalat < 5)
            {
                Console.Write("Lövés x? ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Lövés y? ");
                int y = int.Parse(Console.ReadLine());

                if (nagytomb[x, y] == "+")
                {
                    Console.WriteLine("Találat");
                    talalat++;
                }
                else
                    Console.WriteLine("Nincs találat!");

                probalkozas++;
            }
            Console.WriteLine("Vége");
        }
    }
}

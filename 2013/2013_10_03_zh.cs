using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bekertek = new int[3];
            for (int i = 0; i < bekertek.Length; i++)
            {
                Console.Write("Kérem a {0} elemet: ", i + 1);
                bekertek[i] = int.Parse(Console.ReadLine());
            }

            int[] tomb = new int[20];

            for (int i = 0; i < tomb.Length; i++)
			{
                if (i < bekertek.Length)
                    tomb[i] = bekertek[i];
                else
                    tomb[i] = tomb[i - 3] + tomb[i - 2] + tomb[i - 1];
			}

            int tombosszesen = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine("{0} elem: {1}", i + 1, tomb[i]);
                tombosszesen += tomb[i];
            }
            Console.WriteLine("Összesen: {0}", tombosszesen);
        }
    }
}

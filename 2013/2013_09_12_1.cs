using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlofeladat1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("A oldal hossza: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("B oldal hossza: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Kerület: {0} | Terület: {1}", a + b * 2, a * b);
        }
    }
}

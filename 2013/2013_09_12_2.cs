using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homerseklet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a fokot: ");
            int fok = int.Parse(Console.ReadLine()) * 9/5 + 32;

            Console.WriteLine("Ez ennyi fahrenheitben: {0}", fok);

        }
    }
}

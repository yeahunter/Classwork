using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1
{
    class Program
    {
        static void Main(string[] args)
        {
            int elsojatekospont = 0;
            int masodikjatekospont = 0;
            while (masodikjatekospont < 5 && elsojatekospont < 5)
            {
                Console.Write("1. játékos: ");
                string elsojatekoskulcsszo = Console.ReadLine();
                Console.Write("2. játékos: ");
                string masodikjatekoskulcsszo = Console.ReadLine();

                switch (elsojatekoskulcsszo)
                {
                    case "olló":
                        if (elsojatekoskulcsszo == masodikjatekoskulcsszo)
                            Console.WriteLine("Döntetlen");
                        else if (masodikjatekoskulcsszo == "papír")
                        {
                            elsojatekospont++;
                            Console.WriteLine("1. játékos nyert a kört | {0}-{1}", elsojatekospont, masodikjatekospont);
                        }
                        else if (masodikjatekoskulcsszo == "kő")
                        {
                            masodikjatekospont++;
                            Console.WriteLine("2. játékos nyert a kört | {0}-{1}", elsojatekospont, masodikjatekospont);
                        }
                        break;
                    case "kő":
                        if (elsojatekoskulcsszo == masodikjatekoskulcsszo)
                            Console.WriteLine("Döntetlen");
                        else if (masodikjatekoskulcsszo == "olló")
                        {
                            elsojatekospont++;
                            Console.WriteLine("1. játékos nyert a kört | {0}-{1}", elsojatekospont, masodikjatekospont);
                        }
                        else if (masodikjatekoskulcsszo == "papír")
                        {
                            masodikjatekospont++;
                            Console.WriteLine("2. játékos nyert a kört | {0}-{1}", elsojatekospont, masodikjatekospont);
                        }
                        break;
                    case "papír":
                        if (elsojatekoskulcsszo == masodikjatekoskulcsszo)
                            Console.WriteLine("Döntetlen");
                        else if (masodikjatekoskulcsszo == "kő")
                        {
                            elsojatekospont++;
                            Console.WriteLine("1. játékos nyert a kört | {0}-{1}", elsojatekospont, masodikjatekospont);
                        }
                        else if (masodikjatekoskulcsszo == "olló")
                        {
                            masodikjatekospont++;
                            Console.WriteLine("2. játékos nyert a kört | {0}-{1}", elsojatekospont, masodikjatekospont);
                        }
                        break;
                }
                
            }
            Console.WriteLine("1. játékos pontjai: {0} | 2. játékos pontjai: {1}", elsojatekospont, masodikjatekospont);
            
        }
    }
}

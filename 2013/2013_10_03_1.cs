using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sziget
{
    class Program
    {
        static void Main(string[] args)
        {
            int meresekSzama = 10;
            int[] magassagok = new int[meresekSzama];
            Random r = new Random();
            Console.Write("2. feladat: ");
            for (int i = 0; i < meresekSzama; i++)
            {
                bool tenger = r.Next(100) < 60;
                if (tenger)
                    magassagok[i] = 0;
                else
                    magassagok[i] = r.Next(1, 10);
                Console.Write("{0} ", magassagok[i]);
            }
            Console.WriteLine();
            int maxhely = 0;
            int hanymax = 0;
            holamax(magassagok, ref maxhely);
            hanyamax(magassagok, maxhely, ref hanymax);
            legmagasabbszigetszakasz(magassagok);
            leghosszabbszigetszakasz(magassagok);
        }

        static void holamax(int[] tomb, ref int maxhely)
        {
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[maxhely] < tomb[i])
                    maxhely = i;
            }
            Console.WriteLine("3. feladat: {0}. elem értéke: {1}", maxhely, tomb[maxhely]);
        }

        static void hanyamax(int[] tomb, int maxhely, ref int hanymax)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[maxhely] == tomb[i])
                    hanymax++;
            }
            Console.WriteLine("4. feladat: A {0} érték, {1}x fordul elő", tomb[maxhely], hanymax);
        }

        static void legmagasabbszigetszakasz(int[] tomb)
        {
            int ertek = 0;
            int legmagasabbszakasz = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (i != tomb.Length - 1)
                {
                    if (tomb[i] > 0 && tomb[i + 1] > 0)
                        ertek += tomb[i];
                    else if (tomb[i] > 0 && ertek > 0)
                        ertek += tomb[i];

                    else
                        ertek = 0;
                }
                else if (tomb[i] > 0 && ertek > 0)
                {
                    ertek += tomb[i];
                }
                else
                    ertek = 0;

                if (legmagasabbszakasz < ertek)
                    legmagasabbszakasz = ertek;
            }
            Console.WriteLine("5. feladat: legmagasabb szigetszakasz: {0} (ez itt majdnem az 5. feladat)", legmagasabbszakasz);
        }

        static void leghosszabbszigetszakasz(int[] tomb)
        {
            int maxmagassag = 0;
            int maxhosszusag = 0;
            int temp = 0;
            int hanysziget = 0;
            bool sziget = false;
            bool szigetszakasz = false;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] != 0 && !sziget)
                {
                    sziget = true;
                    temp = tomb[i];
                    hanysziget++;
                }
                else if (tomb[i] != 0 && sziget)
                {
                    szigetszakasz = true;
                    temp += tomb[i];
                    hanysziget++;
                }
                else if (tomb[i] == 0)
                {
                    szigetszakasz = false;
                    sziget = false;
                    temp = 0;
                    hanysziget = 0;
                }
                if (szigetszakasz && maxmagassag < temp)
                    maxmagassag = temp;
                if (szigetszakasz && maxhosszusag < hanysziget)
                    maxhosszusag = hanysziget;
            }
            Console.WriteLine("5. feladat: legmagasabb szigetszakasz: {0} (ez megint nem volt feladat, de most má mindegy)", maxmagassag);
            Console.WriteLine("5. feladat: leghosszabb szigetszakasz: {0}", maxhosszusag);
        }

    }
}

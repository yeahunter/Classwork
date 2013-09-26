using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematika1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. feladat
            Console.Write("Kérem a számot:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(a));
            #endregion

            #region 2. feladat
            Console.Write("Kérem a számot:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Pow(b, 0.2));
            #endregion

            #region 3. feladat
            int[] szamok = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] ujszamok = new int[10];

            ujszamok[4] = 33;
            #endregion

            #region 4. feladat (kicsit egyszerubben)
            int osszeg = 0;

            for (int i = 1; i <= 100; i++)
            {
               osszeg += i;
            }

            Console.WriteLine(osszeg);
            #endregion

            #region 4. feladat
            int[] szamok = new int[100];
            int osszeg = 0;

            for (int i = 1; i <= szamok.Length; i++)
            {
               szamok[i-1] = i;
            }

            for (int i = 0; i < szamok.Length; i++)
            {
               osszeg += szamok[i];
            }

            Console.WriteLine(osszeg);
            #endregion

            #region 5. feladat
            int[] honapoknapjai = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.Write("Hónap: ");
            int honap = int.Parse(Console.ReadLine());
            Console.Write("Nap: ");
            int nap = int.Parse(Console.ReadLine());

            int evnapja = 0;
            for (int i = 0; i < honap - 1; i++)
            {
               evnapja += honapoknapjai[i];
            }
            evnapja += nap;

            Console.WriteLine(evnapja);
            #endregion

            #region 6. feladat fugg az 5. feladattol
            string[] honapoknevei = { "január", "február", "március", "április", "május", "június", "július", "augusztus", "szeptember", "október", "november", "december"};
            Console.Write("Hányadik nap: ");
            int evnapja2 = int.Parse(Console.ReadLine());
            int honap2 = 0;
            int nap2 = 0;

            while (evnapja2 > honapoknapjai[honap2])
            {
               evnapja2 -= honapoknapjai[honap2];
               honap2++;
            }
            nap2 = evnapja2;

            Console.WriteLine("Hónap: {0}, nap: {1}", honapoknevei[honap2], nap2);
            #endregion

            #region 7. feladat
            int[,] zhk = { { 5, 0, 0, 0 }, { 5, 4, 3, 2 }, { 0, 1, 2, 3 }, { 5, 5, 5, 5 } };
            int[,] eredmenyek = new int[24, 4];

            eredmenyek[23, 0] = 5;

            Console.WriteLine(zhk[1, 1]);
            #endregion

            #region 8. feladat

            #endregion

            #region 9. feladat
            int[,] t = new int [6,3];

            Random r = new Random();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    t[i, j] = r.Next(1, 50);
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(t[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(t[j, i] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}

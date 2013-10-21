using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH4
{
    class Program
    {
        static string atalakit(string szoveg)
        {
            string[] szavak = szoveg.Split(' ');
            string modosultszavak = "";
            for (int i = 0; i < szavak.Length; i++)
            {
                if (szavak[i].Length < 4)
                    modosultszavak += szavak[i].ToUpper();
                else
                    modosultszavak += szavak[i];
                modosultszavak += " ";
            }
            return modosultszavak;
        }
        static void Main(string[] args)
        {
            string szoveg = Console.ReadLine();
            Console.Write(atalakit(szoveg));
        }
    }
}

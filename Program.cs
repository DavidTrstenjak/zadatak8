using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj1 = 0;
            int broj2 = 1;
            int fBroj = 0;
            int n;

            Console.WriteLine("Upišite broj n:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                fBroj = broj1 + broj2;

                broj1 = broj2;
                broj2 = fBroj;
            }

            Console.WriteLine(fBroj);

            Console.ReadKey();
        }
    }
}

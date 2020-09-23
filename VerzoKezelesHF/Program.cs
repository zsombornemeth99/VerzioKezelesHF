using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzoKezelesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Kérem adja meg a(z) {0}. számot: ", i + 1);
                int szam = int.Parse(Console.ReadLine());
                sum += szam;
            }

            Console.WriteLine("A számok átlaga: " + sum / 10);

            Console.ReadKey();
        }
    }
}

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
            var szamok = new List<int>();
            
            Console.Write("Kérem adja meg hány szám átlagát szeretné megadni: ");
            int N = int.Parse(Console.ReadLine());
            Console.Clear();

            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                Console.Write("Kérem adja meg a(z) {0}. számot: ", i + 1);
                int szam = int.Parse(Console.ReadLine());
                sum += szam;
                szamok.Add(szam);
            }

            Console.WriteLine("A számok átlaga: " + sum / N);
            szamok.Sort();
            Console.WriteLine("A legkisebb szám: {0}\n" +
                "A legnagyobb: {1} ",szamok[0],szamok[szamok.Count-1]);

            Console.ReadKey();
        }
    }
}

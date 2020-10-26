using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varijable1
{
    class Program
    {
        static void Main(string[] args)
        {
            int zbrojOcjena = 0;
            int brOcjena = 0;

            int[] parametri = zbrojiOcjene(zbrojOcjena, brOcjena);

            Console.Write($"Vas prosjek je {prosjek(parametri)}");

            Console.ReadKey();


        }

        static int[] zbrojiOcjene(int zbOcj, int brOcj)
        {
            int ocjena;
            do
            {
                Console.Write("Unesite broj: ");
                ocjena = int.Parse(Console.ReadLine());
                if (ocjena > 5 || ocjena <= 0)
                {
                    Console.WriteLine("Unesite ocjenu od 1 do 5.");
                    continue;
                }
                else
                {
                    zbOcj += ocjena;
                    brOcj++;
                }
            }
            while (ocjena != 0);
            
            int[] result = { zbOcj, brOcj };
            return result;
        }

        static float prosjek(int[] parametri)
        {
            return (float)parametri[0] / (float)parametri[1];
        }

    }
}

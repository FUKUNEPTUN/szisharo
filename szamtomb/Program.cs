using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamtomb
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1000,
                max = -1,
                minIdx,
                maxIdx;
            int[] szam = new int[1000];
            Random rna = new Random();

            for(int i = 0; i <= 99; i++)
            {
                szam[i] = rna.Next(0, 1001);
            }
            for(int i = 0; i <=99; i++)
            {
                if (szam[i] < min)
                {
                    min = szam[i];
                    minIdx = i;
                }
                if (szam[i] > max)
                {
                    max = szam[i];
                    maxIdx = i;
                }
            }

            Console.WriteLine(" értéke ", min, " Legnagobb érték ", max);
            Console.ReadKey();
            
        }
    }
}

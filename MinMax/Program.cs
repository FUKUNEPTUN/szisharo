using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minmaxvalaszto
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1000; // Minimum megadása
            int max = 0; // Maximum megadása
            int minInd = 0; // A kiválasztott minimum indexe
            int maxInd = 0; // A kiválasztott maximum indexe
            int i; // A tömb egy pillanatnyi indexe

            int[] tomb = new int[100]; // Tömb meghatározása és a terület lefoglalása neki
            Random veletlen = new Random(); // Random generálás

            for (i = 0; i < tomb.Length; i++) // Végigmegy a tömb indexein miközben feltölti azokat
            {
                tomb[i] = veletlen.Next(0, 10000); // Random generálás megadott tartományok között
            }
            for (i = 0; i < tomb.Length; i++) // Végigmegy a tömb elemein a megadott határig (i < 50 => 50 elemen)
            {
                //Console.WriteLine(tomb[i]);
                if (tomb[i] < min)
                {
                    min = tomb[i];
                    minInd = i;
                }
                else if (tomb[i] > max)
                {
                    max = tomb[i];
                    maxInd = i;
                }
            }
            Console.WriteLine("A minimum szám: {0}, helye: {1}", min, minInd);
            Console.WriteLine("A maximum szám: {0}, helye: {1}", max, maxInd);
            Console.ReadKey();
        }
    }
}

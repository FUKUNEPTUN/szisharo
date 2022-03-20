using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atlagho
{
    class Program
    {
        static void Main(string[] args)
        {
            //Változók deklarálása
            int minHo = 0,
                maxHo = 0,
                leghHonap = 0,
                legmHonap = 0,
                alsoHatar = -10,
                felsoHatar = 30,
                i = 0,
                j = 0;
            int[,] homerseklet = new int[12, 30];
            string[] honapok = new string[] { "Január", "Február", "Március", "Április", "Május", "Június", "Július", "Augusztus", "Szeptember", "Október", "November", "December" };


            // Tömb feltöltése
            Random rnd = new Random();

            // Min és max kiválasztás
            for (i = 0; i < homerseklet.GetLength(0); i++)
            {
                for (j = 0; j < homerseklet.GetLength(1); j++)
                {
                    homerseklet[i, j] = rnd.Next(alsoHatar, felsoHatar);
                }
            }

            for (int x = 0; x < homerseklet.GetLength(0); x++) 
            {
                for (int y = 0; y < homerseklet.GetLength(1); y++)
                {
                    if (homerseklet[x, y] < minHo)
                    {
                        minHo = homerseklet[x, y];
                        leghHonap = x;
                    }
                    else if (homerseklet[x, y] > maxHo)
                    {
                        maxHo = homerseklet[x, y];
                        legmHonap = x;
                    }
                }
            }

            for (i = 0; i < homerseklet.GetLength(0); i++)
            {
                Console.Write("{0}: ", honapok[i]);
                for (j = 0; j < homerseklet.GetLength(1); j++)
                {
                    Console.Write(homerseklet[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("A legmagasabb hőmérséklet: {0}", maxHo);
            Console.WriteLine("A legkisebb hőmérséklet: {0}", minHo);
            Console.WriteLine("A legmelegebb hónap: {0}", honapok[legmHonap]);
            Console.WriteLine("A leghidegebb hónap: {0}", honapok[leghHonap]);
            Console.ReadKey();
        }
    }
}
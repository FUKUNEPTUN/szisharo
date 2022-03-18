using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* A és B típusú egész tömböket kell létrehozni.
 Ezen tömbök elemeinek számát a felhasználó adja meg; ez 200-nál nagyobb nem lehet!
 Amennyiben nagyobb abban az esetben a program generál egy számot 100 és 200 között és ez lesz az elemek száma.
 A tömbök elemeinek értéke a [-100, 100] intervallumon kell, hogy szerepeljen! (random generált számok)

 Metódusok:
 Unió
 Metszet
 A-B halmaz
 B-A halmaz*/
namespace halmaz
{
    class halmazok
    {
        public halmazok() { }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hány elem szerepeljen?");
            int szam = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[] a;
            int[] b;
            int[] metszet;
            int[] aUnio;
            int[] bUnio;

            if (szam <200)
            {
                 a = new int[szam];
                 b = new int[szam];
                for (int i = 0; i < szam; i++)
                {
                    a[i] = rnd.Next(1, 200);
                    b[i] = rnd.Next(1, 200);
                 /* Console.WriteLine("A tömb: {0} /// B tömb {1}", a[i], b[i]);      */

                }
            }


            else
            {
                szam = rnd.Next(100, 200);
                 a = new int[szam];
                 b = new int[szam];
                for (int i = 0; i < szam; i++)
                {
                    a[i] = rnd.Next(1, 200);
                    b[i] = rnd.Next(1, 200);
                 /* Console.WriteLine("index {0}", i);
                    Console.WriteLine("A tömb: {0} /// B tömb {1}", a[i], b[i]); */
                }
            }



            for (int i = 0; i < szam;i++)
            {
                for (int j = 0; j < szam; j++)
                {
                    if (a[i] == b[j])
                    {
                        metszet = new int[a[i]];
                        Console.WriteLine("közös elem {0}", metszet[i]);
                    }
                    else
                    {
                        aUnio = new int[a[i]];
                        
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(" p o r m e u o t ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

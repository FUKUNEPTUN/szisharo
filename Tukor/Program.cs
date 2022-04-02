using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tukor
{
    class Tukor
    {
        string a;
        char[] b, a2;
        int b2;
        public Tukor() { }
        public void szelet()
        {
            Console.WriteLine("add meg a szöveget, számot");
            a = Console.ReadLine(); //beolvasunk
            Console.Clear();
            a2 = a.ToCharArray(); //az egészet egy char stingben eltároljuk
            string charsStr = new string(a2);
            Console.WriteLine("Középre tükrözött szöveged így néz ki:");
            if (a.Count() % 2 == 0) //ha páros szambol áll, akkor egyszerű a dolog
            {
                
                b2 = a.Count() / 2; //megszámoljuk a karaktereket és egy változóba eltesszük a felét
                b = new char[b2]; // generálunk egy char tömböt a kapott hosszal
                for (int i = 0; i < b2; i++)
                {
                    b[i] = a2[i]; //feltöltjük
                    Console.Write(b[i]);
                }
                Array.Reverse(b); //a tömböt megfordítjuk
                for (int i = 0; i < b.Length; i++)
                {
                    Console.Write("{0}", b[i]);
                }
                Console.WriteLine(" ");
                Console.WriteLine("Páros számú karaktert adtál meg    |||    karaketerek száma:  {0}  volt", a.Count());
            }
            else
            {
                
                b2 = (a.Count()-1)/2; //mivel páratlan ezért elveszünk belőle 1et, hogy páros legyen, aztán felezhetünk
                b = new char[b2];// generálunk egy char tömböt a kapott hosszal
                for (int i = 0; i < b2; i++)
                {
                    b[i] = a2[i];
                    Console.Write("{0}",b[i]); //kiírjuk az első felét a tükrözött szövegnek
                }
                Console.Write(a2[b2]); //a közepső értékét
                Array.Reverse(b);
                for (int i = 0; i < b.Length; i++)
                {
                    Console.Write("{0}", b[i]); // majd a végét is. 
                }
                Console.WriteLine("Páratlan számú karaktert adtál meg    |||    karaketerek száma:  {0}", a.Count());
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        { 
            Tukor tej = new Tukor();
            tej.szelet();
            Console.ReadLine();
        }
    }
}

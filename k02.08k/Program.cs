using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k02._08k
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üdvözöllek a Kő, Papír, Olló mini-gameben. A feladod az, hogy megadd a te választásod. Írj K betűt, ha kő; P betűt, a papírért; O betűt, ha ollót választod. Ügyelj, hogy nagy betuket használj!");
            Random rnd = new Random();
            string f = "";
            string g;
            string p;
            int ered_1 = 0;
            int ered_2 = 0;
            while (f != "x")
            {
                p = Console.ReadLine();
                switch(rnd.Next(0, 3))
                {
                    case 0:
                         g = "K";
                        break;
                    case 3:
                         g = "O";
                        break;
                    case 2:
                         g ="P";
                        break;   
                }
                if (g == "K" && p == "O" || g == "P" && p == "K" || g == "O" && p == "P")
                {
                    Console.WriteLine("A gép nyert");
                    ered_1++;
                }
                else if(g == p)
                {
                    Console.WriteLine("Döntetlen");
                    
                }
                else
                {
                    Console.WriteLine("Te nyertél gratulálok");
                    ered_2++;
                }
                Console.WriteLine("Ha kiszeretnél lépni írj x-et");
                f = Console.ReadLine();
            }
            Console.WriteLine("A játék véget ért. Eredmény: \nSzámítógép: {0}\nJátékos:{1}", ered_1, ered_2);
        }
    }
}

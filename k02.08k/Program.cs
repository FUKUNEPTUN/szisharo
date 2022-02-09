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
            string g = "";
            string p;
            int ered_1 = 0;
            int ered_2 = 0; //deklarálom a változókat, illetve randomot pédányosítom
            while (f != "n")
            { //while ciklusba tettem, mivel a feladat kérte, hogy addig fusson amíg a játékos ki nem szeretne lépni
                p = Console.ReadLine();
                switch(rnd.Next(0, 3))
                { // switch feltételében legenerálom a 0-1-2 számot és a case-ekben számoknak megfelelően a számítógép változójához adom a K/O/P stringeket
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
                if (g == "K" && p == "O" || g == "P" && p == "K" || g == "O" && p == "P") //elsőnek if-el összehasonlítom a számítógép válaszát a játékos válaszával
                {
                    Console.WriteLine("A gép nyert");ered_1++;//ha igaz, akkor a gép eredményéhez hozzá adok 1et
                }
                else if(g == p) //ha megegyezik a 2 string akkor döntetlen
                {
                    Console.WriteLine("Döntetlen");
                    
                }
                else //illetve minden más esetben a játékos nyert és megnöveltem az ő eredményét
                {
                    Console.WriteLine("Te nyertél gratulálok");ered_2++;
                }
                Console.WriteLine("Szeretnél még játszani? Igen= i; Nem = n."); f = Console.ReadLine(); //felajánlom a játékosnak hogy ki tud lépni ha szeretne. Itt csak az n betű a büvösszám, igazából bármilyen másik karaktert kap továbbmegy.
                Console.WriteLine("Add meg a következő tipped");
            }
            Console.WriteLine("A játék véget ért. Eredmény: \nSzámítógép: {0}\nJátékos:{1}", ered_1, ered_2); //végezetül kiírom végeredményt, illetve hogy a játék végetért.
        }
    }
}

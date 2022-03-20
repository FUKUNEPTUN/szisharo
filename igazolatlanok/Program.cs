using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hianyzasok
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók deklarálása
            int igazolatlan,
                magatartasjegy = 0;
            DateTime szuletesidatum;
            int[] buntetesmertek = new int[] { 1, 2, 3, 4, 5 };
            string[] buntetes = new string[] { "Figyelmeztetést kaptál!", "Osztályfőnöki intőt kaptál!", "Igazgatói megrovást kaptál!", "Felfüggesztésben részesültél!", "Nincs figyelmeztetésed!" };
            string figyelmeztetes = "";

            Console.WriteLine("Kérem adja meg a tanuló hiányzásainak számát!");
            igazolatlan = int.Parse(Console.ReadLine());

            if (igazolatlan < 3)
            {
                magatartasjegy = buntetesmertek[4];
                figyelmeztetes = buntetes[4];
            }
            else if (igazolatlan < 5)
            {
                magatartasjegy = buntetesmertek[3];
                figyelmeztetes = buntetes[4];
            }
            else if (igazolatlan < 6)
            {
                magatartasjegy = buntetesmertek[2];
                figyelmeztetes = buntetes[4];
            }
            else if (igazolatlan < 8)
            {
                magatartasjegy = buntetesmertek[1];
            }
            else if (igazolatlan < 10)
            {
                magatartasjegy = buntetesmertek[0];
                figyelmeztetes = buntetes[4];
            }
            else if (igazolatlan >= 10 && igazolatlan < 20)
            {
                magatartasjegy = buntetesmertek[0];
                figyelmeztetes = buntetes[0];
            }
            else if (igazolatlan >= 20 && igazolatlan < 30)
            {
                magatartasjegy = buntetesmertek[0];
                figyelmeztetes = buntetes[1];
            }
            else if (igazolatlan >= 30 && igazolatlan < 40)
            {
                magatartasjegy = buntetesmertek[0];
                figyelmeztetes = buntetes[2];
            }
            else if (igazolatlan >= 40)
            {
                magatartasjegy = buntetesmertek[0];
                figyelmeztetes = buntetes[3];
            }


            // Igazolatlan hiányzások bekérése


            if (10 <= igazolatlan)
            {
                Console.WriteLine("Kérem adja meg a születési dátumát! (YYYY.MM.DD.)");
                szuletesidatum = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Az igazolatlan hiányzások száma: {0}. \nSzületési dátuma: {1}", igazolatlan, szuletesidatum);
            }

            Console.WriteLine("A magatartásod jegye: {0}", magatartasjegy);
            Console.WriteLine(figyelmeztetes);
            Console.ReadKey();
        }
    }
}
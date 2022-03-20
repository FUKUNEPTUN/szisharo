using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace termenyjoslas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdm = new Random();
            double ebuza = 0,
                joslat = 0,
                vlt = rdm.Next(5, 15);
            string uzi = "", kilep = "1";
            string[] evek = new string[] { "átlag alatti", "átlagos", "átlag feletti" };
            while (kilep != "")
            {
                Console.WriteLine("Kérjük adja meg mennyi búzát vetett el idén! (maximum 1t)");
            ebuza = Convert.ToDouble(Console.ReadLine());

            if (ebuza > 1 || 0 > ebuza)
            {
                Console.WriteLine("Csak maximum 1 tonna búzát vethet el");
            }
            else
            {
                joslat = ebuza * vlt;
                if (joslat <= 8)
                {
                    uzi = evek[0];
                    Console.WriteLine("Elvetett búza mennyisége: {0}t\nVárható hozam: {1}t\nSajnos {2} év lesz", ebuza, joslat, uzi);
                }
                else if (joslat <= 12)
                {
                    uzi = evek[1];
                    Console.WriteLine("Elvetett búza mennyisége: {0}t\nVárható hozam: {1}t\nValószínűleg {2} év lesz", ebuza, joslat, uzi);
                }
                else if (joslat >= 15)
                {
                    uzi = evek[2];
                    Console.WriteLine("Elvetett búza mennyisége: {0}t\nVárható hozam: {1}t\nRemélhetőleg {2} év lesz", ebuza, joslat, uzi);
                }
                else
                {
                    Console.WriteLine("Valami hiba történt");
                }
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Ismételjük meg? Üss be bármilyen karakter, ha igen. Kilépéshez csak nyomj egy entert!");
                kilep = Console.ReadLine();
            }
        }
    }
}
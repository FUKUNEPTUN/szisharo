using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda
{
    //    Írjon egy osztályt, a következő metódusokkal:
    //setSzam: Számot olvas be a konzolról.Ellenőrzi, hogy a felhasználó csak számjegyet írjon be, egyébként hiba üzenetet ad.
    //getSzam:  
    //   - ha a beolvasott szám osztható 3-mal, akkor kiírja a konzolra: "három",
    //   - ha a beolvasott szám osztható 5-tel, akkor kiírja a konzolra: "öt",
    //   - egyébként kiírja a számot számjegyekkel.

    //Végül a két metódusnak el kell készíteni a unit tesztjét.
    public class Ehes
    {
        string beker;
        int szam;
        int károly;
        int tovább = 1;
        public Ehes() { }
        public void setSzam()
        {

            while (this.tovább == 1)
            {
                Console.WriteLine("Írja be a számot");
                beker = Console.ReadLine();
                this.tovább = 0;
                if (beker.All(char.IsDigit))
                {
                    this.szam = Convert.ToInt32(beker);
                    Console.WriteLine("Csak számokattartalmaz.");
                }
                else
                {
                    this.tovább = 1;
                    Console.WriteLine("Az általad beírt adat nem csak számokattartalmazott.");
                }
            }

        }
        public string getSzam(int skr)
        {
            
            if (skr % 3 == 0 && skr % 5 == 0)
            {
                return "Öttel, hárommal osztható";

            }
            else if (skr % 5 == 0)
            {
                return "Öt";

            }
            else if (skr % 3 == 0)
            {
                return "Három";

            }
            else
            {
                return "" + skr;

            }
        }

    }
}

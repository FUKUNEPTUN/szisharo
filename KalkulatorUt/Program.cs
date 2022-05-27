using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorUt
{
    public class Kalki
    {
        //valtozok
        double szam1;
        double szam2;
        char muvjel;
        double eredm = 0;
        string uzen = "a művelet eredménye";
        bool nulla = false;
        //Beolvasok
        public void Beolvas()
        {
            Console.WriteLine("Adja meg az első számot");
            szam1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a második számot");
            szam2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a műveletijelet");
            muvjel = Convert.ToChar(Console.ReadLine());
        }
        public double Szam(double a, double b,char sda)
        {
            szam1 = a;
            szam2 = b;
            muvjel = sda;
            switch (muvjel)
            {
                case '+':
                    eredm = szam1 + szam2;
                    break;
                case '-':
                    eredm = szam1 - szam2;
                    break;
                case '*':
                    eredm = szam1 * szam2;
                    break;
                case '/':
                    do
                    {
                        nulla = false;
                        if (szam2 == 0)
                        {
                            nulla = true;
                            Console.WriteLine("Nem lehet nullával osztani. Adjon meg másik számot");
                            szam2 = double.Parse(Console.ReadLine());
                        }
                        eredm = szam1 / szam2;
                    } while (nulla);
                    break;
                default:
                    uzen = "hibás műveletijel";
                    break;
            }
            return eredm;
        }

}
    class Program
    {
        static void Main(string[] args)
        {
            Kalki kalki = new Kalki();
            kalki.Beolvas();
            Console.WriteLine(kalki.Szam(1,2,'/'));
            Console.ReadKey();
        }
    }
}

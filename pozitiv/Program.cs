using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int b1 = 0, b2 = 0;
            string exit = "1";
            while(exit != "")
            {
                Console.WriteLine("Add meg az első számot");
                b1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Add meg a második számot");
                b2 = Convert.ToInt32(Console.ReadLine());
                if (b1 > 0 && b2 > 0)
                {
                    Console.WriteLine("Mindkét szám pozitív");
                }
                else if (b1 < 0 && b2 < 0)
                {
                    Console.WriteLine("Mind negatív");
                }
                else if(b1 > 0 && b2 < 0)
                {
                    Console.WriteLine("Az első szám pozitív, a második negatív");
                }
                else if (b1 < 0 && b2 > 0)
                {
                    Console.WriteLine("Az első szám negatív, a második pozitív");

                }
                else
                {
                    Console.WriteLine("Valamit rosszul írtál be (Pl. 0 nem lehet a megadott szám)");
                }
                Console.WriteLine("Szeretnél mégjátszani? Ha nem csak nyomj egy entert");
                exit = Console.ReadLine();
            }
        }
    }
}

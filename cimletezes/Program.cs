using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cimletezes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a pénz értékét");
            int penz = Convert.ToInt32(Console.ReadLine()), cimletek_helye = 0;
            int[] penzfajtak = new int[] {20000,10000,5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5 ,2,1 };
            while(penz > 0)
            {
                int mennyiseg = penz / penzfajtak[cimletek_helye];
                penz = penz % penzfajtak[cimletek_helye];
                Console.WriteLine("{0} darab {1} Forintos", mennyiseg, penzfajtak[cimletek_helye]);
                cimletek_helye++;
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorozatok
{
    class Sorozat
    {
        int[] sorozat = new int[4];
        int d = 0, n=0;
        public Sorozat() { }
        public void kaposzta()
        {
            Console.WriteLine("Add meg az első 4 elemét a sorozatunknak");
            for (int i = 0; i < 4; i++)
            {
                sorozat[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (sorozat[1] - sorozat[0] == sorozat[2] - sorozat[1] & sorozat[3] - sorozat[2] == sorozat[2] - sorozat[1])
            {
                d = sorozat[1]-sorozat[0];
                n = sorozat[3]+d;
                Console.WriteLine("ez a 4 elem számtani sorozatot alkot. Differenciája {0}; Ötödik eleme {1}",d,n);
            }
            else
            {
                if (sorozat[1] / sorozat[0] == sorozat[2] / sorozat[1] & sorozat[3] / sorozat[2] == sorozat[2] / sorozat[1])
                {
                    d = sorozat[1] / sorozat[0];
                    n = sorozat[3] * d;
                    Console.WriteLine("ez a 4 elem mértani sorozatot alkot. Hányadosa {0}; Ötödik eleme {1}", d, n);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sorozat toros = new Sorozat();
            toros.kaposzta();
            Console.ReadKey();
        }
    }
}

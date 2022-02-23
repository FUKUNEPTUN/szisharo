using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamertek
{
    class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random();
            int b1 = 0,b2=0, b3=0,b4=0,b5=0, b6 = n.Next(5, 10);

            while (b3 < b6)
            {
                Console.WriteLine("Add meg a számot");
                b1 = Convert.ToInt32(Console.ReadLine());
               
                if (b1 % 2 == 1)
                {
                    b4++;
                    b2 = b2 + b1;
                }
                else if(b1 % 2 == 0)
                {
                    b5++;
                }
                b3++;
            }
            Console.WriteLine("A program lefutott az eredmények a következők. Ennyi bekérés történt: {3}. Párosok száma {2}. Páratlanok száma {0}. Páratlanok összege {1}. ", b4, b2, b5,b6);
            Console.ReadLine();
        }
    }
}

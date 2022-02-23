using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponthatar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a pontot amit elért!");
            int pont = Convert.ToInt32(Console.ReadLine());
            if (pont < 0)
            {
                Console.WriteLine("Kérem adjon meg egy valós értéket!");
            }
            else if (pont < 50)
            {
                Console.WriteLine("Elégtelen");
            }
            else if (pont >= 50 && pont < 65)
            {
                Console.WriteLine("Elégséges");
            }
            else if (pont >= 65 && pont < 80)
            {
                Console.WriteLine("Közepes");
            }
            else if (pont >= 80 && pont < 90)
            {
                Console.WriteLine("Jó");
            }
            else if (pont >= 90)
            {
                Console.WriteLine("Jeles");
            }
            else if (pont > 100)
            {
                Console.WriteLine("Kérem adjon meg egy valós értéket!");
            }
            Console.ReadKey();
        }
    }
}

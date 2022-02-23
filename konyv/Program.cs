using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyv
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "a", k2;
            int k1 = 0;

            while (a != "")
            {
                Console.WriteLine("Add meg a könyv címét:  ");
                k2 = Console.ReadLine();
                Console.WriteLine("Add meg a könyv oldalai számát:  ");
                k1 = Convert.ToInt32(Console.ReadLine());
                if(k1 < 150)
                {
                    Console.WriteLine("A(z) {0} rövid terjedelmű könyv", k2);
                }
                else if (k1 > 150)
                {
                    Console.WriteLine("A(z) {0} hosszú terjedelmű könyv", k2);
                }
                else if (k1 == 150)
                {
                    Console.WriteLine("A könyved pont 150 oldalas");
                }
                else
                {
                    Console.WriteLine("Valami galiba van");
                }
                Console.WriteLine("Szeretnél könyvet tesztelni? Ha nem csak nyomj egy entert");
                a = Console.ReadLine();
            }
        }
    }
}

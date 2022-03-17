using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halmaz
{
    class halmazok
    {
        public halmazok() { }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hány elem szerepeljen?");
            int szam = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[] a = new int[] {rnd.Next(-100, 100)};
            int[] b = new int[] {rnd.Next(-100, 100)};
            if (szam >= 200)
            {
                for (int i = 0; i < szam; i++)
                {
                     int af= a[i];
                     int bf = b[i];
                }
            }
            Console.WriteLine(af);
            Console.WriteLine(bf);
            /*  else
              {
                 for (int i = 0; i < rnd.Next(1, 10); i++)
                  {
                      int af = a[i];
                     int bf = b[i];
                      Console.WriteLine(af);
                      Console.WriteLine(bf);
                  } 

              }

              */
            Console.ReadKey();
        }
    }
}

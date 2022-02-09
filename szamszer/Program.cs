using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamszer
{
    class Program
    {
        static void Main(string[] args)
        {
            int alsohatar = 1,
                felsohatar = 101,
                probal = 5,
                gondoltszam,
                tipp;
                
            Random rnd = new Random();
            do
            {
                Console.WriteLine("Leszel az aki kitalálja?")
                if (Console.ReadKey().KeyChar == 'i')
                {
                    gondoltszam = rnd.Next(alsohatar, felsohatar);
                    for(int i = 0; i <= probal; i++)
                }

                Console.WriteLine("Folytatjuk? (i/n)");
            } while(Console.ReadKey().KeyChar == 'i');
            Console.ReadKey();

        }
    }
}
